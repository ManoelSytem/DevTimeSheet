namespace TimeSheet.Domain.Proxy
{

    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ws.workflow.ecm.technology.totvs.com/")]
    public partial class Exception
    {

        private string messageField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ws.workflow.ecm.technology.totvs.com/")]
    public partial class attachment
    {

        private bool attachField;

        private bool attachFieldSpecified;

        private bool descriptorField;

        private bool descriptorFieldSpecified;

        private bool editingField;

        private bool editingFieldSpecified;

        private string fileNameField;

        private attachment fileSelectedField;

        private long fileSizeField;

        private byte[] filecontentField;

        private string fullPatchField;

        private string iconPathField;

        private bool mobileField;

        private bool mobileFieldSpecified;

        private string pathNameField;

        private bool principalField;

        private bool principalFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public bool attach
        {
            get
            {
                return this.attachField;
            }
            set
            {
                this.attachField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool attachSpecified
        {
            get
            {
                return this.attachFieldSpecified;
            }
            set
            {
                this.attachFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public bool descriptor
        {
            get
            {
                return this.descriptorField;
            }
            set
            {
                this.descriptorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool descriptorSpecified
        {
            get
            {
                return this.descriptorFieldSpecified;
            }
            set
            {
                this.descriptorFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public bool editing
        {
            get
            {
                return this.editingField;
            }
            set
            {
                this.editingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool editingSpecified
        {
            get
            {
                return this.editingFieldSpecified;
            }
            set
            {
                this.editingFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public string fileName
        {
            get
            {
                return this.fileNameField;
            }
            set
            {
                this.fileNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public attachment fileSelected
        {
            get
            {
                return this.fileSelectedField;
            }
            set
            {
                this.fileSelectedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public long fileSize
        {
            get
            {
                return this.fileSizeField;
            }
            set
            {
                this.fileSizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "base64Binary", Order = 6)]
        public byte[] filecontent
        {
            get
            {
                return this.filecontentField;
            }
            set
            {
                this.filecontentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
        public string fullPatch
        {
            get
            {
                return this.fullPatchField;
            }
            set
            {
                this.fullPatchField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 8)]
        public string iconPath
        {
            get
            {
                return this.iconPathField;
            }
            set
            {
                this.iconPathField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 9)]
        public bool mobile
        {
            get
            {
                return this.mobileField;
            }
            set
            {
                this.mobileField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool mobileSpecified
        {
            get
            {
                return this.mobileFieldSpecified;
            }
            set
            {
                this.mobileFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 10)]
        public string pathName
        {
            get
            {
                return this.pathNameField;
            }
            set
            {
                this.pathNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 11)]
        public bool principal
        {
            get
            {
                return this.principalField;
            }
            set
            {
                this.principalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool principalSpecified
        {
            get
            {
                return this.principalFieldSpecified;
            }
            set
            {
                this.principalFieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://ws.workflow.ecm.technology.totvs.com/", ConfigurationName = "WorkflowEngineService")]
    public interface WorkflowEngineService
    {

        [System.ServiceModel.OperationContractAttribute(Action = "importProcess", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exception), Action = "importProcess", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<importProcessResponse> importProcessAsync(importProcess request);

        [System.ServiceModel.OperationContractAttribute(Action = "setDueDate", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exception), Action = "setDueDate", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults = true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "result")]
        System.Threading.Tasks.Task<string> setDueDateAsync(string username, string password, int companyId, int processInstanceId, string userId, int threadSequence, string newDueDate, int timeInSecods);

        [System.ServiceModel.OperationContractAttribute(Action = "takeProcessTask", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exception), Action = "takeProcessTask", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults = true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "result")]
        System.Threading.Tasks.Task<string> takeProcessTaskAsync(string username, string password, int companyId, string userId, int processInstanceId, int threadSequence);

        [System.ServiceModel.OperationContractAttribute(Action = "getInstanceCardData", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exception), Action = "getInstanceCardData", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<getInstanceCardDataResponse> getInstanceCardDataAsync(getInstanceCardData request);

        [System.ServiceModel.OperationContractAttribute(Action = "createWorkFlowProcessVersion", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exception), Action = "createWorkFlowProcessVersion", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults = true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "result")]
        System.Threading.Tasks.Task<string> createWorkFlowProcessVersionAsync(string username, string password, int companyId, string processId);

        [System.ServiceModel.OperationContractAttribute(Action = "getCardValue", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exception), Action = "getCardValue", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults = true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "content")]
        System.Threading.Tasks.Task<string> getCardValueAsync(string username, string password, int companyId, int processInstanceId, string userId, string cardFieldName);

        [System.ServiceModel.OperationContractAttribute(Action = "getAllProcessAvailableToExport", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exception), Action = "getAllProcessAvailableToExport", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<getAllProcessAvailableToExportResponse> getAllProcessAvailableToExportAsync(getAllProcessAvailableToExport request);

        [System.ServiceModel.OperationContractAttribute(Action = "saveAndSendTask", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exception), Action = "saveAndSendTask", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<saveAndSendTaskResponse> saveAndSendTaskAsync(saveAndSendTask request);

        [System.ServiceModel.OperationContractAttribute(Action = "setAutomaticDecisionClassic", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exception), Action = "setAutomaticDecisionClassic", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<setAutomaticDecisionClassicResponse> setAutomaticDecisionClassicAsync(setAutomaticDecisionClassic request);

        [System.ServiceModel.OperationContractAttribute(Action = "importProcessWithCardAndRelatedDatasets", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exception), Action = "importProcessWithCardAndRelatedDatasets", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<importProcessWithCardAndRelatedDatasetsResponse> importProcessWithCardAndRelatedDatasetsAsync(importProcessWithCardAndRelatedDatasets request);

        [System.ServiceModel.OperationContractAttribute(Action = "calculeDeadLineHours", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exception), Action = "calculeDeadLineHours", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults = true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "result")]
        System.Threading.Tasks.Task<deadLineDto> calculateDeadLineHoursAsync(string username, string password, int companyId, string userId, string data, int hora, int prazo, string periodId);

        [System.ServiceModel.OperationContractAttribute(Action = "getAllProcessAvailableToImport", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exception), Action = "getAllProcessAvailableToImport", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<getAllProcessAvailableToImportResponse> getAllProcessAvailableToImportAsync(getAllProcessAvailableToImport request);

        [System.ServiceModel.OperationContractAttribute(Action = "cancelInstance", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exception), Action = "cancelInstance", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults = true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "result")]
        System.Threading.Tasks.Task<string> cancelInstanceAsync(string username, string password, int companyId, int processInstanceId, string userId, string cancelText);

        [System.ServiceModel.OperationContractAttribute(Action = "getActualThread", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exception), Action = "getActualThread", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults = true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "ActualThread")]
        System.Threading.Tasks.Task<int> getActualThreadAsync(string username, string password, int companyId, int processInstanceId, int stateSequence);

        [System.ServiceModel.OperationContractAttribute(Action = "getWorkFlowProcessVersion", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exception), Action = "getWorkFlowProcessVersion", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults = true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "result")]
        System.Threading.Tasks.Task<int> getWorkFlowProcessVersionAsync(string username, string password, int companyId, string processId);

        [System.ServiceModel.OperationContractAttribute(Action = "getAvailableProcessOnDemand", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exception), Action = "getAvailableProcessOnDemand", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<getAvailableProcessOnDemandResponse> getAvailableProcessOnDemandAsync(getAvailableProcessOnDemand request);

        [System.ServiceModel.OperationContractAttribute(Action = "getAvailableStatesDetail", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exception), Action = "getAvailableStatesDetail", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<getAvailableStatesDetailResponse> getAvailableStatesDetailAsync(getAvailableStatesDetail request);

        [System.ServiceModel.OperationContractAttribute(Action = "exportProcess", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exception), Action = "exportProcess", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<exportProcessInZipFormatResponse> exportProcessInZipFormatAsync(exportProcessInZipFormat request);

        [System.ServiceModel.OperationContractAttribute(Action = "importProcessWithCard", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exception), Action = "importProcessWithCard", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<importProcessWithCardResponse> importProcessWithCardAsync(importProcessWithCard request);

        [System.ServiceModel.OperationContractAttribute(Action = "saveAndSendTaskByReplacement", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exception), Action = "saveAndSendTaskByReplacement", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<saveAndSendTaskByReplacementResponse> saveAndSendTaskByReplacementAsync(saveAndSendTaskByReplacement request);

        [System.ServiceModel.OperationContractAttribute(Action = "startProcessClassic", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exception), Action = "startProcessClassic", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<startProcessClassicResponse> startProcessClassicAsync(startProcessClassic request);

        [System.ServiceModel.OperationContractAttribute(Action = "cancelInstanceByReplacement", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exception), Action = "cancelInstanceByReplacement", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults = true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "result")]
        System.Threading.Tasks.Task<string> cancelInstanceByReplacementAsync(string username, string password, int companyId, int processInstanceId, string userId, string cancelText, string replacementId);

        [System.ServiceModel.OperationContractAttribute(Action = "calculeDeadLineTime", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exception), Action = "calculeDeadLineTime", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults = true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "result")]
        System.Threading.Tasks.Task<deadLineDto> calculateDeadLineTimeAsync(string username, string password, int companyId, string userId, string data, int hora, int prazo, string periodId);

        [System.ServiceModel.OperationContractAttribute(Action = "simpleStartProcess", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exception), Action = "simpleStartProcess", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<simpleStartProcessResponse> simpleStartProcessAsync(simpleStartProcess request);

        [System.ServiceModel.OperationContractAttribute(Action = "getAvailableProcess", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exception), Action = "getAvailableProcess", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<getAvailableProcessResponse> getAvailableProcessAsync(getAvailableProcess request);

        [System.ServiceModel.OperationContractAttribute(Action = "startProcess", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exception), Action = "startProcess", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<startProcessResponse> startProcessAsync(startProcess request);

        [System.ServiceModel.OperationContractAttribute(Action = "getAllActiveStates", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exception), Action = "getAllActiveStates", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<getAllActiveStatesResponse> getAllActiveStatesAsync(getAllActiveStates request);

        [System.ServiceModel.OperationContractAttribute(Action = "relaseProcess", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exception), Action = "relaseProcess", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults = true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "result")]
        System.Threading.Tasks.Task<string> releaseProcessAsync(string username, string password, int companyId, string processId);

        [System.ServiceModel.OperationContractAttribute(Action = "setTasksComments", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exception), Action = "setTasksComments", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults = true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "result")]
        System.Threading.Tasks.Task<string> setTasksCommentsAsync(string username, string password, int companyId, int processInstanceId, string userId, int threadSequence, string comments);

        [System.ServiceModel.OperationContractAttribute(Action = "searchProcess", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exception), Action = "searchProcess", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<searchProcessResponse> searchProcessAsync(searchProcess request);

        [System.ServiceModel.OperationContractAttribute(Action = "getAvailableUsersOnDemand", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exception), Action = "getAvailableUsersOnDemand", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults = true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "AvailableUsers")]
        System.Threading.Tasks.Task<availableUsersDto> getAvailableUsersOnDemandAsync(string username, string password, int companyId, int processInstanceId, int state, int threadSequence, int limit, int initialUser, string userSearch);

        [System.ServiceModel.OperationContractAttribute(Action = "getProcessFormId", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exception), Action = "getProcessFormId", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults = true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "result")]
        System.Threading.Tasks.Task<int> getProcessFormIdAsync(string username, string password, int companyId, string processId);

        [System.ServiceModel.OperationContractAttribute(Action = "saveAndSendTaskClassic", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exception), Action = "saveAndSendTaskClassic", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<saveAndSendTaskClassicResponse> saveAndSendTaskClassicAsync(saveAndSendTaskClassic request);

        [System.ServiceModel.OperationContractAttribute(Action = "getAvailableUsersStartOnDemand", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exception), Action = "getAvailableUsersStartOnDemand", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults = true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "AvailableUsers")]
        System.Threading.Tasks.Task<availableUsersDto> getAvailableUsersStartOnDemandAsync(string username, string password, int companyId, string processId, int state, int threadSequence, int limit, int initialUser, string userSearch);

        [System.ServiceModel.OperationContractAttribute(Action = "getAvailableUsers", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exception), Action = "getAvailableUsers", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<getAvailableUsersResponse> getAvailableUsersAsync(getAvailableUsers request);

        [System.ServiceModel.OperationContractAttribute(Action = "getProcessImage", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exception), Action = "getProcessImage", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults = true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "Image")]
        System.Threading.Tasks.Task<string> getProcessImageAsync(string username, string password, int companyId, string userId, string processId);

        [System.ServiceModel.OperationContractAttribute(Action = "getAttachments", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exception), Action = "getAttachments", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<getAttachmentsResponse> getAttachmentsAsync(getAttachments request);

        [System.ServiceModel.OperationContractAttribute(Action = "importProcessWithCardAndPersistenceType", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exception), Action = "importProcessWithCardAndPersistenceType", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<importProcessWithCardAndPersistenceTypeResponse> importProcessWithCardAndPersistenceTypeAsync(importProcessWithCardAndPersistenceType request);

        [System.ServiceModel.OperationContractAttribute(Action = "getAvailableUsersStart", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exception), Action = "getAvailableUsersStart", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<getAvailableUsersStartResponse> getAvailableUsersStartAsync(getAvailableUsersStart request);

        [System.ServiceModel.OperationContractAttribute(Action = "importProcessWithCardAndGeneralInfo", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exception), Action = "importProcessWithCardAndGeneralInfo", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<importProcessWithCardAndGeneralInfoResponse> importProcessWithCardAndGeneralInfoAsync(importProcessWithCardAndGeneralInfo request);

        [System.ServiceModel.OperationContractAttribute(Action = "takeProcessTaskByReplacement", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exception), Action = "takeProcessTaskByReplacement", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults = true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "result")]
        System.Threading.Tasks.Task<string> takeProcessTaskByReplacementAsync(string username, string password, int companyId, string userId, int processInstanceId, int threadSequence, string replacementId);

        [System.ServiceModel.OperationContractAttribute(Action = "exportProcess", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exception), Action = "exportProcess", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults = true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "result")]
        System.Threading.Tasks.Task<string> exportProcessAsync(string username, string password, int companyId, string processId);

        [System.ServiceModel.OperationContractAttribute(Action = "getAvailbleStates", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exception), Action = "getAvailbleStates", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<getAvailableStatesResponse> getAvailableStatesAsync(getAvailableStates request);

        [System.ServiceModel.OperationContractAttribute(Action = "updateWorkflowAttachment", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exception), Action = "updateWorkflowAttachment", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<updateWorkflowAttachmentResponse> updateWorkflowAttachmentAsync(updateWorkflowAttachment request);

        [System.ServiceModel.OperationContractAttribute(Action = "getHistories", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Exception), Action = "getHistories", Name = "Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<getHistoriesResponse> getHistoriesAsync(getHistories request);
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "importProcess", WrapperNamespace = "http://ws.workflow.ecm.technology.totvs.com/", IsWrapped = true)]
    public partial class importProcess
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 0)]
        public string username;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 1)]
        public string password;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 2)]
        public int companyId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 3)]
        public string processId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "attachment[]", Order = 4)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public attachment[] attachments;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "bool", Order = 5)]
        public bool newProcess;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "bool", Order = 6)]
        public bool overWrite;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 7)]
        public string colleagueId;

        public importProcess()
        {
        }

        public importProcess(string username, string password, int companyId, string processId, attachment[] attachments, bool newProcess, bool overWrite, string colleagueId)
        {
            this.username = username;
            this.password = password;
            this.companyId = companyId;
            this.processId = processId;
            this.attachments = attachments;
            this.newProcess = newProcess;
            this.overWrite = overWrite;
            this.colleagueId = colleagueId;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "importProcessResponse", WrapperNamespace = "http://ws.workflow.ecm.technology.totvs.com/", IsWrapped = true)]
    public partial class importProcessResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 0)]
        public string result;

        public importProcessResponse()
        {
        }

        public importProcessResponse(string result)
        {
            this.result = result;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "getInstanceCardData", WrapperNamespace = "http://ws.workflow.ecm.technology.totvs.com/", IsWrapped = true)]
    public partial class getInstanceCardData
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 0)]
        public string username;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 1)]
        public string password;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 2)]
        public int companyId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 3)]
        public string userId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 4)]
        public int processInstanceId;

        public getInstanceCardData()
        {
        }

        public getInstanceCardData(string username, string password, int companyId, string userId, int processInstanceId)
        {
            this.username = username;
            this.password = password;
            this.companyId = companyId;
            this.userId = userId;
            this.processInstanceId = processInstanceId;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "getInstanceCardDataResponse", WrapperNamespace = "http://ws.workflow.ecm.technology.totvs.com/", IsWrapped = true)]
    public partial class getInstanceCardDataResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string[][]", Order = 0)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, NestingLevel = 1)]
        public string[][] CardData;

        public getInstanceCardDataResponse()
        {
        }

        public getInstanceCardDataResponse(string[][] CardData)
        {
            this.CardData = CardData;
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ws.workflow.ecm.technology.totvs.com/")]
    public partial class processDefinitionDto
    {

        private bool activeField;

        private bool activeFieldSpecified;

        private long companyIdField;

        private string processDescriptionField;

        private string processIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public bool active
        {
            get
            {
                return this.activeField;
            }
            set
            {
                this.activeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool activeSpecified
        {
            get
            {
                return this.activeFieldSpecified;
            }
            set
            {
                this.activeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public long companyId
        {
            get
            {
                return this.companyIdField;
            }
            set
            {
                this.companyIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string processDescription
        {
            get
            {
                return this.processDescriptionField;
            }
            set
            {
                this.processDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public string processId
        {
            get
            {
                return this.processIdField;
            }
            set
            {
                this.processIdField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "getAllProcessAvailableToExport", WrapperNamespace = "http://ws.workflow.ecm.technology.totvs.com/", IsWrapped = true)]
    public partial class getAllProcessAvailableToExport
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 0)]
        public string username;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 1)]
        public string password;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 2)]
        public int companyId;

        public getAllProcessAvailableToExport()
        {
        }

        public getAllProcessAvailableToExport(string username, string password, int companyId)
        {
            this.username = username;
            this.password = password;
            this.companyId = companyId;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "getAllProcessAvailableToExportResponse", WrapperNamespace = "http://ws.workflow.ecm.technology.totvs.com/", IsWrapped = true)]
    public partial class getAllProcessAvailableToExportResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "processDefinitionDto[]", Order = 0)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public processDefinitionDto[] result;

        public getAllProcessAvailableToExportResponse()
        {
        }

        public getAllProcessAvailableToExportResponse(processDefinitionDto[] result)
        {
            this.result = result;
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ws.workflow.ecm.technology.totvs.com/")]
    public partial class processAttachmentDto
    {

        private int attachmentSequenceField;

        private attachment[] attachmentsField;

        private string colleagueIdField;

        private string colleagueNameField;

        private long companyIdField;

        private long crcField;

        private bool crcFieldSpecified;

        private System.DateTime createDateField;

        private bool createDateFieldSpecified;

        private long createDateTimestampField;

        private bool createDateTimestampFieldSpecified;

        private bool deletedField;

        private bool deletedFieldSpecified;

        private string descriptionField;

        private int documentIdField;

        private bool documentIdFieldSpecified;

        private string documentTypeField;

        private string fileNameField;

        private bool newAttachField;

        private bool newAttachFieldSpecified;

        private int originalMovementSequenceField;

        private bool originalMovementSequenceFieldSpecified;

        private string permissionField;

        private int processInstanceIdField;

        private float sizeField;

        private int versionField;

        private bool versionFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public int attachmentSequence
        {
            get
            {
                return this.attachmentSequenceField;
            }
            set
            {
                this.attachmentSequenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("attachments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public attachment[] attachments
        {
            get
            {
                return this.attachmentsField;
            }
            set
            {
                this.attachmentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string colleagueId
        {
            get
            {
                return this.colleagueIdField;
            }
            set
            {
                this.colleagueIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public string colleagueName
        {
            get
            {
                return this.colleagueNameField;
            }
            set
            {
                this.colleagueNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public long companyId
        {
            get
            {
                return this.companyIdField;
            }
            set
            {
                this.companyIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public long crc
        {
            get
            {
                return this.crcField;
            }
            set
            {
                this.crcField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool crcSpecified
        {
            get
            {
                return this.crcFieldSpecified;
            }
            set
            {
                this.crcFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
        public System.DateTime createDate
        {
            get
            {
                return this.createDateField;
            }
            set
            {
                this.createDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool createDateSpecified
        {
            get
            {
                return this.createDateFieldSpecified;
            }
            set
            {
                this.createDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
        public long createDateTimestamp
        {
            get
            {
                return this.createDateTimestampField;
            }
            set
            {
                this.createDateTimestampField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool createDateTimestampSpecified
        {
            get
            {
                return this.createDateTimestampFieldSpecified;
            }
            set
            {
                this.createDateTimestampFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 8)]
        public bool deleted
        {
            get
            {
                return this.deletedField;
            }
            set
            {
                this.deletedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool deletedSpecified
        {
            get
            {
                return this.deletedFieldSpecified;
            }
            set
            {
                this.deletedFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 9)]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 10)]
        public int documentId
        {
            get
            {
                return this.documentIdField;
            }
            set
            {
                this.documentIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool documentIdSpecified
        {
            get
            {
                return this.documentIdFieldSpecified;
            }
            set
            {
                this.documentIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 11)]
        public string documentType
        {
            get
            {
                return this.documentTypeField;
            }
            set
            {
                this.documentTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 12)]
        public string fileName
        {
            get
            {
                return this.fileNameField;
            }
            set
            {
                this.fileNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 13)]
        public bool newAttach
        {
            get
            {
                return this.newAttachField;
            }
            set
            {
                this.newAttachField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool newAttachSpecified
        {
            get
            {
                return this.newAttachFieldSpecified;
            }
            set
            {
                this.newAttachFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 14)]
        public int originalMovementSequence
        {
            get
            {
                return this.originalMovementSequenceField;
            }
            set
            {
                this.originalMovementSequenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool originalMovementSequenceSpecified
        {
            get
            {
                return this.originalMovementSequenceFieldSpecified;
            }
            set
            {
                this.originalMovementSequenceFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 15)]
        public string permission
        {
            get
            {
                return this.permissionField;
            }
            set
            {
                this.permissionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 16)]
        public int processInstanceId
        {
            get
            {
                return this.processInstanceIdField;
            }
            set
            {
                this.processInstanceIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 17)]
        public float size
        {
            get
            {
                return this.sizeField;
            }
            set
            {
                this.sizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 18)]
        public int version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool versionSpecified
        {
            get
            {
                return this.versionFieldSpecified;
            }
            set
            {
                this.versionFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ws.workflow.ecm.technology.totvs.com/")]
    public partial class processTaskAppointmentDto
    {

        private System.DateTime appointmentDateField;

        private bool appointmentDateFieldSpecified;

        private int appointmentSecondsField;

        private bool appointmentSecondsFieldSpecified;

        private int appointmentSequenceField;

        private string colleagueIdField;

        private string colleagueNameField;

        private long companyIdField;

        private bool isNewRecordField;

        private bool isNewRecordFieldSpecified;

        private int movementSequenceField;

        private int processInstanceIdField;

        private int transferenceSequenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public System.DateTime appointmentDate
        {
            get
            {
                return this.appointmentDateField;
            }
            set
            {
                this.appointmentDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool appointmentDateSpecified
        {
            get
            {
                return this.appointmentDateFieldSpecified;
            }
            set
            {
                this.appointmentDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public int appointmentSeconds
        {
            get
            {
                return this.appointmentSecondsField;
            }
            set
            {
                this.appointmentSecondsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool appointmentSecondsSpecified
        {
            get
            {
                return this.appointmentSecondsFieldSpecified;
            }
            set
            {
                this.appointmentSecondsFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public int appointmentSequence
        {
            get
            {
                return this.appointmentSequenceField;
            }
            set
            {
                this.appointmentSequenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public string colleagueId
        {
            get
            {
                return this.colleagueIdField;
            }
            set
            {
                this.colleagueIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public string colleagueName
        {
            get
            {
                return this.colleagueNameField;
            }
            set
            {
                this.colleagueNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public long companyId
        {
            get
            {
                return this.companyIdField;
            }
            set
            {
                this.companyIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
        public bool isNewRecord
        {
            get
            {
                return this.isNewRecordField;
            }
            set
            {
                this.isNewRecordField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isNewRecordSpecified
        {
            get
            {
                return this.isNewRecordFieldSpecified;
            }
            set
            {
                this.isNewRecordFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
        public int movementSequence
        {
            get
            {
                return this.movementSequenceField;
            }
            set
            {
                this.movementSequenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 8)]
        public int processInstanceId
        {
            get
            {
                return this.processInstanceIdField;
            }
            set
            {
                this.processInstanceIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 9)]
        public int transferenceSequence
        {
            get
            {
                return this.transferenceSequenceField;
            }
            set
            {
                this.transferenceSequenceField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "saveAndSendTask", WrapperNamespace = "http://ws.workflow.ecm.technology.totvs.com/", IsWrapped = true)]
    public partial class saveAndSendTask
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 0)]
        public string username;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 1)]
        public string password;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 2)]
        public int companyId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 3)]
        public int processInstanceId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 4)]
        public int choosedState;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string[]", Order = 5)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] colleagueIds;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 6)]
        public string comments;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 7)]
        public string userId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "bool", Order = 8)]
        public bool completeTask;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "processAttachmentDto[]", Order = 9)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public processAttachmentDto[] attachments;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string[][]", Order = 10)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, NestingLevel = 1)]
        public string[][] cardData;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "processTaskAppointmentDto[]", Order = 11)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public processTaskAppointmentDto[] appointment;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "bool", Order = 12)]
        public bool managerMode;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 13)]
        public int threadSequence;

        public saveAndSendTask()
        {
        }

        public saveAndSendTask(string username, string password, int companyId, int processInstanceId, int choosedState, string[] colleagueIds, string comments, string userId, bool completeTask, processAttachmentDto[] attachments, string[][] cardData, processTaskAppointmentDto[] appointment, bool managerMode, int threadSequence)
        {
            this.username = username;
            this.password = password;
            this.companyId = companyId;
            this.processInstanceId = processInstanceId;
            this.choosedState = choosedState;
            this.colleagueIds = colleagueIds;
            this.comments = comments;
            this.userId = userId;
            this.completeTask = completeTask;
            this.attachments = attachments;
            this.cardData = cardData;
            this.appointment = appointment;
            this.managerMode = managerMode;
            this.threadSequence = threadSequence;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "saveAndSendTaskResponse", WrapperNamespace = "http://ws.workflow.ecm.technology.totvs.com/", IsWrapped = true)]
    public partial class saveAndSendTaskResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string[][]", Order = 0)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, NestingLevel = 1)]
        public string[][] result;

        public saveAndSendTaskResponse()
        {
        }

        public saveAndSendTaskResponse(string[][] result)
        {
            this.result = result;
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ws.workflow.ecm.technology.totvs.com/")]
    public partial class keyValueDto
    {

        private string keyField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "setAutomaticDecisionClassic", WrapperNamespace = "http://ws.workflow.ecm.technology.totvs.com/", IsWrapped = true)]
    public partial class setAutomaticDecisionClassic
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 0)]
        public string username;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 1)]
        public string password;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 2)]
        public int companyId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 3)]
        public int processInstanceId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 4)]
        public int iTaskAutom;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 5)]
        public int iTask;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 6)]
        public int condition;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string[]", Order = 7)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] colleagueIds;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 8)]
        public string comments;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 9)]
        public string userId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "bool", Order = 10)]
        public bool managerMode;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 11)]
        public int threadSequence;

        public setAutomaticDecisionClassic()
        {
        }

        public setAutomaticDecisionClassic(string username, string password, int companyId, int processInstanceId, int iTaskAutom, int iTask, int condition, string[] colleagueIds, string comments, string userId, bool managerMode, int threadSequence)
        {
            this.username = username;
            this.password = password;
            this.companyId = companyId;
            this.processInstanceId = processInstanceId;
            this.iTaskAutom = iTaskAutom;
            this.iTask = iTask;
            this.condition = condition;
            this.colleagueIds = colleagueIds;
            this.comments = comments;
            this.userId = userId;
            this.managerMode = managerMode;
            this.threadSequence = threadSequence;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "setAutomaticDecisionClassicResponse", WrapperNamespace = "http://ws.workflow.ecm.technology.totvs.com/", IsWrapped = true)]
    public partial class setAutomaticDecisionClassicResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "keyValueDto[]", Order = 0)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public keyValueDto[] result;

        public setAutomaticDecisionClassicResponse()
        {
        }

        public setAutomaticDecisionClassicResponse(keyValueDto[] result)
        {
            this.result = result;
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ws.workflow.ecm.technology.totvs.com/")]
    public partial class cardEventDto
    {

        private string eventDescriptionField;

        private string eventIdField;

        private bool eventVersAntField;

        private bool eventVersAntFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string eventDescription
        {
            get
            {
                return this.eventDescriptionField;
            }
            set
            {
                this.eventDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string eventId
        {
            get
            {
                return this.eventIdField;
            }
            set
            {
                this.eventIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public bool eventVersAnt
        {
            get
            {
                return this.eventVersAntField;
            }
            set
            {
                this.eventVersAntField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool eventVersAntSpecified
        {
            get
            {
                return this.eventVersAntFieldSpecified;
            }
            set
            {
                this.eventVersAntFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ws.workflow.ecm.technology.totvs.com/")]
    public partial class generalInfoDto
    {

        private string versionOptionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string versionOption
        {
            get
            {
                return this.versionOptionField;
            }
            set
            {
                this.versionOptionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ws.workflow.ecm.technology.totvs.com/")]
    public partial class webServiceMessage
    {

        private long companyIdField;

        private string documentDescriptionField;

        private int documentIdField;

        private string[] fooField;

        private int versionField;

        private string webServiceMessage1Field;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public long companyId
        {
            get
            {
                return this.companyIdField;
            }
            set
            {
                this.companyIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string documentDescription
        {
            get
            {
                return this.documentDescriptionField;
            }
            set
            {
                this.documentDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public int documentId
        {
            get
            {
                return this.documentIdField;
            }
            set
            {
                this.documentIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("foo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public string[] foo
        {
            get
            {
                return this.fooField;
            }
            set
            {
                this.fooField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public int version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("webServiceMessage", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public string webServiceMessage1
        {
            get
            {
                return this.webServiceMessage1Field;
            }
            set
            {
                this.webServiceMessage1Field = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "importProcessWithCardAndRelatedDatasets", WrapperNamespace = "http://ws.workflow.ecm.technology.totvs.com/", IsWrapped = true)]
    public partial class importProcessWithCardAndRelatedDatasets
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 0)]
        public string username;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 1)]
        public string password;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 2)]
        public int companyId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 3)]
        public string processId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "attachment[]", Order = 4)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public attachment[] processAttachs;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "bool", Order = 5)]
        public bool newProcess;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "bool", Order = 6)]
        public bool overWrite;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 7)]
        public string colleagueId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 8)]
        public int parentDocumentId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 9)]
        public string documentDescription;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 10)]
        public string cardDescription;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 11)]
        public string datasetName;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "attachment[]", Order = 12)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public attachment[] cardAttachs;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "cardEventDto[]", Order = 13)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public cardEventDto[] customEvents;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "generalInfoDto", Order = 14)]
        public generalInfoDto generalInfo;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "bool", Order = 15)]
        public bool update;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 16)]
        public int persistenceType;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string[]", Order = 17)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] relatedDatasets;

        public importProcessWithCardAndRelatedDatasets()
        {
        }

        public importProcessWithCardAndRelatedDatasets(
                    string username,
                    string password,
                    int companyId,
                    string processId,
                    attachment[] processAttachs,
                    bool newProcess,
                    bool overWrite,
                    string colleagueId,
                    int parentDocumentId,
                    string documentDescription,
                    string cardDescription,
                    string datasetName,
                    attachment[] cardAttachs,
                    cardEventDto[] customEvents,
                    generalInfoDto generalInfo,
                    bool update,
                    int persistenceType,
                    string[] relatedDatasets)
        {
            this.username = username;
            this.password = password;
            this.companyId = companyId;
            this.processId = processId;
            this.processAttachs = processAttachs;
            this.newProcess = newProcess;
            this.overWrite = overWrite;
            this.colleagueId = colleagueId;
            this.parentDocumentId = parentDocumentId;
            this.documentDescription = documentDescription;
            this.cardDescription = cardDescription;
            this.datasetName = datasetName;
            this.cardAttachs = cardAttachs;
            this.customEvents = customEvents;
            this.generalInfo = generalInfo;
            this.update = update;
            this.persistenceType = persistenceType;
            this.relatedDatasets = relatedDatasets;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "importProcessWithCardAndRelatedDatasetsResponse", WrapperNamespace = "http://ws.workflow.ecm.technology.totvs.com/", IsWrapped = true)]
    public partial class importProcessWithCardAndRelatedDatasetsResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "webServiceMessage", Order = 0)]
        public webServiceMessage result;

        public importProcessWithCardAndRelatedDatasetsResponse()
        {
        }

        public importProcessWithCardAndRelatedDatasetsResponse(webServiceMessage result)
        {
            this.result = result;
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ws.workflow.ecm.technology.totvs.com/")]
    public partial class deadLineDto
    {

        private string dateField;

        private int horaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public int hora
        {
            get
            {
                return this.horaField;
            }
            set
            {
                this.horaField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "getAllProcessAvailableToImport", WrapperNamespace = "http://ws.workflow.ecm.technology.totvs.com/", IsWrapped = true)]
    public partial class getAllProcessAvailableToImport
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 0)]
        public string username;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 1)]
        public string password;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 2)]
        public int companyId;

        public getAllProcessAvailableToImport()
        {
        }

        public getAllProcessAvailableToImport(string username, string password, int companyId)
        {
            this.username = username;
            this.password = password;
            this.companyId = companyId;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "getAllProcessAvailableToImportResponse", WrapperNamespace = "http://ws.workflow.ecm.technology.totvs.com/", IsWrapped = true)]
    public partial class getAllProcessAvailableToImportResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "processDefinitionDto[]", Order = 0)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public processDefinitionDto[] result;

        public getAllProcessAvailableToImportResponse()
        {
        }

        public getAllProcessAvailableToImportResponse(processDefinitionDto[] result)
        {
            this.result = result;
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ws.workflow.ecm.technology.totvs.com/")]
    public partial class processDefinitionVersionDto
    {

        private string categoryStructureField;

        private long companyIdField;

        private bool counterSignField;

        private bool counterSignFieldSpecified;

        private bool favoriteField;

        private int formIdField;

        private bool formIdFieldSpecified;

        private int formVersionField;

        private bool formVersionFieldSpecified;

        private string fullCategoryStructureField;

        private processStateDto initialProcessStateField;

        private bool mobileReadyField;

        private string processDescriptionField;

        private string processIdField;

        private string[] relatedDatasetsField;

        private int rowIdField;

        private int versionField;

        private string versionDescriptionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string categoryStructure
        {
            get
            {
                return this.categoryStructureField;
            }
            set
            {
                this.categoryStructureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public long companyId
        {
            get
            {
                return this.companyIdField;
            }
            set
            {
                this.companyIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public bool counterSign
        {
            get
            {
                return this.counterSignField;
            }
            set
            {
                this.counterSignField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool counterSignSpecified
        {
            get
            {
                return this.counterSignFieldSpecified;
            }
            set
            {
                this.counterSignFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public bool favorite
        {
            get
            {
                return this.favoriteField;
            }
            set
            {
                this.favoriteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public int formId
        {
            get
            {
                return this.formIdField;
            }
            set
            {
                this.formIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool formIdSpecified
        {
            get
            {
                return this.formIdFieldSpecified;
            }
            set
            {
                this.formIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public int formVersion
        {
            get
            {
                return this.formVersionField;
            }
            set
            {
                this.formVersionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool formVersionSpecified
        {
            get
            {
                return this.formVersionFieldSpecified;
            }
            set
            {
                this.formVersionFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
        public string fullCategoryStructure
        {
            get
            {
                return this.fullCategoryStructureField;
            }
            set
            {
                this.fullCategoryStructureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
        public processStateDto initialProcessState
        {
            get
            {
                return this.initialProcessStateField;
            }
            set
            {
                this.initialProcessStateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 8)]
        public bool mobileReady
        {
            get
            {
                return this.mobileReadyField;
            }
            set
            {
                this.mobileReadyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 9)]
        public string processDescription
        {
            get
            {
                return this.processDescriptionField;
            }
            set
            {
                this.processDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 10)]
        public string processId
        {
            get
            {
                return this.processIdField;
            }
            set
            {
                this.processIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("relatedDatasets", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 11)]
        public string[] relatedDatasets
        {
            get
            {
                return this.relatedDatasetsField;
            }
            set
            {
                this.relatedDatasetsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 12)]
        public int rowId
        {
            get
            {
                return this.rowIdField;
            }
            set
            {
                this.rowIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 13)]
        public int version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 14)]
        public string versionDescription
        {
            get
            {
                return this.versionDescriptionField;
            }
            set
            {
                this.versionDescriptionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ws.workflow.ecm.technology.totvs.com/")]
    public partial class processStateDto
    {

        private long companyIdField;

        private bool counterSignField;

        private bool counterSignFieldSpecified;

        private int sequenceField;

        private string stateDescriptionField;

        private string stateNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public long companyId
        {
            get
            {
                return this.companyIdField;
            }
            set
            {
                this.companyIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public bool counterSign
        {
            get
            {
                return this.counterSignField;
            }
            set
            {
                this.counterSignField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool counterSignSpecified
        {
            get
            {
                return this.counterSignFieldSpecified;
            }
            set
            {
                this.counterSignFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public int sequence
        {
            get
            {
                return this.sequenceField;
            }
            set
            {
                this.sequenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public string stateDescription
        {
            get
            {
                return this.stateDescriptionField;
            }
            set
            {
                this.stateDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public string stateName
        {
            get
            {
                return this.stateNameField;
            }
            set
            {
                this.stateNameField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "getAvailableProcessOnDemand", WrapperNamespace = "http://ws.workflow.ecm.technology.totvs.com/", IsWrapped = true)]
    public partial class getAvailableProcessOnDemand
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 0)]
        public string username;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 1)]
        public string password;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 2)]
        public int companyId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 3)]
        public string userId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 4)]
        public int limit;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 5)]
        public int lastRowId;

        public getAvailableProcessOnDemand()
        {
        }

        public getAvailableProcessOnDemand(string username, string password, int companyId, string userId, int limit, int lastRowId)
        {
            this.username = username;
            this.password = password;
            this.companyId = companyId;
            this.userId = userId;
            this.limit = limit;
            this.lastRowId = lastRowId;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "getAvailableProcessOnDemandResponse", WrapperNamespace = "http://ws.workflow.ecm.technology.totvs.com/", IsWrapped = true)]
    public partial class getAvailableProcessOnDemandResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "processDefinitionVersionDto[]", Order = 0)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public processDefinitionVersionDto[] AvailableProcesses;

        public getAvailableProcessOnDemandResponse()
        {
        }

        public getAvailableProcessOnDemandResponse(processDefinitionVersionDto[] AvailableProcesses)
        {
            this.AvailableProcesses = AvailableProcesses;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "getAvailableStatesDetail", WrapperNamespace = "http://ws.workflow.ecm.technology.totvs.com/", IsWrapped = true)]
    public partial class getAvailableStatesDetail
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 0)]
        public string username;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 1)]
        public string password;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 2)]
        public int companyId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 3)]
        public string processId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 4)]
        public int processInstanceId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 5)]
        public int threadSequence;

        public getAvailableStatesDetail()
        {
        }

        public getAvailableStatesDetail(string username, string password, int companyId, string processId, int processInstanceId, int threadSequence)
        {
            this.username = username;
            this.password = password;
            this.companyId = companyId;
            this.processId = processId;
            this.processInstanceId = processInstanceId;
            this.threadSequence = threadSequence;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "getAvailableStatesDetailResponse", WrapperNamespace = "http://ws.workflow.ecm.technology.totvs.com/", IsWrapped = true)]
    public partial class getAvailableStatesDetailResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "processStateDto[]", Order = 0)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public processStateDto[] AvailableStatesDetail;

        public getAvailableStatesDetailResponse()
        {
        }

        public getAvailableStatesDetailResponse(processStateDto[] AvailableStatesDetail)
        {
            this.AvailableStatesDetail = AvailableStatesDetail;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "exportProcessInZipFormat", WrapperNamespace = "http://ws.workflow.ecm.technology.totvs.com/", IsWrapped = true)]
    public partial class exportProcessInZipFormat
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 0)]
        public string username;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 1)]
        public string password;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 2)]
        public int companyId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 3)]
        public string processId;

        public exportProcessInZipFormat()
        {
        }

        public exportProcessInZipFormat(string username, string password, int companyId, string processId)
        {
            this.username = username;
            this.password = password;
            this.companyId = companyId;
            this.processId = processId;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "exportProcessInZipFormatResponse", WrapperNamespace = "http://ws.workflow.ecm.technology.totvs.com/", IsWrapped = true)]
    public partial class exportProcessInZipFormatResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "byte[]", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[] result;

        public exportProcessInZipFormatResponse()
        {
        }

        public exportProcessInZipFormatResponse(byte[] result)
        {
            this.result = result;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "importProcessWithCard", WrapperNamespace = "http://ws.workflow.ecm.technology.totvs.com/", IsWrapped = true)]
    public partial class importProcessWithCard
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 0)]
        public string username;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 1)]
        public string password;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 2)]
        public int companyId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 3)]
        public string processId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "attachment[]", Order = 4)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public attachment[] processAttachs;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "bool", Order = 5)]
        public bool newProcess;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "bool", Order = 6)]
        public bool overWrite;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 7)]
        public string colleagueId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 8)]
        public int parentDocumentId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 9)]
        public string documentDescription;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 10)]
        public string cardDescription;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 11)]
        public string datasetName;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "attachment[]", Order = 12)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public attachment[] cardAttachs;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "cardEventDto[]", Order = 13)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public cardEventDto[] customEvents;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "bool", Order = 14)]
        public bool update;

        public importProcessWithCard()
        {
        }

        public importProcessWithCard(string username, string password, int companyId, string processId, attachment[] processAttachs, bool newProcess, bool overWrite, string colleagueId, int parentDocumentId, string documentDescription, string cardDescription, string datasetName, attachment[] cardAttachs, cardEventDto[] customEvents, bool update)
        {
            this.username = username;
            this.password = password;
            this.companyId = companyId;
            this.processId = processId;
            this.processAttachs = processAttachs;
            this.newProcess = newProcess;
            this.overWrite = overWrite;
            this.colleagueId = colleagueId;
            this.parentDocumentId = parentDocumentId;
            this.documentDescription = documentDescription;
            this.cardDescription = cardDescription;
            this.datasetName = datasetName;
            this.cardAttachs = cardAttachs;
            this.customEvents = customEvents;
            this.update = update;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "importProcessWithCardResponse", WrapperNamespace = "http://ws.workflow.ecm.technology.totvs.com/", IsWrapped = true)]
    public partial class importProcessWithCardResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "webServiceMessage", Order = 0)]
        public webServiceMessage result;

        public importProcessWithCardResponse()
        {
        }

        public importProcessWithCardResponse(webServiceMessage result)
        {
            this.result = result;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "saveAndSendTaskByReplacement", WrapperNamespace = "http://ws.workflow.ecm.technology.totvs.com/", IsWrapped = true)]
    public partial class saveAndSendTaskByReplacement
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 0)]
        public string username;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 1)]
        public string password;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 2)]
        public int companyId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 3)]
        public int processInstanceId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 4)]
        public int choosedState;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string[]", Order = 5)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] colleagueIds;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 6)]
        public string comments;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 7)]
        public string userId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "bool", Order = 8)]
        public bool completeTask;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "processAttachmentDto[]", Order = 9)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public processAttachmentDto[] attachments;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string[][]", Order = 10)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, NestingLevel = 1)]
        public string[][] cardData;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "processTaskAppointmentDto[]", Order = 11)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public processTaskAppointmentDto[] appointment;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "bool", Order = 12)]
        public bool managerMode;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 13)]
        public int threadSequence;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 14)]
        public string replacementId;

        public saveAndSendTaskByReplacement()
        {
        }

        public saveAndSendTaskByReplacement(string username, string password, int companyId, int processInstanceId, int choosedState, string[] colleagueIds, string comments, string userId, bool completeTask, processAttachmentDto[] attachments, string[][] cardData, processTaskAppointmentDto[] appointment, bool managerMode, int threadSequence, string replacementId)
        {
            this.username = username;
            this.password = password;
            this.companyId = companyId;
            this.processInstanceId = processInstanceId;
            this.choosedState = choosedState;
            this.colleagueIds = colleagueIds;
            this.comments = comments;
            this.userId = userId;
            this.completeTask = completeTask;
            this.attachments = attachments;
            this.cardData = cardData;
            this.appointment = appointment;
            this.managerMode = managerMode;
            this.threadSequence = threadSequence;
            this.replacementId = replacementId;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "saveAndSendTaskByReplacementResponse", WrapperNamespace = "http://ws.workflow.ecm.technology.totvs.com/", IsWrapped = true)]
    public partial class saveAndSendTaskByReplacementResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string[][]", Order = 0)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, NestingLevel = 1)]
        public string[][] result;

        public saveAndSendTaskByReplacementResponse()
        {
        }

        public saveAndSendTaskByReplacementResponse(string[][] result)
        {
            this.result = result;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "startProcessClassic", WrapperNamespace = "http://ws.workflow.ecm.technology.totvs.com/", IsWrapped = true)]
    public partial class startProcessClassic
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 0)]
        public string username;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 1)]
        public string password;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 2)]
        public int companyId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 3)]
        public string processId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 4)]
        public int choosedState;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string[]", Order = 5)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] colleagueIds;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 6)]
        public string comments;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 7)]
        public string userId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "bool", Order = 8)]
        public bool completeTask;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "processAttachmentDto[]", Order = 9)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public processAttachmentDto[] attachments;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "keyValueDto[]", Order = 10)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public keyValueDto[] cardData;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "processTaskAppointmentDto[]", Order = 11)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public processTaskAppointmentDto[] appointment;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "bool", Order = 12)]
        public bool managerMode;

        public startProcessClassic()
        {
        }

        public startProcessClassic(string username, string password, int companyId, string processId, int choosedState, string[] colleagueIds, string comments, string userId, bool completeTask, processAttachmentDto[] attachments, keyValueDto[] cardData, processTaskAppointmentDto[] appointment, bool managerMode)
        {
            this.username = username;
            this.password = password;
            this.companyId = companyId;
            this.processId = processId;
            this.choosedState = choosedState;
            this.colleagueIds = colleagueIds;
            this.comments = comments;
            this.userId = userId;
            this.completeTask = completeTask;
            this.attachments = attachments;
            this.cardData = cardData;
            this.appointment = appointment;
            this.managerMode = managerMode;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "startProcessClassicResponse", WrapperNamespace = "http://ws.workflow.ecm.technology.totvs.com/", IsWrapped = true)]
    public partial class startProcessClassicResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "keyValueDto[]", Order = 0)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public keyValueDto[] result;

        public startProcessClassicResponse()
        {
        }

        public startProcessClassicResponse(keyValueDto[] result)
        {
            this.result = result;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "simpleStartProcess", WrapperNamespace = "http://ws.workflow.ecm.technology.totvs.com/", IsWrapped = true)]
    public partial class simpleStartProcess
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 0)]
        public string username;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 1)]
        public string password;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 2)]
        public int companyId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 3)]
        public string processId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 4)]
        public string comments;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "processAttachmentDto[]", Order = 5)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public processAttachmentDto[] attachments;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string[][]", Order = 6)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, NestingLevel = 1)]
        public string[][] cardData;

        public simpleStartProcess()
        {
        }

        public simpleStartProcess(string username, string password, int companyId, string processId, string comments, processAttachmentDto[] attachments, string[][] cardData)
        {
            this.username = username;
            this.password = password;
            this.companyId = companyId;
            this.processId = processId;
            this.comments = comments;
            this.attachments = attachments;
            this.cardData = cardData;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "simpleStartProcessResponse", WrapperNamespace = "http://ws.workflow.ecm.technology.totvs.com/", IsWrapped = true)]
    public partial class simpleStartProcessResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string[]", Order = 0)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] result;

        public simpleStartProcessResponse()
        {
        }

        public simpleStartProcessResponse(string[] result)
        {
            this.result = result;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "getAvailableProcess", WrapperNamespace = "http://ws.workflow.ecm.technology.totvs.com/", IsWrapped = true)]
    public partial class getAvailableProcess
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 0)]
        public string username;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 1)]
        public string password;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 2)]
        public int companyId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 3)]
        public string userId;

        public getAvailableProcess()
        {
        }

        public getAvailableProcess(string username, string password, int companyId, string userId)
        {
            this.username = username;
            this.password = password;
            this.companyId = companyId;
            this.userId = userId;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "getAvailableProcessResponse", WrapperNamespace = "http://ws.workflow.ecm.technology.totvs.com/", IsWrapped = true)]
    public partial class getAvailableProcessResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "processDefinitionVersionDto[]", Order = 0)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public processDefinitionVersionDto[] AvailableProcesses;

        public getAvailableProcessResponse()
        {
        }

        public getAvailableProcessResponse(processDefinitionVersionDto[] AvailableProcesses)
        {
            this.AvailableProcesses = AvailableProcesses;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "startProcess", WrapperNamespace = "http://ws.workflow.ecm.technology.totvs.com/", IsWrapped = true)]
    public partial class startProcess
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 0)]
        public string username;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 1)]
        public string password;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 2)]
        public int companyId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 3)]
        public string processId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 4)]
        public int choosedState;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string[]", Order = 5)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] colleagueIds;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 6)]
        public string comments;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 7)]
        public string userId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "bool", Order = 8)]
        public bool completeTask;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "processAttachmentDto[]", Order = 9)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public processAttachmentDto[] attachments;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string[][]", Order = 10)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, NestingLevel = 1)]
        public string[][] cardData;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "processTaskAppointmentDto[]", Order = 11)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public processTaskAppointmentDto[] appointment;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "bool", Order = 12)]
        public bool managerMode;

        public startProcess()
        {
        }

        public startProcess(string username, string password, int companyId, string processId, int choosedState, string[] colleagueIds, string comments, string userId, bool completeTask, processAttachmentDto[] attachments, string[][] cardData, processTaskAppointmentDto[] appointment, bool managerMode)
        {
            this.username = username;
            this.password = password;
            this.companyId = companyId;
            this.processId = processId;
            this.choosedState = choosedState;
            this.colleagueIds = colleagueIds;
            this.comments = comments;
            this.userId = userId;
            this.completeTask = completeTask;
            this.attachments = attachments;
            this.cardData = cardData;
            this.appointment = appointment;
            this.managerMode = managerMode;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "startProcessResponse", WrapperNamespace = "http://ws.workflow.ecm.technology.totvs.com/", IsWrapped = true)]
    public partial class startProcessResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string[][]", Order = 0)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, NestingLevel = 1)]
        public string[][] result;

        public startProcessResponse()
        {
        }

        public startProcessResponse(string[][] result)
        {
            this.result = result;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "getAllActiveStates", WrapperNamespace = "http://ws.workflow.ecm.technology.totvs.com/", IsWrapped = true)]
    public partial class getAllActiveStates
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 0)]
        public string username;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 1)]
        public string password;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 2)]
        public int companyId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 3)]
        public string userId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 4)]
        public int processInstanceId;

        public getAllActiveStates()
        {
        }

        public getAllActiveStates(string username, string password, int companyId, string userId, int processInstanceId)
        {
            this.username = username;
            this.password = password;
            this.companyId = companyId;
            this.userId = userId;
            this.processInstanceId = processInstanceId;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "getAllActiveStatesResponse", WrapperNamespace = "http://ws.workflow.ecm.technology.totvs.com/", IsWrapped = true)]
    public partial class getAllActiveStatesResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "System.Nullable<int>[]", Order = 0)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.Nullable<int>[] States;

        public getAllActiveStatesResponse()
        {
        }

        public getAllActiveStatesResponse(System.Nullable<int>[] States)
        {
            this.States = States;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "searchProcess", WrapperNamespace = "http://ws.workflow.ecm.technology.totvs.com/", IsWrapped = true)]
    public partial class searchProcess
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 0)]
        public string username;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 1)]
        public string password;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 2)]
        public int companyId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 3)]
        public string colleagueId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 4)]
        public string content;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "bool", Order = 5)]
        public bool favorite;

        public searchProcess()
        {
        }

        public searchProcess(string username, string password, int companyId, string colleagueId, string content, bool favorite)
        {
            this.username = username;
            this.password = password;
            this.companyId = companyId;
            this.colleagueId = colleagueId;
            this.content = content;
            this.favorite = favorite;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "searchProcessResponse", WrapperNamespace = "http://ws.workflow.ecm.technology.totvs.com/", IsWrapped = true)]
    public partial class searchProcessResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "processDefinitionVersionDto[]", Order = 0)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public processDefinitionVersionDto[] searchResults;

        public searchProcessResponse()
        {
        }

        public searchProcessResponse(processDefinitionVersionDto[] searchResults)
        {
            this.searchResults = searchResults;
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ws.workflow.ecm.technology.totvs.com/")]
    public partial class availableUsersDto
    {

        private bool isCollectiveTaskField;

        private bool isCollectiveTaskFieldSpecified;

        private colleagueDto[] usersField;

        private bool willShowUsersField;

        private bool willShowUsersFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public bool isCollectiveTask
        {
            get
            {
                return this.isCollectiveTaskField;
            }
            set
            {
                this.isCollectiveTaskField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isCollectiveTaskSpecified
        {
            get
            {
                return this.isCollectiveTaskFieldSpecified;
            }
            set
            {
                this.isCollectiveTaskFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("users", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 1)]
        public colleagueDto[] users
        {
            get
            {
                return this.usersField;
            }
            set
            {
                this.usersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public bool willShowUsers
        {
            get
            {
                return this.willShowUsersField;
            }
            set
            {
                this.willShowUsersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool willShowUsersSpecified
        {
            get
            {
                return this.willShowUsersFieldSpecified;
            }
            set
            {
                this.willShowUsersFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ws.workflow.ecm.technology.totvs.com/")]
    public partial class colleagueDto
    {

        private bool activeField;

        private bool activeFieldSpecified;

        private bool adminUserField;

        private bool adminUserFieldSpecified;

        private int area1IdField;

        private bool area1IdFieldSpecified;

        private int area2IdField;

        private bool area2IdFieldSpecified;

        private int area3IdField;

        private bool area3IdFieldSpecified;

        private int area4IdField;

        private bool area4IdFieldSpecified;

        private int area5IdField;

        private bool area5IdFieldSpecified;

        private string colleagueIdField;

        private string colleagueNameField;

        private string colleaguebackgroundField;

        private long companyIdField;

        private string currentProjectField;

        private string defaultLanguageField;

        private string dialectIdField;

        private string ecmVersionField;

        private bool emailHtmlField;

        private bool emailHtmlFieldSpecified;

        private string especializationAreaField;

        private string extensionNrField;

        private bool gedUserField;

        private bool gedUserFieldSpecified;

        private string groupIdField;

        private bool guestUserField;

        private bool guestUserFieldSpecified;

        private string homePageField;

        private string loginField;

        private string mailField;

        private float maxPrivateSizeField;

        private bool maxPrivateSizeFieldSpecified;

        private int menuConfigField;

        private bool menuConfigFieldSpecified;

        private bool nominalUserField;

        private bool nominalUserFieldSpecified;

        private string passwdField;

        private string photoPathField;

        private int rowIdField;

        private string sessionIdField;

        private float usedSpaceField;

        private bool usedSpaceFieldSpecified;

        private string volumeIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public bool active
        {
            get
            {
                return this.activeField;
            }
            set
            {
                this.activeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool activeSpecified
        {
            get
            {
                return this.activeFieldSpecified;
            }
            set
            {
                this.activeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public bool adminUser
        {
            get
            {
                return this.adminUserField;
            }
            set
            {
                this.adminUserField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool adminUserSpecified
        {
            get
            {
                return this.adminUserFieldSpecified;
            }
            set
            {
                this.adminUserFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public int area1Id
        {
            get
            {
                return this.area1IdField;
            }
            set
            {
                this.area1IdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool area1IdSpecified
        {
            get
            {
                return this.area1IdFieldSpecified;
            }
            set
            {
                this.area1IdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public int area2Id
        {
            get
            {
                return this.area2IdField;
            }
            set
            {
                this.area2IdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool area2IdSpecified
        {
            get
            {
                return this.area2IdFieldSpecified;
            }
            set
            {
                this.area2IdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public int area3Id
        {
            get
            {
                return this.area3IdField;
            }
            set
            {
                this.area3IdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool area3IdSpecified
        {
            get
            {
                return this.area3IdFieldSpecified;
            }
            set
            {
                this.area3IdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public int area4Id
        {
            get
            {
                return this.area4IdField;
            }
            set
            {
                this.area4IdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool area4IdSpecified
        {
            get
            {
                return this.area4IdFieldSpecified;
            }
            set
            {
                this.area4IdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
        public int area5Id
        {
            get
            {
                return this.area5IdField;
            }
            set
            {
                this.area5IdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool area5IdSpecified
        {
            get
            {
                return this.area5IdFieldSpecified;
            }
            set
            {
                this.area5IdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
        public string colleagueId
        {
            get
            {
                return this.colleagueIdField;
            }
            set
            {
                this.colleagueIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 8)]
        public string colleagueName
        {
            get
            {
                return this.colleagueNameField;
            }
            set
            {
                this.colleagueNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 9)]
        public string colleaguebackground
        {
            get
            {
                return this.colleaguebackgroundField;
            }
            set
            {
                this.colleaguebackgroundField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 10)]
        public long companyId
        {
            get
            {
                return this.companyIdField;
            }
            set
            {
                this.companyIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 11)]
        public string currentProject
        {
            get
            {
                return this.currentProjectField;
            }
            set
            {
                this.currentProjectField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 12)]
        public string defaultLanguage
        {
            get
            {
                return this.defaultLanguageField;
            }
            set
            {
                this.defaultLanguageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 13)]
        public string dialectId
        {
            get
            {
                return this.dialectIdField;
            }
            set
            {
                this.dialectIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 14)]
        public string ecmVersion
        {
            get
            {
                return this.ecmVersionField;
            }
            set
            {
                this.ecmVersionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 15)]
        public bool emailHtml
        {
            get
            {
                return this.emailHtmlField;
            }
            set
            {
                this.emailHtmlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool emailHtmlSpecified
        {
            get
            {
                return this.emailHtmlFieldSpecified;
            }
            set
            {
                this.emailHtmlFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 16)]
        public string especializationArea
        {
            get
            {
                return this.especializationAreaField;
            }
            set
            {
                this.especializationAreaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 17)]
        public string extensionNr
        {
            get
            {
                return this.extensionNrField;
            }
            set
            {
                this.extensionNrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 18)]
        public bool gedUser
        {
            get
            {
                return this.gedUserField;
            }
            set
            {
                this.gedUserField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool gedUserSpecified
        {
            get
            {
                return this.gedUserFieldSpecified;
            }
            set
            {
                this.gedUserFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 19)]
        public string groupId
        {
            get
            {
                return this.groupIdField;
            }
            set
            {
                this.groupIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 20)]
        public bool guestUser
        {
            get
            {
                return this.guestUserField;
            }
            set
            {
                this.guestUserField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool guestUserSpecified
        {
            get
            {
                return this.guestUserFieldSpecified;
            }
            set
            {
                this.guestUserFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 21)]
        public string homePage
        {
            get
            {
                return this.homePageField;
            }
            set
            {
                this.homePageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 22)]
        public string login
        {
            get
            {
                return this.loginField;
            }
            set
            {
                this.loginField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 23)]
        public string mail
        {
            get
            {
                return this.mailField;
            }
            set
            {
                this.mailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 24)]
        public float maxPrivateSize
        {
            get
            {
                return this.maxPrivateSizeField;
            }
            set
            {
                this.maxPrivateSizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maxPrivateSizeSpecified
        {
            get
            {
                return this.maxPrivateSizeFieldSpecified;
            }
            set
            {
                this.maxPrivateSizeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 25)]
        public int menuConfig
        {
            get
            {
                return this.menuConfigField;
            }
            set
            {
                this.menuConfigField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool menuConfigSpecified
        {
            get
            {
                return this.menuConfigFieldSpecified;
            }
            set
            {
                this.menuConfigFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 26)]
        public bool nominalUser
        {
            get
            {
                return this.nominalUserField;
            }
            set
            {
                this.nominalUserField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool nominalUserSpecified
        {
            get
            {
                return this.nominalUserFieldSpecified;
            }
            set
            {
                this.nominalUserFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 27)]
        public string passwd
        {
            get
            {
                return this.passwdField;
            }
            set
            {
                this.passwdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 28)]
        public string photoPath
        {
            get
            {
                return this.photoPathField;
            }
            set
            {
                this.photoPathField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 29)]
        public int rowId
        {
            get
            {
                return this.rowIdField;
            }
            set
            {
                this.rowIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 30)]
        public string sessionId
        {
            get
            {
                return this.sessionIdField;
            }
            set
            {
                this.sessionIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 31)]
        public float usedSpace
        {
            get
            {
                return this.usedSpaceField;
            }
            set
            {
                this.usedSpaceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool usedSpaceSpecified
        {
            get
            {
                return this.usedSpaceFieldSpecified;
            }
            set
            {
                this.usedSpaceFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 32)]
        public string volumeId
        {
            get
            {
                return this.volumeIdField;
            }
            set
            {
                this.volumeIdField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "saveAndSendTaskClassic", WrapperNamespace = "http://ws.workflow.ecm.technology.totvs.com/", IsWrapped = true)]
    public partial class saveAndSendTaskClassic
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 0)]
        public string username;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 1)]
        public string password;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 2)]
        public int companyId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 3)]
        public int processInstanceId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 4)]
        public int choosedState;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string[]", Order = 5)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] colleagueIds;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 6)]
        public string comments;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 7)]
        public string userId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "bool", Order = 8)]
        public bool completeTask;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "processAttachmentDto[]", Order = 9)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public processAttachmentDto[] attachments;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "keyValueDto[]", Order = 10)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public keyValueDto[] cardData;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "processTaskAppointmentDto[]", Order = 11)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public processTaskAppointmentDto[] appointment;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "bool", Order = 12)]
        public bool managerMode;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 13)]
        public int threadSequence;

        public saveAndSendTaskClassic()
        {
        }

        public saveAndSendTaskClassic(string username, string password, int companyId, int processInstanceId, int choosedState, string[] colleagueIds, string comments, string userId, bool completeTask, processAttachmentDto[] attachments, keyValueDto[] cardData, processTaskAppointmentDto[] appointment, bool managerMode, int threadSequence)
        {
            this.username = username;
            this.password = password;
            this.companyId = companyId;
            this.processInstanceId = processInstanceId;
            this.choosedState = choosedState;
            this.colleagueIds = colleagueIds;
            this.comments = comments;
            this.userId = userId;
            this.completeTask = completeTask;
            this.attachments = attachments;
            this.cardData = cardData;
            this.appointment = appointment;
            this.managerMode = managerMode;
            this.threadSequence = threadSequence;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "saveAndSendTaskClassicResponse", WrapperNamespace = "http://ws.workflow.ecm.technology.totvs.com/", IsWrapped = true)]
    public partial class saveAndSendTaskClassicResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "keyValueDto[]", Order = 0)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public keyValueDto[] result;

        public saveAndSendTaskClassicResponse()
        {
        }

        public saveAndSendTaskClassicResponse(keyValueDto[] result)
        {
            this.result = result;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "getAvailableUsers", WrapperNamespace = "http://ws.workflow.ecm.technology.totvs.com/", IsWrapped = true)]
    public partial class getAvailableUsers
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 0)]
        public string username;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 1)]
        public string password;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 2)]
        public int companyId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 3)]
        public int processInstanceId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 4)]
        public int state;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 5)]
        public int threadSequence;

        public getAvailableUsers()
        {
        }

        public getAvailableUsers(string username, string password, int companyId, int processInstanceId, int state, int threadSequence)
        {
            this.username = username;
            this.password = password;
            this.companyId = companyId;
            this.processInstanceId = processInstanceId;
            this.state = state;
            this.threadSequence = threadSequence;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "getAvailableUsersResponse", WrapperNamespace = "http://ws.workflow.ecm.technology.totvs.com/", IsWrapped = true)]
    public partial class getAvailableUsersResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string[]", Order = 0)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] AvailableUsers;

        public getAvailableUsersResponse()
        {
        }

        public getAvailableUsersResponse(string[] AvailableUsers)
        {
            this.AvailableUsers = AvailableUsers;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "getAttachments", WrapperNamespace = "http://ws.workflow.ecm.technology.totvs.com/", IsWrapped = true)]
    public partial class getAttachments
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 0)]
        public string username;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 1)]
        public string password;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 2)]
        public int companyId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 3)]
        public string userId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 4)]
        public int processInstanceId;

        public getAttachments()
        {
        }

        public getAttachments(string username, string password, int companyId, string userId, int processInstanceId)
        {
            this.username = username;
            this.password = password;
            this.companyId = companyId;
            this.userId = userId;
            this.processInstanceId = processInstanceId;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "getAttachmentsResponse", WrapperNamespace = "http://ws.workflow.ecm.technology.totvs.com/", IsWrapped = true)]
    public partial class getAttachmentsResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "processAttachmentDto[]", Order = 0)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public processAttachmentDto[] Attachments;

        public getAttachmentsResponse()
        {
        }

        public getAttachmentsResponse(processAttachmentDto[] Attachments)
        {
            this.Attachments = Attachments;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "importProcessWithCardAndPersistenceType", WrapperNamespace = "http://ws.workflow.ecm.technology.totvs.com/", IsWrapped = true)]
    public partial class importProcessWithCardAndPersistenceType
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 0)]
        public string username;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 1)]
        public string password;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 2)]
        public int companyId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 3)]
        public string processId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "attachment[]", Order = 4)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public attachment[] processAttachs;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "bool", Order = 5)]
        public bool newProcess;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "bool", Order = 6)]
        public bool overWrite;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 7)]
        public string colleagueId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 8)]
        public int parentDocumentId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 9)]
        public string documentDescription;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 10)]
        public string cardDescription;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 11)]
        public string datasetName;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "attachment[]", Order = 12)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public attachment[] cardAttachs;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "cardEventDto[]", Order = 13)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public cardEventDto[] customEvents;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "bool", Order = 14)]
        public bool update;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 15)]
        public int persistenceType;

        public importProcessWithCardAndPersistenceType()
        {
        }

        public importProcessWithCardAndPersistenceType(
                    string username,
                    string password,
                    int companyId,
                    string processId,
                    attachment[] processAttachs,
                    bool newProcess,
                    bool overWrite,
                    string colleagueId,
                    int parentDocumentId,
                    string documentDescription,
                    string cardDescription,
                    string datasetName,
                    attachment[] cardAttachs,
                    cardEventDto[] customEvents,
                    bool update,
                    int persistenceType)
        {
            this.username = username;
            this.password = password;
            this.companyId = companyId;
            this.processId = processId;
            this.processAttachs = processAttachs;
            this.newProcess = newProcess;
            this.overWrite = overWrite;
            this.colleagueId = colleagueId;
            this.parentDocumentId = parentDocumentId;
            this.documentDescription = documentDescription;
            this.cardDescription = cardDescription;
            this.datasetName = datasetName;
            this.cardAttachs = cardAttachs;
            this.customEvents = customEvents;
            this.update = update;
            this.persistenceType = persistenceType;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "importProcessWithCardAndPersistenceTypeResponse", WrapperNamespace = "http://ws.workflow.ecm.technology.totvs.com/", IsWrapped = true)]
    public partial class importProcessWithCardAndPersistenceTypeResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "webServiceMessage", Order = 0)]
        public webServiceMessage result;

        public importProcessWithCardAndPersistenceTypeResponse()
        {
        }

        public importProcessWithCardAndPersistenceTypeResponse(webServiceMessage result)
        {
            this.result = result;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "getAvailableUsersStart", WrapperNamespace = "http://ws.workflow.ecm.technology.totvs.com/", IsWrapped = true)]
    public partial class getAvailableUsersStart
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 0)]
        public string username;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 1)]
        public string password;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 2)]
        public int companyId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 3)]
        public string processId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 4)]
        public int state;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 5)]
        public int threadSequence;

        public getAvailableUsersStart()
        {
        }

        public getAvailableUsersStart(string username, string password, int companyId, string processId, int state, int threadSequence)
        {
            this.username = username;
            this.password = password;
            this.companyId = companyId;
            this.processId = processId;
            this.state = state;
            this.threadSequence = threadSequence;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "getAvailableUsersStartResponse", WrapperNamespace = "http://ws.workflow.ecm.technology.totvs.com/", IsWrapped = true)]
    public partial class getAvailableUsersStartResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string[]", Order = 0)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] AvailableUsers;

        public getAvailableUsersStartResponse()
        {
        }

        public getAvailableUsersStartResponse(string[] AvailableUsers)
        {
            this.AvailableUsers = AvailableUsers;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "importProcessWithCardAndGeneralInfo", WrapperNamespace = "http://ws.workflow.ecm.technology.totvs.com/", IsWrapped = true)]
    public partial class importProcessWithCardAndGeneralInfo
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 0)]
        public string username;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 1)]
        public string password;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 2)]
        public int companyId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 3)]
        public string processId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "attachment[]", Order = 4)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public attachment[] processAttachs;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "bool", Order = 5)]
        public bool newProcess;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "bool", Order = 6)]
        public bool overWrite;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 7)]
        public string colleagueId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 8)]
        public int parentDocumentId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 9)]
        public string documentDescription;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 10)]
        public string cardDescription;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 11)]
        public string datasetName;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 12)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public attachment[] cardAttachs;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "cardEventDto[]", Order = 13)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public cardEventDto[] customEvents;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "generalInfoDto", Order = 14)]
        public generalInfoDto generalInfo;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "bool", Order = 15)]
        public bool update;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 16)]
        public int persistenceType;

        public importProcessWithCardAndGeneralInfo()
        {
        }

        public importProcessWithCardAndGeneralInfo(
                    string username,
                    string password,
                    int companyId,
                    string processId,
                    attachment[] processAttachs,
                    bool newProcess,
                    bool overWrite,
                    string colleagueId,
                    int parentDocumentId,
                    string documentDescription,
                    string cardDescription,
                    string datasetName,
                    attachment[] cardAttachs,
                    cardEventDto[] customEvents,
                    generalInfoDto generalInfo,
                    bool update,
                    int persistenceType)
        {
            this.username = username;
            this.password = password;
            this.companyId = companyId;
            this.processId = processId;
            this.processAttachs = processAttachs;
            this.newProcess = newProcess;
            this.overWrite = overWrite;
            this.colleagueId = colleagueId;
            this.parentDocumentId = parentDocumentId;
            this.documentDescription = documentDescription;
            this.cardDescription = cardDescription;
            this.datasetName = datasetName;
            this.cardAttachs = cardAttachs;
            this.customEvents = customEvents;
            this.generalInfo = generalInfo;
            this.update = update;
            this.persistenceType = persistenceType;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "importProcessWithCardAndGeneralInfoResponse", WrapperNamespace = "http://ws.workflow.ecm.technology.totvs.com/", IsWrapped = true)]
    public partial class importProcessWithCardAndGeneralInfoResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "webServiceMessage", Order = 0)]
        public webServiceMessage result;

        public importProcessWithCardAndGeneralInfoResponse()
        {
        }

        public importProcessWithCardAndGeneralInfoResponse(webServiceMessage result)
        {
            this.result = result;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "getAvailableStates", WrapperNamespace = "http://ws.workflow.ecm.technology.totvs.com/", IsWrapped = true)]
    public partial class getAvailableStates
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 0)]
        public string username;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 1)]
        public string password;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 2)]
        public int companyId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 3)]
        public string processId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 4)]
        public int processInstanceId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 5)]
        public int threadSequence;

        public getAvailableStates()
        {
        }

        public getAvailableStates(string username, string password, int companyId, string processId, int processInstanceId, int threadSequence)
        {
            this.username = username;
            this.password = password;
            this.companyId = companyId;
            this.processId = processId;
            this.processInstanceId = processInstanceId;
            this.threadSequence = threadSequence;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "getAvailableStatesResponse", WrapperNamespace = "http://ws.workflow.ecm.technology.totvs.com/", IsWrapped = true)]
    public partial class getAvailableStatesResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "System.Nullable<int>[]", Order = 0)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.Nullable<int>[] States;

        public getAvailableStatesResponse()
        {
        }

        public getAvailableStatesResponse(System.Nullable<int>[] States)
        {
            this.States = States;
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ws.workflow.ecm.technology.totvs.com/")]
    public partial class documentDto
    {

        private int accessCountField;

        private bool accessCountFieldSpecified;

        private bool activeUserApproverField;

        private bool activeUserApproverFieldSpecified;

        private bool activeVersionField;

        private bool activeVersionFieldSpecified;

        private string additionalCommentsField;

        private bool allowMuiltiCardsPerUserField;

        private bool allowMuiltiCardsPerUserFieldSpecified;

        private bool approvalAndOrField;

        private bool approvalAndOrFieldSpecified;

        private bool approvedField;

        private bool approvedFieldSpecified;

        private System.DateTime approvedDateField;

        private bool approvedDateFieldSpecified;

        private string articleContentField;

        private attachment[] attachmentsField;

        private int atualizationIdField;

        private bool atualizationIdFieldSpecified;

        private string backgroundColorField;

        private string backgroundImageField;

        private string bannerImageField;

        private string cardDescriptionField;

        private string colleagueIdField;

        private string colleagueNameField;

        private long companyIdField;

        private long crcField;

        private bool crcFieldSpecified;

        private System.DateTime createDateField;

        private bool createDateFieldSpecified;

        private long createDateInMillisecondsField;

        private string datasetNameField;

        private bool dateFormStartedField;

        private bool dateFormStartedFieldSpecified;

        private bool deletedField;

        private bool deletedFieldSpecified;

        private string documentDescriptionField;

        private int documentIdField;

        private bool documentIdFieldSpecified;

        private string documentKeyWordField;

        private int documentPropertyNumberField;

        private bool documentPropertyNumberFieldSpecified;

        private int documentPropertyVersionField;

        private bool documentPropertyVersionFieldSpecified;

        private string documentTypeField;

        private string documentTypeIdField;

        private bool downloadEnabledField;

        private bool downloadEnabledFieldSpecified;

        private bool draftField;

        private bool draftFieldSpecified;

        private System.DateTime expirationDateField;

        private bool expirationDateFieldSpecified;

        private bool expiredFormField;

        private bool expiredFormFieldSpecified;

        private bool expiresField;

        private bool expiresFieldSpecified;

        private string externalDocumentIdField;

        private bool favoriteField;

        private bool favoriteFieldSpecified;

        private string fileURLField;

        private int folderIdField;

        private bool folderIdFieldSpecified;

        private bool forAprovalField;

        private int iconIdField;

        private bool iconIdFieldSpecified;

        private string iconPathField;

        private bool imutableField;

        private bool imutableFieldSpecified;

        private bool indexedField;

        private bool indexedFieldSpecified;

        private bool inheritSecurityField;

        private bool internalVisualizerField;

        private bool internalVisualizerFieldSpecified;

        private bool isEncryptedField;

        private bool isEncryptedFieldSpecified;

        private string keyWordField;

        private string languageIdField;

        private string languageIndicatorField;

        private System.DateTime lastModifiedDateField;

        private bool lastModifiedDateFieldSpecified;

        private string lastModifiedTimeField;

        private int metaListIdField;

        private bool metaListIdFieldSpecified;

        private int metaListRecordIdField;

        private bool metaListRecordIdFieldSpecified;

        private bool newStructureField;

        private bool newStructureFieldSpecified;

        private bool onCheckoutField;

        private int parentDocumentIdField;

        private bool parentDocumentIdFieldSpecified;

        private string pdfRenderEngineField;

        private int permissionTypeField;

        private bool permissionTypeFieldSpecified;

        private string phisicalFileField;

        private float phisicalFileSizeField;

        private bool phisicalFileSizeFieldSpecified;

        private int priorityField;

        private bool priorityFieldSpecified;

        private string privateColleagueIdField;

        private bool privateDocumentField;

        private bool privateDocumentFieldSpecified;

        private bool protectedCopyField;

        private bool protectedCopyFieldSpecified;

        private string publisherIdField;

        private string publisherNameField;

        private string relatedFilesField;

        private int restrictionTypeField;

        private bool restrictionTypeFieldSpecified;

        private int rowIdField;

        private int searchNumberField;

        private bool searchNumberFieldSpecified;

        private int securityLevelField;

        private string siteCodeField;

        private sociableDocumentDto sociableDocumentDtoField;

        private string socialDocumentField;

        private bool toolField;

        private bool toolFieldSpecified;

        private int topicIdField;

        private bool topicIdFieldSpecified;

        private bool translatedField;

        private string uUIDField;

        private bool updateIsoPropertiesField;

        private bool userAnswerFormField;

        private bool userAnswerFormFieldSpecified;

        private bool userNotifyField;

        private bool userNotifyFieldSpecified;

        private int userPermissionField;

        private bool userPermissionFieldSpecified;

        private System.DateTime validationStartDateField;

        private bool validationStartDateFieldSpecified;

        private int versionField;

        private string versionDescriptionField;

        private string versionOptionField;

        private string visualizationField;

        private string volumeIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public int accessCount
        {
            get
            {
                return this.accessCountField;
            }
            set
            {
                this.accessCountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool accessCountSpecified
        {
            get
            {
                return this.accessCountFieldSpecified;
            }
            set
            {
                this.accessCountFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public bool activeUserApprover
        {
            get
            {
                return this.activeUserApproverField;
            }
            set
            {
                this.activeUserApproverField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool activeUserApproverSpecified
        {
            get
            {
                return this.activeUserApproverFieldSpecified;
            }
            set
            {
                this.activeUserApproverFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public bool activeVersion
        {
            get
            {
                return this.activeVersionField;
            }
            set
            {
                this.activeVersionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool activeVersionSpecified
        {
            get
            {
                return this.activeVersionFieldSpecified;
            }
            set
            {
                this.activeVersionFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public string additionalComments
        {
            get
            {
                return this.additionalCommentsField;
            }
            set
            {
                this.additionalCommentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public bool allowMuiltiCardsPerUser
        {
            get
            {
                return this.allowMuiltiCardsPerUserField;
            }
            set
            {
                this.allowMuiltiCardsPerUserField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool allowMuiltiCardsPerUserSpecified
        {
            get
            {
                return this.allowMuiltiCardsPerUserFieldSpecified;
            }
            set
            {
                this.allowMuiltiCardsPerUserFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public bool approvalAndOr
        {
            get
            {
                return this.approvalAndOrField;
            }
            set
            {
                this.approvalAndOrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool approvalAndOrSpecified
        {
            get
            {
                return this.approvalAndOrFieldSpecified;
            }
            set
            {
                this.approvalAndOrFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
        public bool approved
        {
            get
            {
                return this.approvedField;
            }
            set
            {
                this.approvedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool approvedSpecified
        {
            get
            {
                return this.approvedFieldSpecified;
            }
            set
            {
                this.approvedFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
        public System.DateTime approvedDate
        {
            get
            {
                return this.approvedDateField;
            }
            set
            {
                this.approvedDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool approvedDateSpecified
        {
            get
            {
                return this.approvedDateFieldSpecified;
            }
            set
            {
                this.approvedDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 8)]
        public string articleContent
        {
            get
            {
                return this.articleContentField;
            }
            set
            {
                this.articleContentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("attachments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 9)]
        public attachment[] attachments
        {
            get
            {
                return this.attachmentsField;
            }
            set
            {
                this.attachmentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 10)]
        public int atualizationId
        {
            get
            {
                return this.atualizationIdField;
            }
            set
            {
                this.atualizationIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool atualizationIdSpecified
        {
            get
            {
                return this.atualizationIdFieldSpecified;
            }
            set
            {
                this.atualizationIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 11)]
        public string backgroundColor
        {
            get
            {
                return this.backgroundColorField;
            }
            set
            {
                this.backgroundColorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 12)]
        public string backgroundImage
        {
            get
            {
                return this.backgroundImageField;
            }
            set
            {
                this.backgroundImageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 13)]
        public string bannerImage
        {
            get
            {
                return this.bannerImageField;
            }
            set
            {
                this.bannerImageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 14)]
        public string cardDescription
        {
            get
            {
                return this.cardDescriptionField;
            }
            set
            {
                this.cardDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 15)]
        public string colleagueId
        {
            get
            {
                return this.colleagueIdField;
            }
            set
            {
                this.colleagueIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 16)]
        public string colleagueName
        {
            get
            {
                return this.colleagueNameField;
            }
            set
            {
                this.colleagueNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 17)]
        public long companyId
        {
            get
            {
                return this.companyIdField;
            }
            set
            {
                this.companyIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 18)]
        public long crc
        {
            get
            {
                return this.crcField;
            }
            set
            {
                this.crcField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool crcSpecified
        {
            get
            {
                return this.crcFieldSpecified;
            }
            set
            {
                this.crcFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 19)]
        public System.DateTime createDate
        {
            get
            {
                return this.createDateField;
            }
            set
            {
                this.createDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool createDateSpecified
        {
            get
            {
                return this.createDateFieldSpecified;
            }
            set
            {
                this.createDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 20)]
        public long createDateInMilliseconds
        {
            get
            {
                return this.createDateInMillisecondsField;
            }
            set
            {
                this.createDateInMillisecondsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 21)]
        public string datasetName
        {
            get
            {
                return this.datasetNameField;
            }
            set
            {
                this.datasetNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 22)]
        public bool dateFormStarted
        {
            get
            {
                return this.dateFormStartedField;
            }
            set
            {
                this.dateFormStartedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dateFormStartedSpecified
        {
            get
            {
                return this.dateFormStartedFieldSpecified;
            }
            set
            {
                this.dateFormStartedFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 23)]
        public bool deleted
        {
            get
            {
                return this.deletedField;
            }
            set
            {
                this.deletedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool deletedSpecified
        {
            get
            {
                return this.deletedFieldSpecified;
            }
            set
            {
                this.deletedFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 24)]
        public string documentDescription
        {
            get
            {
                return this.documentDescriptionField;
            }
            set
            {
                this.documentDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 25)]
        public int documentId
        {
            get
            {
                return this.documentIdField;
            }
            set
            {
                this.documentIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool documentIdSpecified
        {
            get
            {
                return this.documentIdFieldSpecified;
            }
            set
            {
                this.documentIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 26)]
        public string documentKeyWord
        {
            get
            {
                return this.documentKeyWordField;
            }
            set
            {
                this.documentKeyWordField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 27)]
        public int documentPropertyNumber
        {
            get
            {
                return this.documentPropertyNumberField;
            }
            set
            {
                this.documentPropertyNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool documentPropertyNumberSpecified
        {
            get
            {
                return this.documentPropertyNumberFieldSpecified;
            }
            set
            {
                this.documentPropertyNumberFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 28)]
        public int documentPropertyVersion
        {
            get
            {
                return this.documentPropertyVersionField;
            }
            set
            {
                this.documentPropertyVersionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool documentPropertyVersionSpecified
        {
            get
            {
                return this.documentPropertyVersionFieldSpecified;
            }
            set
            {
                this.documentPropertyVersionFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 29)]
        public string documentType
        {
            get
            {
                return this.documentTypeField;
            }
            set
            {
                this.documentTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 30)]
        public string documentTypeId
        {
            get
            {
                return this.documentTypeIdField;
            }
            set
            {
                this.documentTypeIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 31)]
        public bool downloadEnabled
        {
            get
            {
                return this.downloadEnabledField;
            }
            set
            {
                this.downloadEnabledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool downloadEnabledSpecified
        {
            get
            {
                return this.downloadEnabledFieldSpecified;
            }
            set
            {
                this.downloadEnabledFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 32)]
        public bool draft
        {
            get
            {
                return this.draftField;
            }
            set
            {
                this.draftField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool draftSpecified
        {
            get
            {
                return this.draftFieldSpecified;
            }
            set
            {
                this.draftFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 33)]
        public System.DateTime expirationDate
        {
            get
            {
                return this.expirationDateField;
            }
            set
            {
                this.expirationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool expirationDateSpecified
        {
            get
            {
                return this.expirationDateFieldSpecified;
            }
            set
            {
                this.expirationDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 34)]
        public bool expiredForm
        {
            get
            {
                return this.expiredFormField;
            }
            set
            {
                this.expiredFormField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool expiredFormSpecified
        {
            get
            {
                return this.expiredFormFieldSpecified;
            }
            set
            {
                this.expiredFormFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 35)]
        public bool expires
        {
            get
            {
                return this.expiresField;
            }
            set
            {
                this.expiresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool expiresSpecified
        {
            get
            {
                return this.expiresFieldSpecified;
            }
            set
            {
                this.expiresFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 36)]
        public string externalDocumentId
        {
            get
            {
                return this.externalDocumentIdField;
            }
            set
            {
                this.externalDocumentIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 37)]
        public bool favorite
        {
            get
            {
                return this.favoriteField;
            }
            set
            {
                this.favoriteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool favoriteSpecified
        {
            get
            {
                return this.favoriteFieldSpecified;
            }
            set
            {
                this.favoriteFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 38)]
        public string fileURL
        {
            get
            {
                return this.fileURLField;
            }
            set
            {
                this.fileURLField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 39)]
        public int folderId
        {
            get
            {
                return this.folderIdField;
            }
            set
            {
                this.folderIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool folderIdSpecified
        {
            get
            {
                return this.folderIdFieldSpecified;
            }
            set
            {
                this.folderIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 40)]
        public bool forAproval
        {
            get
            {
                return this.forAprovalField;
            }
            set
            {
                this.forAprovalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 41)]
        public int iconId
        {
            get
            {
                return this.iconIdField;
            }
            set
            {
                this.iconIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool iconIdSpecified
        {
            get
            {
                return this.iconIdFieldSpecified;
            }
            set
            {
                this.iconIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 42)]
        public string iconPath
        {
            get
            {
                return this.iconPathField;
            }
            set
            {
                this.iconPathField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 43)]
        public bool imutable
        {
            get
            {
                return this.imutableField;
            }
            set
            {
                this.imutableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool imutableSpecified
        {
            get
            {
                return this.imutableFieldSpecified;
            }
            set
            {
                this.imutableFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 44)]
        public bool indexed
        {
            get
            {
                return this.indexedField;
            }
            set
            {
                this.indexedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool indexedSpecified
        {
            get
            {
                return this.indexedFieldSpecified;
            }
            set
            {
                this.indexedFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 45)]
        public bool inheritSecurity
        {
            get
            {
                return this.inheritSecurityField;
            }
            set
            {
                this.inheritSecurityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 46)]
        public bool internalVisualizer
        {
            get
            {
                return this.internalVisualizerField;
            }
            set
            {
                this.internalVisualizerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool internalVisualizerSpecified
        {
            get
            {
                return this.internalVisualizerFieldSpecified;
            }
            set
            {
                this.internalVisualizerFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 47)]
        public bool isEncrypted
        {
            get
            {
                return this.isEncryptedField;
            }
            set
            {
                this.isEncryptedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isEncryptedSpecified
        {
            get
            {
                return this.isEncryptedFieldSpecified;
            }
            set
            {
                this.isEncryptedFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 48)]
        public string keyWord
        {
            get
            {
                return this.keyWordField;
            }
            set
            {
                this.keyWordField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 49)]
        public string languageId
        {
            get
            {
                return this.languageIdField;
            }
            set
            {
                this.languageIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 50)]
        public string languageIndicator
        {
            get
            {
                return this.languageIndicatorField;
            }
            set
            {
                this.languageIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 51)]
        public System.DateTime lastModifiedDate
        {
            get
            {
                return this.lastModifiedDateField;
            }
            set
            {
                this.lastModifiedDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lastModifiedDateSpecified
        {
            get
            {
                return this.lastModifiedDateFieldSpecified;
            }
            set
            {
                this.lastModifiedDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 52)]
        public string lastModifiedTime
        {
            get
            {
                return this.lastModifiedTimeField;
            }
            set
            {
                this.lastModifiedTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 53)]
        public int metaListId
        {
            get
            {
                return this.metaListIdField;
            }
            set
            {
                this.metaListIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool metaListIdSpecified
        {
            get
            {
                return this.metaListIdFieldSpecified;
            }
            set
            {
                this.metaListIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 54)]
        public int metaListRecordId
        {
            get
            {
                return this.metaListRecordIdField;
            }
            set
            {
                this.metaListRecordIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool metaListRecordIdSpecified
        {
            get
            {
                return this.metaListRecordIdFieldSpecified;
            }
            set
            {
                this.metaListRecordIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 55)]
        public bool newStructure
        {
            get
            {
                return this.newStructureField;
            }
            set
            {
                this.newStructureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool newStructureSpecified
        {
            get
            {
                return this.newStructureFieldSpecified;
            }
            set
            {
                this.newStructureFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 56)]
        public bool onCheckout
        {
            get
            {
                return this.onCheckoutField;
            }
            set
            {
                this.onCheckoutField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 57)]
        public int parentDocumentId
        {
            get
            {
                return this.parentDocumentIdField;
            }
            set
            {
                this.parentDocumentIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool parentDocumentIdSpecified
        {
            get
            {
                return this.parentDocumentIdFieldSpecified;
            }
            set
            {
                this.parentDocumentIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 58)]
        public string pdfRenderEngine
        {
            get
            {
                return this.pdfRenderEngineField;
            }
            set
            {
                this.pdfRenderEngineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 59)]
        public int permissionType
        {
            get
            {
                return this.permissionTypeField;
            }
            set
            {
                this.permissionTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool permissionTypeSpecified
        {
            get
            {
                return this.permissionTypeFieldSpecified;
            }
            set
            {
                this.permissionTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 60)]
        public string phisicalFile
        {
            get
            {
                return this.phisicalFileField;
            }
            set
            {
                this.phisicalFileField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 61)]
        public float phisicalFileSize
        {
            get
            {
                return this.phisicalFileSizeField;
            }
            set
            {
                this.phisicalFileSizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool phisicalFileSizeSpecified
        {
            get
            {
                return this.phisicalFileSizeFieldSpecified;
            }
            set
            {
                this.phisicalFileSizeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 62)]
        public int priority
        {
            get
            {
                return this.priorityField;
            }
            set
            {
                this.priorityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool prioritySpecified
        {
            get
            {
                return this.priorityFieldSpecified;
            }
            set
            {
                this.priorityFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 63)]
        public string privateColleagueId
        {
            get
            {
                return this.privateColleagueIdField;
            }
            set
            {
                this.privateColleagueIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 64)]
        public bool privateDocument
        {
            get
            {
                return this.privateDocumentField;
            }
            set
            {
                this.privateDocumentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool privateDocumentSpecified
        {
            get
            {
                return this.privateDocumentFieldSpecified;
            }
            set
            {
                this.privateDocumentFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 65)]
        public bool protectedCopy
        {
            get
            {
                return this.protectedCopyField;
            }
            set
            {
                this.protectedCopyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool protectedCopySpecified
        {
            get
            {
                return this.protectedCopyFieldSpecified;
            }
            set
            {
                this.protectedCopyFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 66)]
        public string publisherId
        {
            get
            {
                return this.publisherIdField;
            }
            set
            {
                this.publisherIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 67)]
        public string publisherName
        {
            get
            {
                return this.publisherNameField;
            }
            set
            {
                this.publisherNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 68)]
        public string relatedFiles
        {
            get
            {
                return this.relatedFilesField;
            }
            set
            {
                this.relatedFilesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 69)]
        public int restrictionType
        {
            get
            {
                return this.restrictionTypeField;
            }
            set
            {
                this.restrictionTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool restrictionTypeSpecified
        {
            get
            {
                return this.restrictionTypeFieldSpecified;
            }
            set
            {
                this.restrictionTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 70)]
        public int rowId
        {
            get
            {
                return this.rowIdField;
            }
            set
            {
                this.rowIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 71)]
        public int searchNumber
        {
            get
            {
                return this.searchNumberField;
            }
            set
            {
                this.searchNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool searchNumberSpecified
        {
            get
            {
                return this.searchNumberFieldSpecified;
            }
            set
            {
                this.searchNumberFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 72)]
        public int securityLevel
        {
            get
            {
                return this.securityLevelField;
            }
            set
            {
                this.securityLevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 73)]
        public string siteCode
        {
            get
            {
                return this.siteCodeField;
            }
            set
            {
                this.siteCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 74)]
        public sociableDocumentDto sociableDocumentDto
        {
            get
            {
                return this.sociableDocumentDtoField;
            }
            set
            {
                this.sociableDocumentDtoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 75)]
        public string socialDocument
        {
            get
            {
                return this.socialDocumentField;
            }
            set
            {
                this.socialDocumentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 76)]
        public bool tool
        {
            get
            {
                return this.toolField;
            }
            set
            {
                this.toolField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool toolSpecified
        {
            get
            {
                return this.toolFieldSpecified;
            }
            set
            {
                this.toolFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 77)]
        public int topicId
        {
            get
            {
                return this.topicIdField;
            }
            set
            {
                this.topicIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool topicIdSpecified
        {
            get
            {
                return this.topicIdFieldSpecified;
            }
            set
            {
                this.topicIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 78)]
        public bool translated
        {
            get
            {
                return this.translatedField;
            }
            set
            {
                this.translatedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 79)]
        public string UUID
        {
            get
            {
                return this.uUIDField;
            }
            set
            {
                this.uUIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 80)]
        public bool updateIsoProperties
        {
            get
            {
                return this.updateIsoPropertiesField;
            }
            set
            {
                this.updateIsoPropertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 81)]
        public bool userAnswerForm
        {
            get
            {
                return this.userAnswerFormField;
            }
            set
            {
                this.userAnswerFormField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool userAnswerFormSpecified
        {
            get
            {
                return this.userAnswerFormFieldSpecified;
            }
            set
            {
                this.userAnswerFormFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 82)]
        public bool userNotify
        {
            get
            {
                return this.userNotifyField;
            }
            set
            {
                this.userNotifyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool userNotifySpecified
        {
            get
            {
                return this.userNotifyFieldSpecified;
            }
            set
            {
                this.userNotifyFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 83)]
        public int userPermission
        {
            get
            {
                return this.userPermissionField;
            }
            set
            {
                this.userPermissionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool userPermissionSpecified
        {
            get
            {
                return this.userPermissionFieldSpecified;
            }
            set
            {
                this.userPermissionFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 84)]
        public System.DateTime validationStartDate
        {
            get
            {
                return this.validationStartDateField;
            }
            set
            {
                this.validationStartDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool validationStartDateSpecified
        {
            get
            {
                return this.validationStartDateFieldSpecified;
            }
            set
            {
                this.validationStartDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 85)]
        public int version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 86)]
        public string versionDescription
        {
            get
            {
                return this.versionDescriptionField;
            }
            set
            {
                this.versionDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 87)]
        public string versionOption
        {
            get
            {
                return this.versionOptionField;
            }
            set
            {
                this.versionOptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 88)]
        public string visualization
        {
            get
            {
                return this.visualizationField;
            }
            set
            {
                this.visualizationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 89)]
        public string volumeId
        {
            get
            {
                return this.volumeIdField;
            }
            set
            {
                this.volumeIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ws.workflow.ecm.technology.totvs.com/")]
    public partial class sociableDocumentDto
    {

        private bool commentedField;

        private bool denouncedField;

        private int documentIdField;

        private bool documentIdFieldSpecified;

        private bool followingField;

        private bool likedField;

        private int numberCommentsField;

        private bool numberCommentsFieldSpecified;

        private int numberDenouncementsField;

        private bool numberDenouncementsFieldSpecified;

        private int numberFollowsField;

        private bool numberFollowsFieldSpecified;

        private int numberLikesField;

        private bool numberLikesFieldSpecified;

        private int numberSharesField;

        private bool numberSharesFieldSpecified;

        private bool sharedField;

        private long sociableIdField;

        private bool sociableIdFieldSpecified;

        private int versionField;

        private bool versionFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public bool commented
        {
            get
            {
                return this.commentedField;
            }
            set
            {
                this.commentedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public bool denounced
        {
            get
            {
                return this.denouncedField;
            }
            set
            {
                this.denouncedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public int documentId
        {
            get
            {
                return this.documentIdField;
            }
            set
            {
                this.documentIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool documentIdSpecified
        {
            get
            {
                return this.documentIdFieldSpecified;
            }
            set
            {
                this.documentIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public bool following
        {
            get
            {
                return this.followingField;
            }
            set
            {
                this.followingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public bool liked
        {
            get
            {
                return this.likedField;
            }
            set
            {
                this.likedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public int numberComments
        {
            get
            {
                return this.numberCommentsField;
            }
            set
            {
                this.numberCommentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numberCommentsSpecified
        {
            get
            {
                return this.numberCommentsFieldSpecified;
            }
            set
            {
                this.numberCommentsFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
        public int numberDenouncements
        {
            get
            {
                return this.numberDenouncementsField;
            }
            set
            {
                this.numberDenouncementsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numberDenouncementsSpecified
        {
            get
            {
                return this.numberDenouncementsFieldSpecified;
            }
            set
            {
                this.numberDenouncementsFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
        public int numberFollows
        {
            get
            {
                return this.numberFollowsField;
            }
            set
            {
                this.numberFollowsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numberFollowsSpecified
        {
            get
            {
                return this.numberFollowsFieldSpecified;
            }
            set
            {
                this.numberFollowsFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 8)]
        public int numberLikes
        {
            get
            {
                return this.numberLikesField;
            }
            set
            {
                this.numberLikesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numberLikesSpecified
        {
            get
            {
                return this.numberLikesFieldSpecified;
            }
            set
            {
                this.numberLikesFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 9)]
        public int numberShares
        {
            get
            {
                return this.numberSharesField;
            }
            set
            {
                this.numberSharesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numberSharesSpecified
        {
            get
            {
                return this.numberSharesFieldSpecified;
            }
            set
            {
                this.numberSharesFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 10)]
        public bool shared
        {
            get
            {
                return this.sharedField;
            }
            set
            {
                this.sharedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 11)]
        public long sociableId
        {
            get
            {
                return this.sociableIdField;
            }
            set
            {
                this.sociableIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sociableIdSpecified
        {
            get
            {
                return this.sociableIdFieldSpecified;
            }
            set
            {
                this.sociableIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 12)]
        public int version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool versionSpecified
        {
            get
            {
                return this.versionFieldSpecified;
            }
            set
            {
                this.versionFieldSpecified = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "updateWorkflowAttachment", WrapperNamespace = "http://ws.workflow.ecm.technology.totvs.com/", IsWrapped = true)]
    public partial class updateWorkflowAttachment
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 0)]
        public string username;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 1)]
        public string password;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 2)]
        public int companyId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 3)]
        public int processInstanceId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 4)]
        public string usuario;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "documentDto[]", Order = 5)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public documentDto[] document;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "attachment[]", Order = 6)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public attachment[] attachments;

        public updateWorkflowAttachment()
        {
        }

        public updateWorkflowAttachment(string username, string password, int companyId, int processInstanceId, string usuario, documentDto[] document, attachment[] attachments)
        {
            this.username = username;
            this.password = password;
            this.companyId = companyId;
            this.processInstanceId = processInstanceId;
            this.usuario = usuario;
            this.document = document;
            this.attachments = attachments;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "updateWorkflowAttachmentResponse", WrapperNamespace = "http://ws.workflow.ecm.technology.totvs.com/", IsWrapped = true)]
    public partial class updateWorkflowAttachmentResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 0)]
        public string result;

        public updateWorkflowAttachmentResponse()
        {
        }

        public updateWorkflowAttachmentResponse(string result)
        {
            this.result = result;
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ws.workflow.ecm.technology.totvs.com/")]
    public partial class processHistoryDto
    {

        private bool activeField;

        private bool activeFieldSpecified;

        private long companyIdField;

        private int conversionSequenceField;

        private bool conversionSequenceFieldSpecified;

        private bool isReturnField;

        private bool isReturnFieldSpecified;

        private string labelActivityField;

        private string labelLinkField;

        private System.DateTime movementDateField;

        private bool movementDateFieldSpecified;

        private string movementHourField;

        private int movementSequenceField;

        private int previousMovementSequenceField;

        private bool previousMovementSequenceFieldSpecified;

        private int processInstanceIdField;

        private int stateSequenceField;

        private bool stateSequenceFieldSpecified;

        private int subProcessIdField;

        private bool subProcessIdFieldSpecified;

        private processTaskDto[] tasksField;

        private int threadSequenceField;

        private bool threadSequenceFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public bool active
        {
            get
            {
                return this.activeField;
            }
            set
            {
                this.activeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool activeSpecified
        {
            get
            {
                return this.activeFieldSpecified;
            }
            set
            {
                this.activeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public long companyId
        {
            get
            {
                return this.companyIdField;
            }
            set
            {
                this.companyIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public int conversionSequence
        {
            get
            {
                return this.conversionSequenceField;
            }
            set
            {
                this.conversionSequenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool conversionSequenceSpecified
        {
            get
            {
                return this.conversionSequenceFieldSpecified;
            }
            set
            {
                this.conversionSequenceFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public bool isReturn
        {
            get
            {
                return this.isReturnField;
            }
            set
            {
                this.isReturnField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isReturnSpecified
        {
            get
            {
                return this.isReturnFieldSpecified;
            }
            set
            {
                this.isReturnFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public string labelActivity
        {
            get
            {
                return this.labelActivityField;
            }
            set
            {
                this.labelActivityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public string labelLink
        {
            get
            {
                return this.labelLinkField;
            }
            set
            {
                this.labelLinkField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
        public System.DateTime movementDate
        {
            get
            {
                return this.movementDateField;
            }
            set
            {
                this.movementDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool movementDateSpecified
        {
            get
            {
                return this.movementDateFieldSpecified;
            }
            set
            {
                this.movementDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
        public string movementHour
        {
            get
            {
                return this.movementHourField;
            }
            set
            {
                this.movementHourField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 8)]
        public int movementSequence
        {
            get
            {
                return this.movementSequenceField;
            }
            set
            {
                this.movementSequenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 9)]
        public int previousMovementSequence
        {
            get
            {
                return this.previousMovementSequenceField;
            }
            set
            {
                this.previousMovementSequenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool previousMovementSequenceSpecified
        {
            get
            {
                return this.previousMovementSequenceFieldSpecified;
            }
            set
            {
                this.previousMovementSequenceFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 10)]
        public int processInstanceId
        {
            get
            {
                return this.processInstanceIdField;
            }
            set
            {
                this.processInstanceIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 11)]
        public int stateSequence
        {
            get
            {
                return this.stateSequenceField;
            }
            set
            {
                this.stateSequenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool stateSequenceSpecified
        {
            get
            {
                return this.stateSequenceFieldSpecified;
            }
            set
            {
                this.stateSequenceFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 12)]
        public int subProcessId
        {
            get
            {
                return this.subProcessIdField;
            }
            set
            {
                this.subProcessIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool subProcessIdSpecified
        {
            get
            {
                return this.subProcessIdFieldSpecified;
            }
            set
            {
                this.subProcessIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("tasks", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 13)]
        public processTaskDto[] tasks
        {
            get
            {
                return this.tasksField;
            }
            set
            {
                this.tasksField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 14)]
        public int threadSequence
        {
            get
            {
                return this.threadSequenceField;
            }
            set
            {
                this.threadSequenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool threadSequenceSpecified
        {
            get
            {
                return this.threadSequenceFieldSpecified;
            }
            set
            {
                this.threadSequenceFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ws.workflow.ecm.technology.totvs.com/")]
    public partial class processTaskDto
    {

        private bool activeField;

        private bool canCurrentUserTakeTaskField;

        private string choosedColleagueIdField;

        private int choosedSequenceField;

        private string colleagueIdField;

        private string colleagueNameField;

        private long companyIdField;

        private bool complementField;

        private string completeColleagueIdField;

        private int completeTypeField;

        private string deadlineTextField;

        private string historCompleteColleagueField;

        private string historTaskObservationField;

        private int movementSequenceField;

        private int processInstanceIdField;

        private int statusField;

        private int statusConsultField;

        private System.DateTime taskCompletionDateField;

        private bool taskCompletionDateFieldSpecified;

        private int taskCompletionHourField;

        private string taskObservationField;

        private bool taskSignedField;

        private int transferredSequenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public bool active
        {
            get
            {
                return this.activeField;
            }
            set
            {
                this.activeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public bool canCurrentUserTakeTask
        {
            get
            {
                return this.canCurrentUserTakeTaskField;
            }
            set
            {
                this.canCurrentUserTakeTaskField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string choosedColleagueId
        {
            get
            {
                return this.choosedColleagueIdField;
            }
            set
            {
                this.choosedColleagueIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public int choosedSequence
        {
            get
            {
                return this.choosedSequenceField;
            }
            set
            {
                this.choosedSequenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public string colleagueId
        {
            get
            {
                return this.colleagueIdField;
            }
            set
            {
                this.colleagueIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public string colleagueName
        {
            get
            {
                return this.colleagueNameField;
            }
            set
            {
                this.colleagueNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
        public long companyId
        {
            get
            {
                return this.companyIdField;
            }
            set
            {
                this.companyIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
        public bool complement
        {
            get
            {
                return this.complementField;
            }
            set
            {
                this.complementField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 8)]
        public string completeColleagueId
        {
            get
            {
                return this.completeColleagueIdField;
            }
            set
            {
                this.completeColleagueIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 9)]
        public int completeType
        {
            get
            {
                return this.completeTypeField;
            }
            set
            {
                this.completeTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 10)]
        public string deadlineText
        {
            get
            {
                return this.deadlineTextField;
            }
            set
            {
                this.deadlineTextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 11)]
        public string historCompleteColleague
        {
            get
            {
                return this.historCompleteColleagueField;
            }
            set
            {
                this.historCompleteColleagueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 12)]
        public string historTaskObservation
        {
            get
            {
                return this.historTaskObservationField;
            }
            set
            {
                this.historTaskObservationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 13)]
        public int movementSequence
        {
            get
            {
                return this.movementSequenceField;
            }
            set
            {
                this.movementSequenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 14)]
        public int processInstanceId
        {
            get
            {
                return this.processInstanceIdField;
            }
            set
            {
                this.processInstanceIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 15)]
        public int status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 16)]
        public int statusConsult
        {
            get
            {
                return this.statusConsultField;
            }
            set
            {
                this.statusConsultField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 17)]
        public System.DateTime taskCompletionDate
        {
            get
            {
                return this.taskCompletionDateField;
            }
            set
            {
                this.taskCompletionDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool taskCompletionDateSpecified
        {
            get
            {
                return this.taskCompletionDateFieldSpecified;
            }
            set
            {
                this.taskCompletionDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 18)]
        public int taskCompletionHour
        {
            get
            {
                return this.taskCompletionHourField;
            }
            set
            {
                this.taskCompletionHourField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 19)]
        public string taskObservation
        {
            get
            {
                return this.taskObservationField;
            }
            set
            {
                this.taskObservationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 20)]
        public bool taskSigned
        {
            get
            {
                return this.taskSignedField;
            }
            set
            {
                this.taskSignedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 21)]
        public int transferredSequence
        {
            get
            {
                return this.transferredSequenceField;
            }
            set
            {
                this.transferredSequenceField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "getHistories", WrapperNamespace = "http://ws.workflow.ecm.technology.totvs.com/", IsWrapped = true)]
    public partial class getHistories
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 0)]
        public string username;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 1)]
        public string password;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 2)]
        public int companyId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "string", Order = 3)]
        public string userId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "int", Order = 4)]
        public int processInstanceId;

        public getHistories()
        {
        }

        public getHistories(string username, string password, int companyId, string userId, int processInstanceId)
        {
            this.username = username;
            this.password = password;
            this.companyId = companyId;
            this.userId = userId;
            this.processInstanceId = processInstanceId;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "getHistoriesResponse", WrapperNamespace = "http://ws.workflow.ecm.technology.totvs.com/", IsWrapped = true)]
    public partial class getHistoriesResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "processHistoryDto[]", Order = 0)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public processHistoryDto[] Histories;

        public getHistoriesResponse()
        {
        }

        public getHistoriesResponse(processHistoryDto[] Histories)
        {
            this.Histories = Histories;
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    public interface WorkflowEngineServiceChannel : WorkflowEngineService, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    public partial class WorkflowEngineServiceClient : System.ServiceModel.ClientBase<WorkflowEngineService>, WorkflowEngineService
    {

        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);

        public WorkflowEngineServiceClient() :
                base(WorkflowEngineServiceClient.GetDefaultBinding(), WorkflowEngineServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.WorkflowEngineServicePort.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }

        public WorkflowEngineServiceClient(EndpointConfiguration endpointConfiguration) :
                base(WorkflowEngineServiceClient.GetBindingForEndpoint(endpointConfiguration), WorkflowEngineServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }

        public WorkflowEngineServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) :
                base(WorkflowEngineServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }

        public WorkflowEngineServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) :
                base(WorkflowEngineServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }

        public WorkflowEngineServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<importProcessResponse> WorkflowEngineService.importProcessAsync(importProcess request)
        {
            return base.Channel.importProcessAsync(request);
        }

        public System.Threading.Tasks.Task<importProcessResponse> importProcessAsync(string username, string password, int companyId, string processId, attachment[] attachments, bool newProcess, bool overWrite, string colleagueId)
        {
            importProcess inValue = new importProcess();
            inValue.username = username;
            inValue.password = password;
            inValue.companyId = companyId;
            inValue.processId = processId;
            inValue.attachments = attachments;
            inValue.newProcess = newProcess;
            inValue.overWrite = overWrite;
            inValue.colleagueId = colleagueId;
            return ((WorkflowEngineService)(this)).importProcessAsync(inValue);
        }

        public System.Threading.Tasks.Task<string> setDueDateAsync(string username, string password, int companyId, int processInstanceId, string userId, int threadSequence, string newDueDate, int timeInSecods)
        {
            return base.Channel.setDueDateAsync(username, password, companyId, processInstanceId, userId, threadSequence, newDueDate, timeInSecods);
        }

        public System.Threading.Tasks.Task<string> takeProcessTaskAsync(string username, string password, int companyId, string userId, int processInstanceId, int threadSequence)
        {
            return base.Channel.takeProcessTaskAsync(username, password, companyId, userId, processInstanceId, threadSequence);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<getInstanceCardDataResponse> WorkflowEngineService.getInstanceCardDataAsync(getInstanceCardData request)
        {
            return base.Channel.getInstanceCardDataAsync(request);
        }

        public System.Threading.Tasks.Task<getInstanceCardDataResponse> getInstanceCardDataAsync(string username, string password, int companyId, string userId, int processInstanceId)
        {
            getInstanceCardData inValue = new getInstanceCardData();
            inValue.username = username;
            inValue.password = password;
            inValue.companyId = companyId;
            inValue.userId = userId;
            inValue.processInstanceId = processInstanceId;
            return ((WorkflowEngineService)(this)).getInstanceCardDataAsync(inValue);
        }

        public System.Threading.Tasks.Task<string> createWorkFlowProcessVersionAsync(string username, string password, int companyId, string processId)
        {
            return base.Channel.createWorkFlowProcessVersionAsync(username, password, companyId, processId);
        }

        public System.Threading.Tasks.Task<string> getCardValueAsync(string username, string password, int companyId, int processInstanceId, string userId, string cardFieldName)
        {
            return base.Channel.getCardValueAsync(username, password, companyId, processInstanceId, userId, cardFieldName);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<getAllProcessAvailableToExportResponse> WorkflowEngineService.getAllProcessAvailableToExportAsync(getAllProcessAvailableToExport request)
        {
            return base.Channel.getAllProcessAvailableToExportAsync(request);
        }

        public System.Threading.Tasks.Task<getAllProcessAvailableToExportResponse> getAllProcessAvailableToExportAsync(string username, string password, int companyId)
        {
            getAllProcessAvailableToExport inValue = new getAllProcessAvailableToExport();
            inValue.username = username;
            inValue.password = password;
            inValue.companyId = companyId;
            return ((WorkflowEngineService)(this)).getAllProcessAvailableToExportAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<saveAndSendTaskResponse> WorkflowEngineService.saveAndSendTaskAsync(saveAndSendTask request)
        {
            return base.Channel.saveAndSendTaskAsync(request);
        }

        public System.Threading.Tasks.Task<saveAndSendTaskResponse> saveAndSendTaskAsync(string username, string password, int companyId, int processInstanceId, int choosedState, string[] colleagueIds, string comments, string userId, bool completeTask, processAttachmentDto[] attachments, string[][] cardData, processTaskAppointmentDto[] appointment, bool managerMode, int threadSequence)
        {
            saveAndSendTask inValue = new saveAndSendTask();
            inValue.username = username;
            inValue.password = password;
            inValue.companyId = companyId;
            inValue.processInstanceId = processInstanceId;
            inValue.choosedState = choosedState;
            inValue.colleagueIds = colleagueIds;
            inValue.comments = comments;
            inValue.userId = userId;
            inValue.completeTask = completeTask;
            inValue.attachments = attachments;
            inValue.cardData = cardData;
            inValue.appointment = appointment;
            inValue.managerMode = managerMode;
            inValue.threadSequence = threadSequence;
            return ((WorkflowEngineService)(this)).saveAndSendTaskAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<setAutomaticDecisionClassicResponse> WorkflowEngineService.setAutomaticDecisionClassicAsync(setAutomaticDecisionClassic request)
        {
            return base.Channel.setAutomaticDecisionClassicAsync(request);
        }

        public System.Threading.Tasks.Task<setAutomaticDecisionClassicResponse> setAutomaticDecisionClassicAsync(string username, string password, int companyId, int processInstanceId, int iTaskAutom, int iTask, int condition, string[] colleagueIds, string comments, string userId, bool managerMode, int threadSequence)
        {
            setAutomaticDecisionClassic inValue = new setAutomaticDecisionClassic();
            inValue.username = username;
            inValue.password = password;
            inValue.companyId = companyId;
            inValue.processInstanceId = processInstanceId;
            inValue.iTaskAutom = iTaskAutom;
            inValue.iTask = iTask;
            inValue.condition = condition;
            inValue.colleagueIds = colleagueIds;
            inValue.comments = comments;
            inValue.userId = userId;
            inValue.managerMode = managerMode;
            inValue.threadSequence = threadSequence;
            return ((WorkflowEngineService)(this)).setAutomaticDecisionClassicAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<importProcessWithCardAndRelatedDatasetsResponse> WorkflowEngineService.importProcessWithCardAndRelatedDatasetsAsync(importProcessWithCardAndRelatedDatasets request)
        {
            return base.Channel.importProcessWithCardAndRelatedDatasetsAsync(request);
        }

        public System.Threading.Tasks.Task<importProcessWithCardAndRelatedDatasetsResponse> importProcessWithCardAndRelatedDatasetsAsync(
                    string username,
                    string password,
                    int companyId,
                    string processId,
                    attachment[] processAttachs,
                    bool newProcess,
                    bool overWrite,
                    string colleagueId,
                    int parentDocumentId,
                    string documentDescription,
                    string cardDescription,
                    string datasetName,
                    attachment[] cardAttachs,
                    cardEventDto[] customEvents,
                    generalInfoDto generalInfo,
                    bool update,
                    int persistenceType,
                    string[] relatedDatasets)
        {
            importProcessWithCardAndRelatedDatasets inValue = new importProcessWithCardAndRelatedDatasets();
            inValue.username = username;
            inValue.password = password;
            inValue.companyId = companyId;
            inValue.processId = processId;
            inValue.processAttachs = processAttachs;
            inValue.newProcess = newProcess;
            inValue.overWrite = overWrite;
            inValue.colleagueId = colleagueId;
            inValue.parentDocumentId = parentDocumentId;
            inValue.documentDescription = documentDescription;
            inValue.cardDescription = cardDescription;
            inValue.datasetName = datasetName;
            inValue.cardAttachs = cardAttachs;
            inValue.customEvents = customEvents;
            inValue.generalInfo = generalInfo;
            inValue.update = update;
            inValue.persistenceType = persistenceType;
            inValue.relatedDatasets = relatedDatasets;
            return ((WorkflowEngineService)(this)).importProcessWithCardAndRelatedDatasetsAsync(inValue);
        }

        public System.Threading.Tasks.Task<deadLineDto> calculateDeadLineHoursAsync(string username, string password, int companyId, string userId, string data, int hora, int prazo, string periodId)
        {
            return base.Channel.calculateDeadLineHoursAsync(username, password, companyId, userId, data, hora, prazo, periodId);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<getAllProcessAvailableToImportResponse> WorkflowEngineService.getAllProcessAvailableToImportAsync(getAllProcessAvailableToImport request)
        {
            return base.Channel.getAllProcessAvailableToImportAsync(request);
        }

        public System.Threading.Tasks.Task<getAllProcessAvailableToImportResponse> getAllProcessAvailableToImportAsync(string username, string password, int companyId)
        {
            getAllProcessAvailableToImport inValue = new getAllProcessAvailableToImport();
            inValue.username = username;
            inValue.password = password;
            inValue.companyId = companyId;
            return ((WorkflowEngineService)(this)).getAllProcessAvailableToImportAsync(inValue);
        }

        public System.Threading.Tasks.Task<string> cancelInstanceAsync(string username, string password, int companyId, int processInstanceId, string userId, string cancelText)
        {
            return base.Channel.cancelInstanceAsync(username, password, companyId, processInstanceId, userId, cancelText);
        }

        public System.Threading.Tasks.Task<int> getActualThreadAsync(string username, string password, int companyId, int processInstanceId, int stateSequence)
        {
            return base.Channel.getActualThreadAsync(username, password, companyId, processInstanceId, stateSequence);
        }

        public System.Threading.Tasks.Task<int> getWorkFlowProcessVersionAsync(string username, string password, int companyId, string processId)
        {
            return base.Channel.getWorkFlowProcessVersionAsync(username, password, companyId, processId);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<getAvailableProcessOnDemandResponse> WorkflowEngineService.getAvailableProcessOnDemandAsync(getAvailableProcessOnDemand request)
        {
            return base.Channel.getAvailableProcessOnDemandAsync(request);
        }

        public System.Threading.Tasks.Task<getAvailableProcessOnDemandResponse> getAvailableProcessOnDemandAsync(string username, string password, int companyId, string userId, int limit, int lastRowId)
        {
            getAvailableProcessOnDemand inValue = new getAvailableProcessOnDemand();
            inValue.username = username;
            inValue.password = password;
            inValue.companyId = companyId;
            inValue.userId = userId;
            inValue.limit = limit;
            inValue.lastRowId = lastRowId;
            return ((WorkflowEngineService)(this)).getAvailableProcessOnDemandAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<getAvailableStatesDetailResponse> WorkflowEngineService.getAvailableStatesDetailAsync(getAvailableStatesDetail request)
        {
            return base.Channel.getAvailableStatesDetailAsync(request);
        }

        public System.Threading.Tasks.Task<getAvailableStatesDetailResponse> getAvailableStatesDetailAsync(string username, string password, int companyId, string processId, int processInstanceId, int threadSequence)
        {
            getAvailableStatesDetail inValue = new getAvailableStatesDetail();
            inValue.username = username;
            inValue.password = password;
            inValue.companyId = companyId;
            inValue.processId = processId;
            inValue.processInstanceId = processInstanceId;
            inValue.threadSequence = threadSequence;
            return ((WorkflowEngineService)(this)).getAvailableStatesDetailAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<exportProcessInZipFormatResponse> WorkflowEngineService.exportProcessInZipFormatAsync(exportProcessInZipFormat request)
        {
            return base.Channel.exportProcessInZipFormatAsync(request);
        }

        public System.Threading.Tasks.Task<exportProcessInZipFormatResponse> exportProcessInZipFormatAsync(string username, string password, int companyId, string processId)
        {
            exportProcessInZipFormat inValue = new exportProcessInZipFormat();
            inValue.username = username;
            inValue.password = password;
            inValue.companyId = companyId;
            inValue.processId = processId;
            return ((WorkflowEngineService)(this)).exportProcessInZipFormatAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<importProcessWithCardResponse> WorkflowEngineService.importProcessWithCardAsync(importProcessWithCard request)
        {
            return base.Channel.importProcessWithCardAsync(request);
        }

        public System.Threading.Tasks.Task<importProcessWithCardResponse> importProcessWithCardAsync(string username, string password, int companyId, string processId, attachment[] processAttachs, bool newProcess, bool overWrite, string colleagueId, int parentDocumentId, string documentDescription, string cardDescription, string datasetName, attachment[] cardAttachs, cardEventDto[] customEvents, bool update)
        {
            importProcessWithCard inValue = new importProcessWithCard();
            inValue.username = username;
            inValue.password = password;
            inValue.companyId = companyId;
            inValue.processId = processId;
            inValue.processAttachs = processAttachs;
            inValue.newProcess = newProcess;
            inValue.overWrite = overWrite;
            inValue.colleagueId = colleagueId;
            inValue.parentDocumentId = parentDocumentId;
            inValue.documentDescription = documentDescription;
            inValue.cardDescription = cardDescription;
            inValue.datasetName = datasetName;
            inValue.cardAttachs = cardAttachs;
            inValue.customEvents = customEvents;
            inValue.update = update;
            return ((WorkflowEngineService)(this)).importProcessWithCardAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<saveAndSendTaskByReplacementResponse> WorkflowEngineService.saveAndSendTaskByReplacementAsync(saveAndSendTaskByReplacement request)
        {
            return base.Channel.saveAndSendTaskByReplacementAsync(request);
        }

        public System.Threading.Tasks.Task<saveAndSendTaskByReplacementResponse> saveAndSendTaskByReplacementAsync(string username, string password, int companyId, int processInstanceId, int choosedState, string[] colleagueIds, string comments, string userId, bool completeTask, processAttachmentDto[] attachments, string[][] cardData, processTaskAppointmentDto[] appointment, bool managerMode, int threadSequence, string replacementId)
        {
            saveAndSendTaskByReplacement inValue = new saveAndSendTaskByReplacement();
            inValue.username = username;
            inValue.password = password;
            inValue.companyId = companyId;
            inValue.processInstanceId = processInstanceId;
            inValue.choosedState = choosedState;
            inValue.colleagueIds = colleagueIds;
            inValue.comments = comments;
            inValue.userId = userId;
            inValue.completeTask = completeTask;
            inValue.attachments = attachments;
            inValue.cardData = cardData;
            inValue.appointment = appointment;
            inValue.managerMode = managerMode;
            inValue.threadSequence = threadSequence;
            inValue.replacementId = replacementId;
            return ((WorkflowEngineService)(this)).saveAndSendTaskByReplacementAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<startProcessClassicResponse> WorkflowEngineService.startProcessClassicAsync(startProcessClassic request)
        {
            return base.Channel.startProcessClassicAsync(request);
        }

        public System.Threading.Tasks.Task<startProcessClassicResponse> startProcessClassicAsync(string username, string password, int companyId, string processId, int choosedState, string[] colleagueIds, string comments, string userId, bool completeTask, processAttachmentDto[] attachments, keyValueDto[] cardData, processTaskAppointmentDto[] appointment, bool managerMode)
        {
            startProcessClassic inValue = new startProcessClassic();
            inValue.username = username;
            inValue.password = password;
            inValue.companyId = companyId;
            inValue.processId = processId;
            inValue.choosedState = choosedState;
            inValue.colleagueIds = colleagueIds;
            inValue.comments = comments;
            inValue.userId = userId;
            inValue.completeTask = completeTask;
            inValue.attachments = attachments;
            inValue.cardData = cardData;
            inValue.appointment = appointment;
            inValue.managerMode = managerMode;
            return ((WorkflowEngineService)(this)).startProcessClassicAsync(inValue);
        }

        public System.Threading.Tasks.Task<string> cancelInstanceByReplacementAsync(string username, string password, int companyId, int processInstanceId, string userId, string cancelText, string replacementId)
        {
            return base.Channel.cancelInstanceByReplacementAsync(username, password, companyId, processInstanceId, userId, cancelText, replacementId);
        }

        public System.Threading.Tasks.Task<deadLineDto> calculateDeadLineTimeAsync(string username, string password, int companyId, string userId, string data, int hora, int prazo, string periodId)
        {
            return base.Channel.calculateDeadLineTimeAsync(username, password, companyId, userId, data, hora, prazo, periodId);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<simpleStartProcessResponse> WorkflowEngineService.simpleStartProcessAsync(simpleStartProcess request)
        {
            return base.Channel.simpleStartProcessAsync(request);
        }

        public System.Threading.Tasks.Task<simpleStartProcessResponse> simpleStartProcessAsync(string username, string password, int companyId, string processId, string comments, processAttachmentDto[] attachments, string[][] cardData)
        {
            simpleStartProcess inValue = new simpleStartProcess();
            inValue.username = username;
            inValue.password = password;
            inValue.companyId = companyId;
            inValue.processId = processId;
            inValue.comments = comments;
            inValue.attachments = attachments;
            inValue.cardData = cardData;
            return ((WorkflowEngineService)(this)).simpleStartProcessAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<getAvailableProcessResponse> WorkflowEngineService.getAvailableProcessAsync(getAvailableProcess request)
        {
            return base.Channel.getAvailableProcessAsync(request);
        }

        public System.Threading.Tasks.Task<getAvailableProcessResponse> getAvailableProcessAsync(string username, string password, int companyId, string userId)
        {
            getAvailableProcess inValue = new getAvailableProcess();
            inValue.username = username;
            inValue.password = password;
            inValue.companyId = companyId;
            inValue.userId = userId;
            return ((WorkflowEngineService)(this)).getAvailableProcessAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<startProcessResponse> WorkflowEngineService.startProcessAsync(startProcess request)
        {
            return base.Channel.startProcessAsync(request);
        }

        public System.Threading.Tasks.Task<startProcessResponse> startProcessAsync(string username, string password, int companyId, string processId, int choosedState, string[] colleagueIds, string comments, string userId, bool completeTask, processAttachmentDto[] attachments, string[][] cardData, processTaskAppointmentDto[] appointment, bool managerMode)
        {
            startProcess inValue = new startProcess();
            inValue.username = username;
            inValue.password = password;
            inValue.companyId = companyId;
            inValue.processId = processId;
            inValue.choosedState = choosedState;
            inValue.colleagueIds = colleagueIds;
            inValue.comments = comments;
            inValue.userId = userId;
            inValue.completeTask = completeTask;
            inValue.attachments = attachments;
            inValue.cardData = cardData;
            inValue.appointment = appointment;
            inValue.managerMode = managerMode;
            return ((WorkflowEngineService)(this)).startProcessAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<getAllActiveStatesResponse> WorkflowEngineService.getAllActiveStatesAsync(getAllActiveStates request)
        {
            return base.Channel.getAllActiveStatesAsync(request);
        }

        public System.Threading.Tasks.Task<getAllActiveStatesResponse> getAllActiveStatesAsync(string username, string password, int companyId, string userId, int processInstanceId)
        {
            getAllActiveStates inValue = new getAllActiveStates();
            inValue.username = username;
            inValue.password = password;
            inValue.companyId = companyId;
            inValue.userId = userId;
            inValue.processInstanceId = processInstanceId;
            return ((WorkflowEngineService)(this)).getAllActiveStatesAsync(inValue);
        }

        public System.Threading.Tasks.Task<string> releaseProcessAsync(string username, string password, int companyId, string processId)
        {
            return base.Channel.releaseProcessAsync(username, password, companyId, processId);
        }

        public System.Threading.Tasks.Task<string> setTasksCommentsAsync(string username, string password, int companyId, int processInstanceId, string userId, int threadSequence, string comments)
        {
            return base.Channel.setTasksCommentsAsync(username, password, companyId, processInstanceId, userId, threadSequence, comments);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<searchProcessResponse> WorkflowEngineService.searchProcessAsync(searchProcess request)
        {
            return base.Channel.searchProcessAsync(request);
        }

        public System.Threading.Tasks.Task<searchProcessResponse> searchProcessAsync(string username, string password, int companyId, string colleagueId, string content, bool favorite)
        {
            searchProcess inValue = new searchProcess();
            inValue.username = username;
            inValue.password = password;
            inValue.companyId = companyId;
            inValue.colleagueId = colleagueId;
            inValue.content = content;
            inValue.favorite = favorite;
            return ((WorkflowEngineService)(this)).searchProcessAsync(inValue);
        }

        public System.Threading.Tasks.Task<availableUsersDto> getAvailableUsersOnDemandAsync(string username, string password, int companyId, int processInstanceId, int state, int threadSequence, int limit, int initialUser, string userSearch)
        {
            return base.Channel.getAvailableUsersOnDemandAsync(username, password, companyId, processInstanceId, state, threadSequence, limit, initialUser, userSearch);
        }

        public System.Threading.Tasks.Task<int> getProcessFormIdAsync(string username, string password, int companyId, string processId)
        {
            return base.Channel.getProcessFormIdAsync(username, password, companyId, processId);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<saveAndSendTaskClassicResponse> WorkflowEngineService.saveAndSendTaskClassicAsync(saveAndSendTaskClassic request)
        {
            return base.Channel.saveAndSendTaskClassicAsync(request);
        }

        public System.Threading.Tasks.Task<saveAndSendTaskClassicResponse> saveAndSendTaskClassicAsync(string username, string password, int companyId, int processInstanceId, int choosedState, string[] colleagueIds, string comments, string userId, bool completeTask, processAttachmentDto[] attachments, keyValueDto[] cardData, processTaskAppointmentDto[] appointment, bool managerMode, int threadSequence)
        {
            saveAndSendTaskClassic inValue = new saveAndSendTaskClassic();
            inValue.username = username;
            inValue.password = password;
            inValue.companyId = companyId;
            inValue.processInstanceId = processInstanceId;
            inValue.choosedState = choosedState;
            inValue.colleagueIds = colleagueIds;
            inValue.comments = comments;
            inValue.userId = userId;
            inValue.completeTask = completeTask;
            inValue.attachments = attachments;
            inValue.cardData = cardData;
            inValue.appointment = appointment;
            inValue.managerMode = managerMode;
            inValue.threadSequence = threadSequence;
            return ((WorkflowEngineService)(this)).saveAndSendTaskClassicAsync(inValue);
        }

        public System.Threading.Tasks.Task<availableUsersDto> getAvailableUsersStartOnDemandAsync(string username, string password, int companyId, string processId, int state, int threadSequence, int limit, int initialUser, string userSearch)
        {
            return base.Channel.getAvailableUsersStartOnDemandAsync(username, password, companyId, processId, state, threadSequence, limit, initialUser, userSearch);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<getAvailableUsersResponse> WorkflowEngineService.getAvailableUsersAsync(getAvailableUsers request)
        {
            return base.Channel.getAvailableUsersAsync(request);
        }

        public System.Threading.Tasks.Task<getAvailableUsersResponse> getAvailableUsersAsync(string username, string password, int companyId, int processInstanceId, int state, int threadSequence)
        {
            getAvailableUsers inValue = new getAvailableUsers();
            inValue.username = username;
            inValue.password = password;
            inValue.companyId = companyId;
            inValue.processInstanceId = processInstanceId;
            inValue.state = state;
            inValue.threadSequence = threadSequence;
            return ((WorkflowEngineService)(this)).getAvailableUsersAsync(inValue);
        }

        public System.Threading.Tasks.Task<string> getProcessImageAsync(string username, string password, int companyId, string userId, string processId)
        {
            return base.Channel.getProcessImageAsync(username, password, companyId, userId, processId);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<getAttachmentsResponse> WorkflowEngineService.getAttachmentsAsync(getAttachments request)
        {
            return base.Channel.getAttachmentsAsync(request);
        }

        public System.Threading.Tasks.Task<getAttachmentsResponse> getAttachmentsAsync(string username, string password, int companyId, string userId, int processInstanceId)
        {
            getAttachments inValue = new getAttachments();
            inValue.username = username;
            inValue.password = password;
            inValue.companyId = companyId;
            inValue.userId = userId;
            inValue.processInstanceId = processInstanceId;
            return ((WorkflowEngineService)(this)).getAttachmentsAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<importProcessWithCardAndPersistenceTypeResponse> WorkflowEngineService.importProcessWithCardAndPersistenceTypeAsync(importProcessWithCardAndPersistenceType request)
        {
            return base.Channel.importProcessWithCardAndPersistenceTypeAsync(request);
        }

        public System.Threading.Tasks.Task<importProcessWithCardAndPersistenceTypeResponse> importProcessWithCardAndPersistenceTypeAsync(
                    string username,
                    string password,
                    int companyId,
                    string processId,
                    attachment[] processAttachs,
                    bool newProcess,
                    bool overWrite,
                    string colleagueId,
                    int parentDocumentId,
                    string documentDescription,
                    string cardDescription,
                    string datasetName,
                    attachment[] cardAttachs,
                    cardEventDto[] customEvents,
                    bool update,
                    int persistenceType)
        {
            importProcessWithCardAndPersistenceType inValue = new importProcessWithCardAndPersistenceType();
            inValue.username = username;
            inValue.password = password;
            inValue.companyId = companyId;
            inValue.processId = processId;
            inValue.processAttachs = processAttachs;
            inValue.newProcess = newProcess;
            inValue.overWrite = overWrite;
            inValue.colleagueId = colleagueId;
            inValue.parentDocumentId = parentDocumentId;
            inValue.documentDescription = documentDescription;
            inValue.cardDescription = cardDescription;
            inValue.datasetName = datasetName;
            inValue.cardAttachs = cardAttachs;
            inValue.customEvents = customEvents;
            inValue.update = update;
            inValue.persistenceType = persistenceType;
            return ((WorkflowEngineService)(this)).importProcessWithCardAndPersistenceTypeAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<getAvailableUsersStartResponse> WorkflowEngineService.getAvailableUsersStartAsync(getAvailableUsersStart request)
        {
            return base.Channel.getAvailableUsersStartAsync(request);
        }

        public System.Threading.Tasks.Task<getAvailableUsersStartResponse> getAvailableUsersStartAsync(string username, string password, int companyId, string processId, int state, int threadSequence)
        {
            getAvailableUsersStart inValue = new getAvailableUsersStart();
            inValue.username = username;
            inValue.password = password;
            inValue.companyId = companyId;
            inValue.processId = processId;
            inValue.state = state;
            inValue.threadSequence = threadSequence;
            return ((WorkflowEngineService)(this)).getAvailableUsersStartAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<importProcessWithCardAndGeneralInfoResponse> WorkflowEngineService.importProcessWithCardAndGeneralInfoAsync(importProcessWithCardAndGeneralInfo request)
        {
            return base.Channel.importProcessWithCardAndGeneralInfoAsync(request);
        }

        public System.Threading.Tasks.Task<importProcessWithCardAndGeneralInfoResponse> importProcessWithCardAndGeneralInfoAsync(
                    string username,
                    string password,
                    int companyId,
                    string processId,
                    attachment[] processAttachs,
                    bool newProcess,
                    bool overWrite,
                    string colleagueId,
                    int parentDocumentId,
                    string documentDescription,
                    string cardDescription,
                    string datasetName,
                    attachment[] cardAttachs,
                    cardEventDto[] customEvents,
                    generalInfoDto generalInfo,
                    bool update,
                    int persistenceType)
        {
            importProcessWithCardAndGeneralInfo inValue = new importProcessWithCardAndGeneralInfo();
            inValue.username = username;
            inValue.password = password;
            inValue.companyId = companyId;
            inValue.processId = processId;
            inValue.processAttachs = processAttachs;
            inValue.newProcess = newProcess;
            inValue.overWrite = overWrite;
            inValue.colleagueId = colleagueId;
            inValue.parentDocumentId = parentDocumentId;
            inValue.documentDescription = documentDescription;
            inValue.cardDescription = cardDescription;
            inValue.datasetName = datasetName;
            inValue.cardAttachs = cardAttachs;
            inValue.customEvents = customEvents;
            inValue.generalInfo = generalInfo;
            inValue.update = update;
            inValue.persistenceType = persistenceType;
            return ((WorkflowEngineService)(this)).importProcessWithCardAndGeneralInfoAsync(inValue);
        }

        public System.Threading.Tasks.Task<string> takeProcessTaskByReplacementAsync(string username, string password, int companyId, string userId, int processInstanceId, int threadSequence, string replacementId)
        {
            return base.Channel.takeProcessTaskByReplacementAsync(username, password, companyId, userId, processInstanceId, threadSequence, replacementId);
        }

        public System.Threading.Tasks.Task<string> exportProcessAsync(string username, string password, int companyId, string processId)
        {
            return base.Channel.exportProcessAsync(username, password, companyId, processId);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<getAvailableStatesResponse> WorkflowEngineService.getAvailableStatesAsync(getAvailableStates request)
        {
            return base.Channel.getAvailableStatesAsync(request);
        }

        public System.Threading.Tasks.Task<getAvailableStatesResponse> getAvailableStatesAsync(string username, string password, int companyId, string processId, int processInstanceId, int threadSequence)
        {
            getAvailableStates inValue = new getAvailableStates();
            inValue.username = username;
            inValue.password = password;
            inValue.companyId = companyId;
            inValue.processId = processId;
            inValue.processInstanceId = processInstanceId;
            inValue.threadSequence = threadSequence;
            return ((WorkflowEngineService)(this)).getAvailableStatesAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<updateWorkflowAttachmentResponse> WorkflowEngineService.updateWorkflowAttachmentAsync(updateWorkflowAttachment request)
        {
            return base.Channel.updateWorkflowAttachmentAsync(request);
        }

        public System.Threading.Tasks.Task<updateWorkflowAttachmentResponse> updateWorkflowAttachmentAsync(string username, string password, int companyId, int processInstanceId, string usuario, documentDto[] document, attachment[] attachments)
        {
            updateWorkflowAttachment inValue = new updateWorkflowAttachment();
            inValue.username = username;
            inValue.password = password;
            inValue.companyId = companyId;
            inValue.processInstanceId = processInstanceId;
            inValue.usuario = usuario;
            inValue.document = document;
            inValue.attachments = attachments;
            return ((WorkflowEngineService)(this)).updateWorkflowAttachmentAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<getHistoriesResponse> WorkflowEngineService.getHistoriesAsync(getHistories request)
        {
            return base.Channel.getHistoriesAsync(request);
        }

        public System.Threading.Tasks.Task<getHistoriesResponse> getHistoriesAsync(string username, string password, int companyId, string userId, int processInstanceId)
        {
            getHistories inValue = new getHistories();
            inValue.username = username;
            inValue.password = password;
            inValue.companyId = companyId;
            inValue.userId = userId;
            inValue.processInstanceId = processInstanceId;
            return ((WorkflowEngineService)(this)).getHistoriesAsync(inValue);
        }

        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }

        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }

        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.WorkflowEngineServicePort))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }

        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.WorkflowEngineServicePort))
            {
                return new System.ServiceModel.EndpointAddress("http://192.168.0.148:8080/webdesk/ECMWorkflowEngineService");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }

        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return WorkflowEngineServiceClient.GetBindingForEndpoint(EndpointConfiguration.WorkflowEngineServicePort);
        }

        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return WorkflowEngineServiceClient.GetEndpointAddress(EndpointConfiguration.WorkflowEngineServicePort);
        }

        public enum EndpointConfiguration
        {

            WorkflowEngineServicePort,
        }
    }
}