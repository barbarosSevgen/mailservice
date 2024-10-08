﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HEKOutlookCheckerServiceGroup
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CallContext", Namespace="http://schemas.microsoft.com/dynamics/2010/01/datacontracts")]
    public partial class CallContext : object
    {
        
        private string CompanyField;
        
        private string LanguageField;
        
        private string LogonAsUserField;
        
        private string MessageIdField;
        
        private string PartitionKeyField;
        
        private System.Collections.Generic.Dictionary<string, string> PropertyBagField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Company
        {
            get
            {
                return this.CompanyField;
            }
            set
            {
                this.CompanyField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Language
        {
            get
            {
                return this.LanguageField;
            }
            set
            {
                this.LanguageField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LogonAsUser
        {
            get
            {
                return this.LogonAsUserField;
            }
            set
            {
                this.LogonAsUserField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MessageId
        {
            get
            {
                return this.MessageIdField;
            }
            set
            {
                this.MessageIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PartitionKey
        {
            get
            {
                return this.PartitionKeyField;
            }
            set
            {
                this.PartitionKeyField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.Dictionary<string, string> PropertyBag
        {
            get
            {
                return this.PropertyBagField;
            }
            set
            {
                this.PropertyBagField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AifFault", Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
    public partial class AifFault : object
    {
        
        private string CustomDetailXmlField;
        
        private HEKOutlookCheckerServiceGroup.FaultMessageList[] FaultMessageListArrayField;
        
        private HEKOutlookCheckerServiceGroup.InfologMessage[] InfologMessageListField;
        
        private string StackTraceField;
        
        private int XppExceptionTypeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CustomDetailXml
        {
            get
            {
                return this.CustomDetailXmlField;
            }
            set
            {
                this.CustomDetailXmlField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HEKOutlookCheckerServiceGroup.FaultMessageList[] FaultMessageListArray
        {
            get
            {
                return this.FaultMessageListArrayField;
            }
            set
            {
                this.FaultMessageListArrayField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HEKOutlookCheckerServiceGroup.InfologMessage[] InfologMessageList
        {
            get
            {
                return this.InfologMessageListField;
            }
            set
            {
                this.InfologMessageListField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StackTrace
        {
            get
            {
                return this.StackTraceField;
            }
            set
            {
                this.StackTraceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int XppExceptionType
        {
            get
            {
                return this.XppExceptionTypeField;
            }
            set
            {
                this.XppExceptionTypeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FaultMessageList", Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
    public partial class FaultMessageList : object
    {
        
        private string DocumentField;
        
        private string DocumentOperationField;
        
        private HEKOutlookCheckerServiceGroup.FaultMessage[] FaultMessageArrayField;
        
        private string FieldField;
        
        private string ServiceField;
        
        private string ServiceOperationField;
        
        private string ServiceOperationParameterField;
        
        private string XPathField;
        
        private string XmlLineField;
        
        private string XmlPositionField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Document
        {
            get
            {
                return this.DocumentField;
            }
            set
            {
                this.DocumentField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DocumentOperation
        {
            get
            {
                return this.DocumentOperationField;
            }
            set
            {
                this.DocumentOperationField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HEKOutlookCheckerServiceGroup.FaultMessage[] FaultMessageArray
        {
            get
            {
                return this.FaultMessageArrayField;
            }
            set
            {
                this.FaultMessageArrayField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Field
        {
            get
            {
                return this.FieldField;
            }
            set
            {
                this.FieldField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Service
        {
            get
            {
                return this.ServiceField;
            }
            set
            {
                this.ServiceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ServiceOperation
        {
            get
            {
                return this.ServiceOperationField;
            }
            set
            {
                this.ServiceOperationField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ServiceOperationParameter
        {
            get
            {
                return this.ServiceOperationParameterField;
            }
            set
            {
                this.ServiceOperationParameterField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string XPath
        {
            get
            {
                return this.XPathField;
            }
            set
            {
                this.XPathField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string XmlLine
        {
            get
            {
                return this.XmlLineField;
            }
            set
            {
                this.XmlLineField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string XmlPosition
        {
            get
            {
                return this.XmlPositionField;
            }
            set
            {
                this.XmlPositionField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="InfologMessage", Namespace="http://schemas.datacontract.org/2004/07/Microsoft.Dynamics.AX.Framework.Services")]
    public partial class InfologMessage : object
    {
        
        private HEKOutlookCheckerServiceGroup.InfologMessageType InfologMessageTypeField;
        
        private string MessageField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HEKOutlookCheckerServiceGroup.InfologMessageType InfologMessageType
        {
            get
            {
                return this.InfologMessageTypeField;
            }
            set
            {
                this.InfologMessageTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message
        {
            get
            {
                return this.MessageField;
            }
            set
            {
                this.MessageField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FaultMessage", Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
    public partial class FaultMessage : object
    {
        
        private string CodeField;
        
        private string MessageField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Code
        {
            get
            {
                return this.CodeField;
            }
            set
            {
                this.CodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message
        {
            get
            {
                return this.MessageField;
            }
            set
            {
                this.MessageField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="InfologMessageType", Namespace="http://schemas.datacontract.org/2004/07/Microsoft.Dynamics.AX.Framework.Services")]
    public enum InfologMessageType : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Info = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Warning = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Error = 2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://tempuri.org", ConfigurationName="HEKOutlookCheckerServiceGroup.HEKOutlookCheckerService")]
    public interface HEKOutlookCheckerService
    {
        
        // CODEGEN: Generating message contract since the wrapper name (HEKOutlookCheckerServiceGetSetupTableRequest) of message HEKOutlookCheckerServiceGetSetupTableRequest does not match the default value (getSetupTable)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HEKOutlookCheckerService/getSetupTable", ReplyAction="http://tempuri.org/HEKOutlookCheckerService/getSetupTableResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(HEKOutlookCheckerServiceGroup.AifFault), Action="http://tempuri.org/HEKOutlookCheckerService/getSetupTableAifFaultFault", Name="AifFault", Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
        HEKOutlookCheckerServiceGroup.HEKOutlookCheckerServiceGetSetupTableResponse getSetupTable(HEKOutlookCheckerServiceGroup.HEKOutlookCheckerServiceGetSetupTableRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HEKOutlookCheckerService/getSetupTable", ReplyAction="http://tempuri.org/HEKOutlookCheckerService/getSetupTableResponse")]
        System.Threading.Tasks.Task<HEKOutlookCheckerServiceGroup.HEKOutlookCheckerServiceGetSetupTableResponse> getSetupTableAsync(HEKOutlookCheckerServiceGroup.HEKOutlookCheckerServiceGetSetupTableRequest request);
        
        // CODEGEN: Generating message contract since the wrapper name (HEKOutlookCheckerServiceInsertItemRequest) of message HEKOutlookCheckerServiceInsertItemRequest does not match the default value (insertItem)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HEKOutlookCheckerService/insertItem", ReplyAction="http://tempuri.org/HEKOutlookCheckerService/insertItemResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(HEKOutlookCheckerServiceGroup.AifFault), Action="http://tempuri.org/HEKOutlookCheckerService/insertItemAifFaultFault", Name="AifFault", Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
        HEKOutlookCheckerServiceGroup.HEKOutlookCheckerServiceInsertItemResponse insertItem(HEKOutlookCheckerServiceGroup.HEKOutlookCheckerServiceInsertItemRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HEKOutlookCheckerService/insertItem", ReplyAction="http://tempuri.org/HEKOutlookCheckerService/insertItemResponse")]
        System.Threading.Tasks.Task<HEKOutlookCheckerServiceGroup.HEKOutlookCheckerServiceInsertItemResponse> insertItemAsync(HEKOutlookCheckerServiceGroup.HEKOutlookCheckerServiceInsertItemRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="HEKOutlookCheckerServiceGetSetupTableRequest", WrapperNamespace="http://tempuri.org", IsWrapped=true)]
    public partial class HEKOutlookCheckerServiceGetSetupTableRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/dynamics/2010/01/datacontracts")]
        public HEKOutlookCheckerServiceGroup.CallContext CallContext;
        
        public HEKOutlookCheckerServiceGetSetupTableRequest()
        {
        }
        
        public HEKOutlookCheckerServiceGetSetupTableRequest(HEKOutlookCheckerServiceGroup.CallContext CallContext)
        {
            this.CallContext = CallContext;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="HEKOutlookCheckerServiceGetSetupTableResponse", WrapperNamespace="http://tempuri.org", IsWrapped=true)]
    public partial class HEKOutlookCheckerServiceGetSetupTableResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org", Order=0)]
        public string response;
        
        public HEKOutlookCheckerServiceGetSetupTableResponse()
        {
        }
        
        public HEKOutlookCheckerServiceGetSetupTableResponse(string response)
        {
            this.response = response;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="HEKOutlookCheckerServiceInsertItemRequest", WrapperNamespace="http://tempuri.org", IsWrapped=true)]
    public partial class HEKOutlookCheckerServiceInsertItemRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/dynamics/2010/01/datacontracts")]
        public HEKOutlookCheckerServiceGroup.CallContext CallContext;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org", Order=0)]
        public string _subject;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org", Order=1)]
        public string _from;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org", Order=2)]
        public string _to;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org", Order=3)]
        public string _cc;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org", Order=4)]
        public string _body;
        
        public HEKOutlookCheckerServiceInsertItemRequest()
        {
        }
        
        public HEKOutlookCheckerServiceInsertItemRequest(HEKOutlookCheckerServiceGroup.CallContext CallContext, string _subject, string _from, string _to, string _cc, string _body)
        {
            this.CallContext = CallContext;
            this._subject = _subject;
            this._from = _from;
            this._to = _to;
            this._cc = _cc;
            this._body = _body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="HEKOutlookCheckerServiceInsertItemResponse", WrapperNamespace="http://tempuri.org", IsWrapped=true)]
    public partial class HEKOutlookCheckerServiceInsertItemResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org", Order=0)]
        public string response;
        
        public HEKOutlookCheckerServiceInsertItemResponse()
        {
        }
        
        public HEKOutlookCheckerServiceInsertItemResponse(string response)
        {
            this.response = response;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface HEKOutlookCheckerServiceChannel : HEKOutlookCheckerServiceGroup.HEKOutlookCheckerService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class HEKOutlookCheckerServiceClient : System.ServiceModel.ClientBase<HEKOutlookCheckerServiceGroup.HEKOutlookCheckerService>, HEKOutlookCheckerServiceGroup.HEKOutlookCheckerService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public HEKOutlookCheckerServiceClient() : 
                base(HEKOutlookCheckerServiceClient.GetDefaultBinding(), HEKOutlookCheckerServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.NetTcpBinding_HEKOutlookCheckerService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public HEKOutlookCheckerServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(HEKOutlookCheckerServiceClient.GetBindingForEndpoint(endpointConfiguration), HEKOutlookCheckerServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public HEKOutlookCheckerServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(HEKOutlookCheckerServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public HEKOutlookCheckerServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(HEKOutlookCheckerServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public HEKOutlookCheckerServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        HEKOutlookCheckerServiceGroup.HEKOutlookCheckerServiceGetSetupTableResponse HEKOutlookCheckerServiceGroup.HEKOutlookCheckerService.getSetupTable(HEKOutlookCheckerServiceGroup.HEKOutlookCheckerServiceGetSetupTableRequest request)
        {
            return base.Channel.getSetupTable(request);
        }
        
        public string getSetupTable(HEKOutlookCheckerServiceGroup.CallContext CallContext)
        {
            HEKOutlookCheckerServiceGroup.HEKOutlookCheckerServiceGetSetupTableRequest inValue = new HEKOutlookCheckerServiceGroup.HEKOutlookCheckerServiceGetSetupTableRequest();
            inValue.CallContext = CallContext;
            HEKOutlookCheckerServiceGroup.HEKOutlookCheckerServiceGetSetupTableResponse retVal = ((HEKOutlookCheckerServiceGroup.HEKOutlookCheckerService)(this)).getSetupTable(inValue);
            return retVal.response;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<HEKOutlookCheckerServiceGroup.HEKOutlookCheckerServiceGetSetupTableResponse> HEKOutlookCheckerServiceGroup.HEKOutlookCheckerService.getSetupTableAsync(HEKOutlookCheckerServiceGroup.HEKOutlookCheckerServiceGetSetupTableRequest request)
        {
            return base.Channel.getSetupTableAsync(request);
        }
        
        public System.Threading.Tasks.Task<HEKOutlookCheckerServiceGroup.HEKOutlookCheckerServiceGetSetupTableResponse> getSetupTableAsync(HEKOutlookCheckerServiceGroup.CallContext CallContext)
        {
            HEKOutlookCheckerServiceGroup.HEKOutlookCheckerServiceGetSetupTableRequest inValue = new HEKOutlookCheckerServiceGroup.HEKOutlookCheckerServiceGetSetupTableRequest();
            inValue.CallContext = CallContext;
            return ((HEKOutlookCheckerServiceGroup.HEKOutlookCheckerService)(this)).getSetupTableAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        HEKOutlookCheckerServiceGroup.HEKOutlookCheckerServiceInsertItemResponse HEKOutlookCheckerServiceGroup.HEKOutlookCheckerService.insertItem(HEKOutlookCheckerServiceGroup.HEKOutlookCheckerServiceInsertItemRequest request)
        {
            return base.Channel.insertItem(request);
        }
        
        public string insertItem(HEKOutlookCheckerServiceGroup.CallContext CallContext, string _subject, string _from, string _to, string _cc, string _body)
        {
            HEKOutlookCheckerServiceGroup.HEKOutlookCheckerServiceInsertItemRequest inValue = new HEKOutlookCheckerServiceGroup.HEKOutlookCheckerServiceInsertItemRequest();
            inValue.CallContext = CallContext;
            inValue._subject = _subject;
            inValue._from = _from;
            inValue._to = _to;
            inValue._cc = _cc;
            inValue._body = _body;
            HEKOutlookCheckerServiceGroup.HEKOutlookCheckerServiceInsertItemResponse retVal = ((HEKOutlookCheckerServiceGroup.HEKOutlookCheckerService)(this)).insertItem(inValue);
            return retVal.response;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<HEKOutlookCheckerServiceGroup.HEKOutlookCheckerServiceInsertItemResponse> HEKOutlookCheckerServiceGroup.HEKOutlookCheckerService.insertItemAsync(HEKOutlookCheckerServiceGroup.HEKOutlookCheckerServiceInsertItemRequest request)
        {
            return base.Channel.insertItemAsync(request);
        }
        
        public System.Threading.Tasks.Task<HEKOutlookCheckerServiceGroup.HEKOutlookCheckerServiceInsertItemResponse> insertItemAsync(HEKOutlookCheckerServiceGroup.CallContext CallContext, string _subject, string _from, string _to, string _cc, string _body)
        {
            HEKOutlookCheckerServiceGroup.HEKOutlookCheckerServiceInsertItemRequest inValue = new HEKOutlookCheckerServiceGroup.HEKOutlookCheckerServiceInsertItemRequest();
            inValue.CallContext = CallContext;
            inValue._subject = _subject;
            inValue._from = _from;
            inValue._to = _to;
            inValue._cc = _cc;
            inValue._body = _body;
            return ((HEKOutlookCheckerServiceGroup.HEKOutlookCheckerService)(this)).insertItemAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.NetTcpBinding_HEKOutlookCheckerService))
            {
                System.ServiceModel.NetTcpBinding result = new System.ServiceModel.NetTcpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.NetTcpBinding_HEKOutlookCheckerService))
            {
                return new System.ServiceModel.EndpointAddress("net.tcp://srvsql2012dev:8201/DynamicsAx/Services/HEKOutlookCheckerServiceGroup");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return HEKOutlookCheckerServiceClient.GetBindingForEndpoint(EndpointConfiguration.NetTcpBinding_HEKOutlookCheckerService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return HEKOutlookCheckerServiceClient.GetEndpointAddress(EndpointConfiguration.NetTcpBinding_HEKOutlookCheckerService);
        }
        
        public enum EndpointConfiguration
        {
            
            NetTcpBinding_HEKOutlookCheckerService,
        }
    }
}
