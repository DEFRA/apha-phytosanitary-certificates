using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Interfaces;
using UiPath.Activities.Contracts;
using PhytosanitaryCertificates;

[assembly: WorkflowRunnerServiceAttribute(typeof(PhytosanitaryCertificates.WorkflowRunnerService))]
namespace PhytosanitaryCertificates
{
    public class WorkflowRunnerService
    {
        private readonly ICodedWorkflowServices _services;
        public WorkflowRunnerService(ICodedWorkflowServices services)
        {
            _services = services;
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Compare IPAFFS Information.xaml
        /// </summary>
        public (System.Data.DataTable out_dtCommodityLines, System.Data.DataTable io_dtOnHoldReasons) Compare_IPAFFS_Information(string in_ApplicationRef, System.Data.DataTable io_dtOnHoldReasons)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Compare IPAFFS Information.xaml", new Dictionary<string, object>{{"in_ApplicationRef", in_ApplicationRef}, {"io_dtOnHoldReasons", io_dtOnHoldReasons}}, default, default, default, GetAssemblyName());
            return ((System.Data.DataTable)result["out_dtCommodityLines"], (System.Data.DataTable)result["io_dtOnHoldReasons"]);
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Compare IPAFFS Information.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public (System.Data.DataTable out_dtCommodityLines, System.Data.DataTable io_dtOnHoldReasons) Compare_IPAFFS_Information(string in_ApplicationRef, System.Data.DataTable io_dtOnHoldReasons, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Compare IPAFFS Information.xaml", new Dictionary<string, object>{{"in_ApplicationRef", in_ApplicationRef}, {"io_dtOnHoldReasons", io_dtOnHoldReasons}}, default, isolated, default, GetAssemblyName());
            return ((System.Data.DataTable)result["out_dtCommodityLines"], (System.Data.DataTable)result["io_dtOnHoldReasons"]);
        }

        /// <summary>
        /// Invokes the Process/Process Transaction.xaml
        /// </summary>
        public void Process_Transaction()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Transaction.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Transaction.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Process_Transaction(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Transaction.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Compare IPAFFS Information (Old).xaml
        /// </summary>
        public System.Data.DataTable Compare_IPAFFS_Information__Old_(string in_ApplicationRef, System.Data.DataTable io_dtOnHoldReasons)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Compare IPAFFS Information (Old).xaml", new Dictionary<string, object>{{"in_ApplicationRef", in_ApplicationRef}, {"io_dtOnHoldReasons", io_dtOnHoldReasons}}, default, default, default, GetAssemblyName());
            return (System.Data.DataTable)result["io_dtOnHoldReasons"];
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Compare IPAFFS Information (Old).xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public System.Data.DataTable Compare_IPAFFS_Information__Old_(string in_ApplicationRef, System.Data.DataTable io_dtOnHoldReasons, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Compare IPAFFS Information (Old).xaml", new Dictionary<string, object>{{"in_ApplicationRef", in_ApplicationRef}, {"io_dtOnHoldReasons", io_dtOnHoldReasons}}, default, isolated, default, GetAssemblyName());
            return (System.Data.DataTable)result["io_dtOnHoldReasons"];
        }

        /// <summary>
        /// Invokes the Main.xaml
        /// </summary>
        public void Main(bool in_boolUnattended)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Main.xaml", new Dictionary<string, object>{{"in_boolUnattended", in_boolUnattended}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Main.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Main(bool in_boolUnattended, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Main.xaml", new Dictionary<string, object>{{"in_boolUnattended", in_boolUnattended}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Extract Information.xaml
        /// </summary>
        public (string out_strPhytoCertNo, string out_strExporterAddress, string out_strConsignee, string out_strAdditionalDeclarions, string out_strIssueDate, System.Data.DataTable out_dtCommodityLines, string out_strPlaceOfOrigin) Extract_Information(string in_PhytoCertLocation, string in_pageRange)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Extract Information.xaml", new Dictionary<string, object>{{"in_PhytoCertLocation", in_PhytoCertLocation}, {"in_pageRange", in_pageRange}}, default, default, default, GetAssemblyName());
            return ((string)result["out_strPhytoCertNo"], (string)result["out_strExporterAddress"], (string)result["out_strConsignee"], (string)result["out_strAdditionalDeclarions"], (string)result["out_strIssueDate"], (System.Data.DataTable)result["out_dtCommodityLines"], (string)result["out_strPlaceOfOrigin"]);
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Extract Information.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public (string out_strPhytoCertNo, string out_strExporterAddress, string out_strConsignee, string out_strAdditionalDeclarions, string out_strIssueDate, System.Data.DataTable out_dtCommodityLines, string out_strPlaceOfOrigin) Extract_Information(string in_PhytoCertLocation, string in_pageRange, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Extract Information.xaml", new Dictionary<string, object>{{"in_PhytoCertLocation", in_PhytoCertLocation}, {"in_pageRange", in_pageRange}}, default, isolated, default, GetAssemblyName());
            return ((string)result["out_strPhytoCertNo"], (string)result["out_strExporterAddress"], (string)result["out_strConsignee"], (string)result["out_strAdditionalDeclarions"], (string)result["out_strIssueDate"], (System.Data.DataTable)result["out_dtCommodityLines"], (string)result["out_strPlaceOfOrigin"]);
        }

        /// <summary>
        /// Invokes the Framework/SetTransactionStatus.xaml
        /// </summary>
        public (int io_intConSysEx, int io_RetryNumber, int io_TransactionNumber) SetTransactionStatus(UiPath.Core.BusinessRuleException in_BusinessException, System.DateTime in_dateCaseStartTime, string in_strWorkLogFilepath, System.Exception in_SystemException, int io_intConSysEx, int io_RetryNumber, int io_TransactionNumber)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\SetTransactionStatus.xaml", new Dictionary<string, object>{{"in_BusinessException", in_BusinessException}, {"in_dateCaseStartTime", in_dateCaseStartTime}, {"in_strWorkLogFilepath", in_strWorkLogFilepath}, {"in_SystemException", in_SystemException}, {"io_intConSysEx", io_intConSysEx}, {"io_RetryNumber", io_RetryNumber}, {"io_TransactionNumber", io_TransactionNumber}}, default, default, default, GetAssemblyName());
            return ((int)result["io_intConSysEx"], (int)result["io_RetryNumber"], (int)result["io_TransactionNumber"]);
        }

        /// <summary>
        /// Invokes the Framework/SetTransactionStatus.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public (int io_intConSysEx, int io_RetryNumber, int io_TransactionNumber) SetTransactionStatus(UiPath.Core.BusinessRuleException in_BusinessException, System.DateTime in_dateCaseStartTime, string in_strWorkLogFilepath, System.Exception in_SystemException, int io_intConSysEx, int io_RetryNumber, int io_TransactionNumber, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\SetTransactionStatus.xaml", new Dictionary<string, object>{{"in_BusinessException", in_BusinessException}, {"in_dateCaseStartTime", in_dateCaseStartTime}, {"in_strWorkLogFilepath", in_strWorkLogFilepath}, {"in_SystemException", in_SystemException}, {"io_intConSysEx", io_intConSysEx}, {"io_RetryNumber", io_RetryNumber}, {"io_TransactionNumber", io_TransactionNumber}}, default, isolated, default, GetAssemblyName());
            return ((int)result["io_intConSysEx"], (int)result["io_RetryNumber"], (int)result["io_TransactionNumber"]);
        }

        /// <summary>
        /// Invokes the Framework/GetTransactionData.xaml
        /// </summary>
        public bool GetTransactionData(int in_TransactionNumber, string in_strProcessType, bool in_boolContinue)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\GetTransactionData.xaml", new Dictionary<string, object>{{"in_TransactionNumber", in_TransactionNumber}, {"in_strProcessType", in_strProcessType}, {"in_boolContinue", in_boolContinue}}, default, default, default, GetAssemblyName());
            return (bool)result["out_boolLastTransaction"];
        }

        /// <summary>
        /// Invokes the Framework/GetTransactionData.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public bool GetTransactionData(int in_TransactionNumber, string in_strProcessType, bool in_boolContinue, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\GetTransactionData.xaml", new Dictionary<string, object>{{"in_TransactionNumber", in_TransactionNumber}, {"in_strProcessType", in_strProcessType}, {"in_boolContinue", in_boolContinue}}, default, isolated, default, GetAssemblyName());
            return (bool)result["out_boolLastTransaction"];
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Check No of Certs.xaml
        /// </summary>
        public (System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<int>> out_dictCertPageRanges, System.Data.DataTable io_dtOnHoldReasons) Check_No_of_Certs(string in_IPAFFSCertificateReference, string in_PhytoCertFilepath, string in_strCHEDPPReference, System.Data.DataTable io_dtOnHoldReasons)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Check No of Certs.xaml", new Dictionary<string, object>{{"in_IPAFFSCertificateReference", in_IPAFFSCertificateReference}, {"in_PhytoCertFilepath", in_PhytoCertFilepath}, {"in_strCHEDPPReference", in_strCHEDPPReference}, {"io_dtOnHoldReasons", io_dtOnHoldReasons}}, default, default, default, GetAssemblyName());
            return ((System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<int>>)result["out_dictCertPageRanges"], (System.Data.DataTable)result["io_dtOnHoldReasons"]);
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Check No of Certs.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public (System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<int>> out_dictCertPageRanges, System.Data.DataTable io_dtOnHoldReasons) Check_No_of_Certs(string in_IPAFFSCertificateReference, string in_PhytoCertFilepath, string in_strCHEDPPReference, System.Data.DataTable io_dtOnHoldReasons, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Check No of Certs.xaml", new Dictionary<string, object>{{"in_IPAFFSCertificateReference", in_IPAFFSCertificateReference}, {"in_PhytoCertFilepath", in_PhytoCertFilepath}, {"in_strCHEDPPReference", in_strCHEDPPReference}, {"io_dtOnHoldReasons", io_dtOnHoldReasons}}, default, isolated, default, GetAssemblyName());
            return ((System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<int>>)result["out_dictCertPageRanges"], (System.Data.DataTable)result["io_dtOnHoldReasons"]);
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Validate QR Code.xaml
        /// </summary>
        public System.Data.DataTable Validate_QR_Code(string in_PhytoCertLocation, string in_ApplicationRef, string in_PhytoCertNumber, int in_intQRPageNumber, System.Data.DataTable io_dtOnHoldReasons)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Validate QR Code.xaml", new Dictionary<string, object>{{"in_PhytoCertLocation", in_PhytoCertLocation}, {"in_ApplicationRef", in_ApplicationRef}, {"in_PhytoCertNumber", in_PhytoCertNumber}, {"in_intQRPageNumber", in_intQRPageNumber}, {"io_dtOnHoldReasons", io_dtOnHoldReasons}}, default, default, default, GetAssemblyName());
            return (System.Data.DataTable)result["io_dtOnHoldReasons"];
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Validate QR Code.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public System.Data.DataTable Validate_QR_Code(string in_PhytoCertLocation, string in_ApplicationRef, string in_PhytoCertNumber, int in_intQRPageNumber, System.Data.DataTable io_dtOnHoldReasons, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Validate QR Code.xaml", new Dictionary<string, object>{{"in_PhytoCertLocation", in_PhytoCertLocation}, {"in_ApplicationRef", in_ApplicationRef}, {"in_PhytoCertNumber", in_PhytoCertNumber}, {"in_intQRPageNumber", in_intQRPageNumber}, {"io_dtOnHoldReasons", io_dtOnHoldReasons}}, default, isolated, default, GetAssemblyName());
            return (System.Data.DataTable)result["io_dtOnHoldReasons"];
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Pause Point (Check Extracted Info).xaml
        /// </summary>
        public void Pause_Point__Check_Extracted_Info_(string in_strExporterAddress, string in_strConsignee, string in_strPhytoCertNo, string in_strPlaceOfOrigin, string in_strIssueDate, string in_strAdditionalDeclarions, System.Data.DataTable in_dtCommodityLines, System.Collections.Generic.Dictionary<string, string> in_dictApplicationInfo, System.Data.DataTable in_dtIPAFFSCommodityInfo, string in_FormattedCertNo, string in_strAttachmentFilepath)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Pause Point (Check Extracted Info).xaml", new Dictionary<string, object>{{"in_strExporterAddress", in_strExporterAddress}, {"in_strConsignee", in_strConsignee}, {"in_strPhytoCertNo", in_strPhytoCertNo}, {"in_strPlaceOfOrigin", in_strPlaceOfOrigin}, {"in_strIssueDate", in_strIssueDate}, {"in_strAdditionalDeclarions", in_strAdditionalDeclarions}, {"in_dtCommodityLines", in_dtCommodityLines}, {"in_dictApplicationInfo", in_dictApplicationInfo}, {"in_dtIPAFFSCommodityInfo", in_dtIPAFFSCommodityInfo}, {"in_FormattedCertNo", in_FormattedCertNo}, {"in_strAttachmentFilepath", in_strAttachmentFilepath}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/Pause Point (Check Extracted Info).xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Pause_Point__Check_Extracted_Info_(string in_strExporterAddress, string in_strConsignee, string in_strPhytoCertNo, string in_strPlaceOfOrigin, string in_strIssueDate, string in_strAdditionalDeclarions, System.Data.DataTable in_dtCommodityLines, System.Collections.Generic.Dictionary<string, string> in_dictApplicationInfo, System.Data.DataTable in_dtIPAFFSCommodityInfo, string in_FormattedCertNo, string in_strAttachmentFilepath, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\Pause Point (Check Extracted Info).xaml", new Dictionary<string, object>{{"in_strExporterAddress", in_strExporterAddress}, {"in_strConsignee", in_strConsignee}, {"in_strPhytoCertNo", in_strPhytoCertNo}, {"in_strPlaceOfOrigin", in_strPlaceOfOrigin}, {"in_strIssueDate", in_strIssueDate}, {"in_strAdditionalDeclarions", in_strAdditionalDeclarions}, {"in_dtCommodityLines", in_dtCommodityLines}, {"in_dictApplicationInfo", in_dictApplicationInfo}, {"in_dtIPAFFSCommodityInfo", in_dtIPAFFSCommodityInfo}, {"in_FormattedCertNo", in_FormattedCertNo}, {"in_strAttachmentFilepath", in_strAttachmentFilepath}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the spol list test.xaml
        /// </summary>
        public void spol_list_test()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"spol list test.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the spol list test.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void spol_list_test(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"spol list test.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/RetryCurrentTransaction.xaml
        /// </summary>
        public (int io_RetryNumber, int io_TransactionNumber) RetryCurrentTransaction(System.Exception in_SystemException, bool in_QueueRetry, int io_RetryNumber, int io_TransactionNumber)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\RetryCurrentTransaction.xaml", new Dictionary<string, object>{{"in_SystemException", in_SystemException}, {"in_QueueRetry", in_QueueRetry}, {"io_RetryNumber", io_RetryNumber}, {"io_TransactionNumber", io_TransactionNumber}}, default, default, default, GetAssemblyName());
            return ((int)result["io_RetryNumber"], (int)result["io_TransactionNumber"]);
        }

        /// <summary>
        /// Invokes the Framework/RetryCurrentTransaction.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public (int io_RetryNumber, int io_TransactionNumber) RetryCurrentTransaction(System.Exception in_SystemException, bool in_QueueRetry, int io_RetryNumber, int io_TransactionNumber, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\RetryCurrentTransaction.xaml", new Dictionary<string, object>{{"in_SystemException", in_SystemException}, {"in_QueueRetry", in_QueueRetry}, {"io_RetryNumber", io_RetryNumber}, {"io_TransactionNumber", io_TransactionNumber}}, default, isolated, default, GetAssemblyName());
            return ((int)result["io_RetryNumber"], (int)result["io_TransactionNumber"]);
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/AD/Create Compliance Form.xaml
        /// </summary>
        public System.Data.DataTable Create_Compliance_Form(string in_strPhytoFilepath, System.Data.DataTable in_dtAdditionalDeclarations, System.Data.DataTable io_dtCommodityLines)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\AD\Create Compliance Form.xaml", new Dictionary<string, object>{{"in_strPhytoFilepath", in_strPhytoFilepath}, {"in_dtAdditionalDeclarations", in_dtAdditionalDeclarations}, {"io_dtCommodityLines", io_dtCommodityLines}}, default, default, default, GetAssemblyName());
            return (System.Data.DataTable)result["io_dtCommodityLines"];
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/AD/Create Compliance Form.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public System.Data.DataTable Create_Compliance_Form(string in_strPhytoFilepath, System.Data.DataTable in_dtAdditionalDeclarations, System.Data.DataTable io_dtCommodityLines, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\AD\Create Compliance Form.xaml", new Dictionary<string, object>{{"in_strPhytoFilepath", in_strPhytoFilepath}, {"in_dtAdditionalDeclarations", in_dtAdditionalDeclarations}, {"io_dtCommodityLines", io_dtCommodityLines}}, default, isolated, default, GetAssemblyName());
            return (System.Data.DataTable)result["io_dtCommodityLines"];
        }

        /// <summary>
        /// Invokes the Test.xaml
        /// </summary>
        public void Test()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Test.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Test.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Test(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Test.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/blue part 2/TEST - MS dynamics.xaml
        /// </summary>
        public void TEST___MS_dynamics()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\blue part 2\TEST - MS dynamics.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/blue part 2/TEST - MS dynamics.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void TEST___MS_dynamics(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\blue part 2\TEST - MS dynamics.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/AD/DataVerse.xaml
        /// </summary>
        public (Newtonsoft.Json.Linq.JObject out_jsonRegulationResponse, System.Data.DataTable io_dtCommodityLines) DataVerse(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSCredential> in_Credentials, System.Data.DataTable io_dtCommodityLines)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\AD\DataVerse.xaml", new Dictionary<string, object>{{"in_Credentials", in_Credentials}, {"io_dtCommodityLines", io_dtCommodityLines}}, default, default, default, GetAssemblyName());
            return ((Newtonsoft.Json.Linq.JObject)result["out_jsonRegulationResponse"], (System.Data.DataTable)result["io_dtCommodityLines"]);
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/AD/DataVerse.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public (Newtonsoft.Json.Linq.JObject out_jsonRegulationResponse, System.Data.DataTable io_dtCommodityLines) DataVerse(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSCredential> in_Credentials, System.Data.DataTable io_dtCommodityLines, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\AD\DataVerse.xaml", new Dictionary<string, object>{{"in_Credentials", in_Credentials}, {"io_dtCommodityLines", io_dtCommodityLines}}, default, isolated, default, GetAssemblyName());
            return ((Newtonsoft.Json.Linq.JObject)result["out_jsonRegulationResponse"], (System.Data.DataTable)result["io_dtCommodityLines"]);
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/blue part 2/TEST - IPAFFS Data Submission.xaml
        /// </summary>
        public void TEST___IPAFFS_Data_Submission()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\blue part 2\TEST - IPAFFS Data Submission.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/blue part 2/TEST - IPAFFS Data Submission.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void TEST___IPAFFS_Data_Submission(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\blue part 2\TEST - IPAFFS Data Submission.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/TakeScreenshot.xaml
        /// </summary>
        public string TakeScreenshot(string in_Folder, string io_FilePath)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\TakeScreenshot.xaml", new Dictionary<string, object>{{"in_Folder", in_Folder}, {"io_FilePath", io_FilePath}}, default, default, default, GetAssemblyName());
            return (string)result["io_FilePath"];
        }

        /// <summary>
        /// Invokes the Framework/TakeScreenshot.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public string TakeScreenshot(string in_Folder, string io_FilePath, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\TakeScreenshot.xaml", new Dictionary<string, object>{{"in_Folder", in_Folder}, {"io_FilePath", io_FilePath}}, default, isolated, default, GetAssemblyName());
            return (string)result["io_FilePath"];
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/blue part 2/MS Dynamics.xaml
        /// </summary>
        public System.Data.DataTable MS_Dynamics(System.DateTime in_dteTimeStamp, System.Data.DataTable io_dtOnHoldReasons)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\blue part 2\MS Dynamics.xaml", new Dictionary<string, object>{{"in_dteTimeStamp", in_dteTimeStamp}, {"io_dtOnHoldReasons", io_dtOnHoldReasons}}, default, default, default, GetAssemblyName());
            return (System.Data.DataTable)result["io_dtOnHoldReasons"];
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/blue part 2/MS Dynamics.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public System.Data.DataTable MS_Dynamics(System.DateTime in_dteTimeStamp, System.Data.DataTable io_dtOnHoldReasons, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\blue part 2\MS Dynamics.xaml", new Dictionary<string, object>{{"in_dteTimeStamp", in_dteTimeStamp}, {"io_dtOnHoldReasons", io_dtOnHoldReasons}}, default, isolated, default, GetAssemblyName());
            return (System.Data.DataTable)result["io_dtOnHoldReasons"];
        }

        /// <summary>
        /// Invokes the Framework/InitAllSettings.xaml
        /// </summary>
        public System.Collections.Generic.Dictionary<string, System.Management.Automation.PSCredential> InitAllSettings(string in_OrchestratorFolders, bool in_RetrieveCredentials)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\InitAllSettings.xaml", new Dictionary<string, object>{{"in_OrchestratorFolders", in_OrchestratorFolders}, {"in_RetrieveCredentials", in_RetrieveCredentials}}, default, default, default, GetAssemblyName());
            return (System.Collections.Generic.Dictionary<string, System.Management.Automation.PSCredential>)result["out_Credentials"];
        }

        /// <summary>
        /// Invokes the Framework/InitAllSettings.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public System.Collections.Generic.Dictionary<string, System.Management.Automation.PSCredential> InitAllSettings(string in_OrchestratorFolders, bool in_RetrieveCredentials, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\InitAllSettings.xaml", new Dictionary<string, object>{{"in_OrchestratorFolders", in_OrchestratorFolders}, {"in_RetrieveCredentials", in_RetrieveCredentials}}, default, isolated, default, GetAssemblyName());
            return (System.Collections.Generic.Dictionary<string, System.Management.Automation.PSCredential>)result["out_Credentials"];
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/blue part 2/IPAFFS Data Submission.xaml
        /// </summary>
        public System.Data.DataTable IPAFFS_Data_Submission(System.Data.DataTable in_dtAD_Compliant, System.Data.DataTable io_dtOnHoldReasons)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\blue part 2\IPAFFS Data Submission.xaml", new Dictionary<string, object>{{"in_dtAD_Compliant", in_dtAD_Compliant}, {"io_dtOnHoldReasons", io_dtOnHoldReasons}}, default, default, default, GetAssemblyName());
            return (System.Data.DataTable)result["io_dtOnHoldReasons"];
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/blue part 2/IPAFFS Data Submission.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public System.Data.DataTable IPAFFS_Data_Submission(System.Data.DataTable in_dtAD_Compliant, System.Data.DataTable io_dtOnHoldReasons, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\blue part 2\IPAFFS Data Submission.xaml", new Dictionary<string, object>{{"in_dtAD_Compliant", in_dtAD_Compliant}, {"io_dtOnHoldReasons", io_dtOnHoldReasons}}, default, isolated, default, GetAssemblyName());
            return (System.Data.DataTable)result["io_dtOnHoldReasons"];
        }

        /// <summary>
        /// Invokes the GlobalExceptionHandler.xaml
        /// </summary>
        public UiPath.Activities.Contracts.ErrorAction GlobalExceptionHandler(UiPath.Activities.Contracts.ExceptionHandlerArgs errorInfo)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"GlobalExceptionHandler.xaml", new Dictionary<string, object>{{"errorInfo", errorInfo}}, default, default, default, GetAssemblyName());
            return (UiPath.Activities.Contracts.ErrorAction)result["result"];
        }

        /// <summary>
        /// Invokes the GlobalExceptionHandler.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public UiPath.Activities.Contracts.ErrorAction GlobalExceptionHandler(UiPath.Activities.Contracts.ExceptionHandlerArgs errorInfo, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"GlobalExceptionHandler.xaml", new Dictionary<string, object>{{"errorInfo", errorInfo}}, default, isolated, default, GetAssemblyName());
            return (UiPath.Activities.Contracts.ErrorAction)result["result"];
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/AD/TestCase.xaml
        /// </summary>
        public void TestCase()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\AD\TestCase.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/AD/TestCase.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void TestCase(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\AD\TestCase.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/TestCase_ExtractInformation.xaml
        /// </summary>
        public void TestCase_ExtractInformation()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\TestCase_ExtractInformation.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/TestCase_ExtractInformation.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void TestCase_ExtractInformation(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\TestCase_ExtractInformation.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/AD/TestCase - DataVerse.xaml
        /// </summary>
        public void TestCase___DataVerse()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\AD\TestCase - DataVerse.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/AD/TestCase - DataVerse.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void TestCase___DataVerse(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\AD\TestCase - DataVerse.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/TestCase_CompareIPAFFSInformation.xaml
        /// </summary>
        public void TestCase_CompareIPAFFSInformation()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\TestCase_CompareIPAFFSInformation.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/TestCase_CompareIPAFFSInformation.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void TestCase_CompareIPAFFSInformation(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\TestCase_CompareIPAFFSInformation.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/AD/Regulation Search.xaml
        /// </summary>
        public System.Data.DataTable Regulation_Search(string in_strGenus, string in_strCountryName)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\AD\Regulation Search.xaml", new Dictionary<string, object>{{"in_strGenus", in_strGenus}, {"in_strCountryName", in_strCountryName}}, default, default, default, GetAssemblyName());
            return (System.Data.DataTable)result["out_dtMatchedItems"];
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/AD/Regulation Search.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public System.Data.DataTable Regulation_Search(string in_strGenus, string in_strCountryName, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\AD\Regulation Search.xaml", new Dictionary<string, object>{{"in_strGenus", in_strGenus}, {"in_strCountryName", in_strCountryName}}, default, isolated, default, GetAssemblyName());
            return (System.Data.DataTable)result["out_dtMatchedItems"];
        }

        /// <summary>
        /// Invokes the Framework/NetworkConnectivityTool.xaml
        /// </summary>
        public void NetworkConnectivityTool()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\NetworkConnectivityTool.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/NetworkConnectivityTool.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void NetworkConnectivityTool(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\NetworkConnectivityTool.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/AD/Open Compliance Form.xaml
        /// </summary>
        public System.Data.DataTable Open_Compliance_Form(string in_strComplianceFormFilePath, System.Data.DataTable io_dtCommodityLines)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\AD\Open Compliance Form.xaml", new Dictionary<string, object>{{"in_strComplianceFormFilePath", in_strComplianceFormFilePath}, {"io_dtCommodityLines", io_dtCommodityLines}}, default, default, default, GetAssemblyName());
            return (System.Data.DataTable)result["io_dtCommodityLines"];
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/AD/Open Compliance Form.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public System.Data.DataTable Open_Compliance_Form(string in_strComplianceFormFilePath, System.Data.DataTable io_dtCommodityLines, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\AD\Open Compliance Form.xaml", new Dictionary<string, object>{{"in_strComplianceFormFilePath", in_strComplianceFormFilePath}, {"io_dtCommodityLines", io_dtCommodityLines}}, default, isolated, default, GetAssemblyName());
            return (System.Data.DataTable)result["io_dtCommodityLines"];
        }

        /// <summary>
        /// Invokes the Framework/KillAllProcesses.xaml
        /// </summary>
        public void KillAllProcesses()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\KillAllProcesses.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/KillAllProcesses.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void KillAllProcesses(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\KillAllProcesses.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/AD/Extract Phyto Text - archive.xaml
        /// </summary>
        public void Extract_Phyto_Text___archive(string in_strCountryOfOrigin, string in_strSec8Plants, string in_strSec11AD)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\AD\Extract Phyto Text - archive.xaml", new Dictionary<string, object>{{"in_strCountryOfOrigin", in_strCountryOfOrigin}, {"in_strSec8Plants", in_strSec8Plants}, {"in_strSec11AD", in_strSec11AD}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/AD/Extract Phyto Text - archive.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Extract_Phyto_Text___archive(string in_strCountryOfOrigin, string in_strSec8Plants, string in_strSec11AD, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\AD\Extract Phyto Text - archive.xaml", new Dictionary<string, object>{{"in_strCountryOfOrigin", in_strCountryOfOrigin}, {"in_strSec8Plants", in_strSec8Plants}, {"in_strSec11AD", in_strSec11AD}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/CloseAllApplications.xaml
        /// </summary>
        public void CloseAllApplications()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\CloseAllApplications.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/CloseAllApplications.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void CloseAllApplications(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\CloseAllApplications.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/AD/Review ADs.xaml
        /// </summary>
        public System.Data.DataTable Review_ADs(string in_strSec11AD, string in_strPDF_Filepath, System.Data.DataTable io_dtCommodityLines)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\AD\Review ADs.xaml", new Dictionary<string, object>{{"in_strSec11AD", in_strSec11AD}, {"in_strPDF_Filepath", in_strPDF_Filepath}, {"io_dtCommodityLines", io_dtCommodityLines}}, default, default, default, GetAssemblyName());
            return (System.Data.DataTable)result["io_dtCommodityLines"];
        }

        /// <summary>
        /// Invokes the Process/Process Subflows/AD/Review ADs.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public System.Data.DataTable Review_ADs(string in_strSec11AD, string in_strPDF_Filepath, System.Data.DataTable io_dtCommodityLines, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process\Process Subflows\AD\Review ADs.xaml", new Dictionary<string, object>{{"in_strSec11AD", in_strSec11AD}, {"in_strPDF_Filepath", in_strPDF_Filepath}, {"io_dtCommodityLines", io_dtCommodityLines}}, default, isolated, default, GetAssemblyName());
            return (System.Data.DataTable)result["io_dtCommodityLines"];
        }

        /// <summary>
        /// Invokes the Framework/InitAllApplications.xaml
        /// </summary>
        public void InitAllApplications()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\InitAllApplications.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/InitAllApplications.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void InitAllApplications(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\InitAllApplications.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        private string GetAssemblyName()
        {
            var assemblyProvider = _services.Container.Resolve<ILibraryAssemblyProvider>();
            return assemblyProvider.GetLibraryAssemblyName(GetType().Assembly);
        }
    }
}