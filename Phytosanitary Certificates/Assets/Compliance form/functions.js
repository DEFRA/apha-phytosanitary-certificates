/**
 * Main interactivity script for the page:
 * - Handles dark/light theme toggle (persisted in localStorage + URL parameter option to change)
 * - Enables color-vision-deficiency (CVD) friendly mode
 * - Supports "single expand" accordion behavior (only one <details> open at a time)
 * - Provides "Expand All / Collapse All" functionality
 * - Opens/closes the PDF side panel and manages backdrop
 * All preferences are saved to localStorage and reflected in the URL for shareable settings.
 */

document.addEventListener('DOMContentLoaded', () => {
  const body = document.body;
  const themeToggle = document.getElementById('theme-toggle');
  const cvdToggle = document.getElementById('cvd-toggle');
  const singleExpandToggle = document.getElementById('single-expand-toggle');
  const collapseToggle = document.getElementById('collapse-toggle');
  const pdfPanel = document.querySelector('.pdf-panel');
  const pdfBanner = document.querySelector('.pdf-banner');
  const closePanel = document.querySelector('.close-panel');
  const backdrop = document.querySelector('.backdrop');
  const statusAnnouncer = document.querySelector('.status-announcer');
  let isCollapsed = true;

  // Initialize all accordions as closed
  const details = document.querySelectorAll('details');
  details.forEach(detail => {
    detail.open = false;
  });

  // Theme, CVD, and Single Expand mode initialization
  const urlParams = new URLSearchParams(window.location.search);
  const theme = urlParams.get('theme') || localStorage.getItem('theme') || 'light';
  const cvdMode = urlParams.get('cvd') || localStorage.getItem('cvd') || 'standard';
  const singleExpand = urlParams.get('singleExpand') || localStorage.getItem('singleExpand') || 'false';

  if (theme === 'dark') {
    body.classList.add('dark-mode');
    themeToggle.checked = true;
  }
  if (cvdMode === 'colorblind') {
    body.classList.add('cvd-mode');
    cvdToggle.checked = true;
  }
  if (singleExpand === 'true') {
    body.classList.add('single-expand');
    singleExpandToggle.checked = true;
  }

  // Theme toggle
  themeToggle.addEventListener('change', () => {
    body.classList.toggle('dark-mode');
    const newTheme = body.classList.contains('dark-mode') ? 'dark' : 'light';
    localStorage.setItem('theme', newTheme);
    updateQueryString({ theme: newTheme });
  });

  // CVD toggle
  cvdToggle.addEventListener('change', () => {
    body.classList.toggle('cvd-mode');
    const newCvdMode = body.classList.contains('cvd-mode') ? 'colorblind' : 'standard';
    localStorage.setItem('cvd', newCvdMode);
    updateQueryString({ cvd: newCvdMode });
  });

  // Single Expand toggle
  singleExpandToggle.addEventListener('change', () => {
    body.classList.toggle('single-expand');
    const newSingleExpand = body.classList.contains('single-expand') ? 'true' : 'false';
    localStorage.setItem('singleExpand', newSingleExpand);
    updateQueryString({ singleExpand: newSingleExpand });
  });

  // Single Expand behavior
  const singleExpandHandler = (event) => {
    if (body.classList.contains('single-expand') && event.target.open) {
      details.forEach(otherDetail => {
        if (otherDetail !== event.target) {
          otherDetail.open = false;
        }
      });
    }
  };

  // Attach single expand handler
  details.forEach(detail => {
    detail.addEventListener('toggle', singleExpandHandler);
  });

  // Collapse toggle
  collapseToggle.addEventListener('click', () => {
    details.forEach(detail => {
      detail.removeEventListener('toggle', singleExpandHandler);
    });

    if (isCollapsed) {
      details.forEach(detail => {
        detail.open = true;
      });
      collapseToggle.innerHTML = `<i aria-hidden="true" class="fas fa-chevron-up"></i>Collapse All`;
      collapseToggle.setAttribute('aria-label', 'Collapse all accordions');
      isCollapsed = false;
    } else {
      details.forEach(detail => {
        detail.open = false;
      });
      collapseToggle.innerHTML = `<i aria-hidden="true" class="fas fa-chevron-down"></i>Expand All`;
      collapseToggle.setAttribute('aria-label', 'Expand all accordions');
      isCollapsed = true;
    }

    setTimeout(() => {
      details.forEach(detail => {
        detail.addEventListener('toggle', singleExpandHandler);
      });
    }, 0);
  });



/**
 * Update tracker pane status
 * Updates the visual status of each product in the sidebar tracker pane
 * based on the currently selected outcome button ("Compliant" / "On-hold")
 * and comment field (when On-hold is selected).
 *
 * - Marks items as "complete" (green check), "pending" (yellow pause – requires comments),
 *   or "unfinished" (red warning).
 * - Updates icons, aria-labels, and live-region announcements for accessibility.
 * - Highlights missing comments with an error state when "On-hold" is chosen without text.
 * 
 * Called whenever a user changes an outcome button or types in the comments field.
 */
// 
function updateTrackerStatus() {
  document.querySelectorAll('.button-group').forEach(group => {
    const detailsElement = group.closest('details');
    if (!detailsElement) {
      console.warn('No parent <details> element found for button group:', group);
      return; // Skip if no parent details element
    }

    const productId = detailsElement.id; // e.g., product0001
    // Extract numeric part and format it
    const productNumber = parseInt(productId.replace('product', ''), 10); // e.g., 1
    const formattedNumber = productNumber.toString().padStart(2, '0'); // e.g., '01'

    const trackerLink = document.querySelector(`.tracker-pane a[href="#${productId}"]`);
    const trackerItem = trackerLink ? trackerLink.parentElement : null;
    if (!trackerItem) {
      console.warn(`Tracker item not found for productId: ${productId}`);
      return; // Skip if tracker item not found
    }

    const buttons = group.querySelectorAll('.btn-outcome');
    const activeButton = group.querySelector('.btn-outcome.active');
    const accordionControls = group.closest('.accordion-controls');
    const commentsInput = accordionControls ? accordionControls.querySelector('input[type="text"]') : null;
    const comments = commentsInput ? commentsInput.value.trim() : '';

    // Remove existing status classes
    trackerItem.classList.remove('complete', 'unfinished', 'pending');
    if (commentsInput) commentsInput.classList.remove('error');

    let statusText = '';
    let iconClass = '';
    let ariaLabel = '';

    if (activeButton) {
      const status = activeButton.dataset.value;
      if (status === 'Compliant') {
        trackerItem.classList.add('complete');
        iconClass = 'fas fa-check';
        statusText = 'Done';
        ariaLabel = `Navigate to product ${formattedNumber}, complete`;
        if (statusAnnouncer) {
          statusAnnouncer.textContent = `Product ${formattedNumber} marked as complete`;
        }
      } else if (status === 'On-hold') { // Match HTML's data-value="On-hold"
        if (comments) {
          trackerItem.classList.add('complete');
          iconClass = 'fas fa-check';
          statusText = 'Done';
          ariaLabel = `Navigate to product ${formattedNumber}, complete`;
          if (statusAnnouncer) {
            statusAnnouncer.textContent = `Product ${formattedNumber} marked as complete with comments`;
          }
        } else {
          trackerItem.classList.add('pending'); // Fixed typo: LozclassList -> classList
          iconClass = 'fas fa-pause';
          statusText = 'Pending';
          ariaLabel = `Navigate to product ${formattedNumber}, on hold pending comments`;
          if (commentsInput) commentsInput.classList.add('error');
          if (statusAnnouncer) {
            statusAnnouncer.textContent = `Product ${formattedNumber} marked as on hold, comments required`;
          }
        }
      }
    } else {
      trackerItem.classList.add('unfinished');
      iconClass = 'fas fa-exclamation-triangle';
      statusText = 'Incomplete';
      ariaLabel = `Navigate to product ${formattedNumber}, incomplete`;
      if (statusAnnouncer) {
        statusAnnouncer.textContent = `Product ${formattedNumber} marked as incomplete`;
      }
    }

    const iconElement = trackerItem.querySelector('i');
    if (iconElement) {
      iconElement.className = iconClass;
    } else {
      console.warn(`Icon element not found in tracker item for productId: ${productId}`);
    }

    trackerLink.setAttribute('aria-label', ariaLabel);
  });

  // Check if submit button can be enabled
  updateSubmitButtonState();
}

// Initial check in case all products are already complete on page load. Enables/disables Submit button
updateSubmitButtonState();



/**
 * Enables the Submit button only when every product is marked as complete
 * (i.e. every tracker item has the "complete" class).
 * 
 * Called from updateTrackerStatus() whenever the visual status of any product changes.
 */
function updateSubmitButtonState() {
  const allComplete = document.querySelectorAll('.tracker-pane li').length ===
                      document.querySelectorAll('.tracker-pane li.complete').length;

  const submitBtn = document.querySelector('.submit-btn');
  if (submitBtn) {
    submitBtn.disabled = !allComplete;

    // Optional: give a helpful aria-label so screen-reader users know why it's disabled
    if (allComplete) {
      submitBtn.removeAttribute('aria-disabled');
      submitBtn.setAttribute('aria-label', 'Submit all product outcomes');
      updateButtonStates();
    } else {
      submitBtn.setAttribute('aria-disabled', 'true');
      submitBtn.setAttribute('aria-label', 'Submit all product outcomes – disabled until all products are complete');
    }
  }
}



/**
 * Sets up interactive behavior for all outcome button groups (Compliant / On-hold):
 * - Ensures only one button can be active at a time (radio-button-like behavior)
 * - Updates the sidebar tracker status immediately when a button is clicked
 * - Watches the comments input field (if present) and refreshes tracker status on any change
 * - Calls updateButtonStates() to enable/disable Save/Clear buttons based on current selection
 * 
 * This code runs once when the script loads and binds events to all accordions - making sure any changes update the tracker and hidden div with button values
 */
// Button group interactivity
document.querySelectorAll('.button-group').forEach(group => {
  const buttons = group.querySelectorAll('.btn-outcome');
  buttons.forEach(button => {
    button.addEventListener('click', () => {
      buttons.forEach(btn => btn.classList.remove('active'));
      button.classList.add('active');
      updateTrackerStatus();
      updateButtonStates();
    });
  });

  // Monitor comments input for changes
  const accordionControls = group.closest('.accordion-controls');
  const commentsInput = accordionControls ? accordionControls.querySelector('input[type="text"]') : null;
  if (commentsInput) {
    commentsInput.addEventListener('input', updateTrackerStatus);
    updateButtonStates();
  }
});



/**
 * Updates the URL query string with new parameter values without triggering a page reload.
 * Uses `history.replaceState()` to silently modify the browser's current URL.
 * 
 * Purpose: Keeps preferences like theme, CVD mode, and single-expand state shareable
 * and bookmarkable by reflecting them in the URL (e.g., ?theme=dark&cvd=colorblind).
 * 
 */
// Update query string without reload
function updateQueryString(params) {
  const currentParams = new URLSearchParams(window.location.search);
  for (const [key, value] of Object.entries(params)) {
    currentParams.set(key, value);
  }
  history.replaceState(null, '', `?${currentParams.toString()}`);
}



/**
 * PDF Panel Controls
 * Handles opening and closing the slide-in PDF viewer panel:
 * - Clicking the PDF banner opens the panel and shows the dark backdrop
 * - Clicking the close button (×) or clicking the backdrop itself closes the panel
 * - Updates `aria-hidden` for accessibility and screen readers
 * 
 * Provides a non-intrusive way to preview/download the full report without leaving the page.
 */
// PDF panel toggle
pdfBanner.addEventListener('click', () => {
  pdfPanel.classList.add('active');
  pdfPanel.setAttribute('aria-hidden', 'false');
  backdrop.classList.add('active');
});
closePanel.addEventListener('click', () => {
  pdfPanel.classList.remove('active');
  pdfPanel.setAttribute('aria-hidden', 'true');
  backdrop.classList.remove('active');
});
// Backdrop click to close PDF panel (if user clicks anywhere off the PDF)
  backdrop.addEventListener('click', () => {
    pdfPanel.classList.remove('active');
    pdfPanel.setAttribute('aria-hidden', 'true');
    backdrop.classList.remove('active');
  });
});



/**
 * Collects the current state of all product accordions (selected outcome + comments)
 * and serializes it as JSON into a hidden `<div id="buttonStates">`.
 * 
 * Runs whenever:
 * - An outcome button is clicked
 * - Comments are typed
 * - Page loads (initial sync)
 * - Submit button is enabled
 * 
 * The resulting JSON structure: { "0001": { "outcome": "Compliant", "comments": "All good" }, ... }
 */
// Update hidden div with values of all controls on page
function updateButtonStates() {
    const allData = {};

    // Select all product <details> elements
    document.querySelectorAll("details[id^='product']").forEach(prod => {
        const productId = prod.id.replace("product", "");

        // Find active outcome button
        const activeBtn = prod.querySelector(".btn-outcome.active");
        const outcome = activeBtn ? activeBtn.dataset.value : null;

        // Read comments field
        const commentsInput = prod.querySelector(`#comments${productId}`);
        const comments = commentsInput ? commentsInput.value : "";

        // Build record
        allData[productId] = {
            outcome: outcome,
            comments: comments
        };
    });

    // Save JSON to hidden div
    document.querySelector("#buttonStates").textContent = JSON.stringify(allData);
}