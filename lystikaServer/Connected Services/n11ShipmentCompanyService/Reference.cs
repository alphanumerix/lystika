﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:4.0.30319.42000
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lystikaServer.n11ShipmentCompanyService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.n11.com/ws/schemas", ConfigurationName="n11ShipmentCompanyService.ShipmentCompanyServicePort")]
    public interface ShipmentCompanyServicePort {
        
        // CODEGEN: GetShipmentCompanies işlemi RPC ya da belge kaydırmalı olmadığından, ileti sözleşmesi oluşturuluyor.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        lystikaServer.n11ShipmentCompanyService.GetShipmentCompaniesResponse1 GetShipmentCompanies(lystikaServer.n11ShipmentCompanyService.GetShipmentCompaniesRequest1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<lystikaServer.n11ShipmentCompanyService.GetShipmentCompaniesResponse1> GetShipmentCompaniesAsync(lystikaServer.n11ShipmentCompanyService.GetShipmentCompaniesRequest1 request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.n11.com/ws/schemas")]
    public partial class GetShipmentCompaniesRequest : object, System.ComponentModel.INotifyPropertyChanged {
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.n11.com/ws/schemas")]
    public partial class ShipmentCompanyData : object, System.ComponentModel.INotifyPropertyChanged {
        
        private long idField;
        
        private string nameField;
        
        private string shortNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public long id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("id");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
                this.RaisePropertyChanged("name");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string shortName {
            get {
                return this.shortNameField;
            }
            set {
                this.shortNameField = value;
                this.RaisePropertyChanged("shortName");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.n11.com/ws/schemas")]
    public partial class ResultInfo : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string statusField;
        
        private string errorCodeField;
        
        private string errorMessageField;
        
        private string errorCategoryField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=0)]
        public string status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
                this.RaisePropertyChanged("status");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=1)]
        public string errorCode {
            get {
                return this.errorCodeField;
            }
            set {
                this.errorCodeField = value;
                this.RaisePropertyChanged("errorCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=2)]
        public string errorMessage {
            get {
                return this.errorMessageField;
            }
            set {
                this.errorMessageField = value;
                this.RaisePropertyChanged("errorMessage");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=3)]
        public string errorCategory {
            get {
                return this.errorCategoryField;
            }
            set {
                this.errorCategoryField = value;
                this.RaisePropertyChanged("errorCategory");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.n11.com/ws/schemas")]
    public partial class GetShipmentCompaniesResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private ResultInfo resultField;
        
        private ShipmentCompanyData[] shipmentCompaniesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public ResultInfo result {
            get {
                return this.resultField;
            }
            set {
                this.resultField = value;
                this.RaisePropertyChanged("result");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("shipmentCompany", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public ShipmentCompanyData[] shipmentCompanies {
            get {
                return this.shipmentCompaniesField;
            }
            set {
                this.shipmentCompaniesField = value;
                this.RaisePropertyChanged("shipmentCompanies");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetShipmentCompaniesRequest1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.n11.com/ws/schemas", Order=0)]
        public lystikaServer.n11ShipmentCompanyService.GetShipmentCompaniesRequest GetShipmentCompaniesRequest;
        
        public GetShipmentCompaniesRequest1() {
        }
        
        public GetShipmentCompaniesRequest1(lystikaServer.n11ShipmentCompanyService.GetShipmentCompaniesRequest GetShipmentCompaniesRequest) {
            this.GetShipmentCompaniesRequest = GetShipmentCompaniesRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetShipmentCompaniesResponse1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.n11.com/ws/schemas", Order=0)]
        public lystikaServer.n11ShipmentCompanyService.GetShipmentCompaniesResponse GetShipmentCompaniesResponse;
        
        public GetShipmentCompaniesResponse1() {
        }
        
        public GetShipmentCompaniesResponse1(lystikaServer.n11ShipmentCompanyService.GetShipmentCompaniesResponse GetShipmentCompaniesResponse) {
            this.GetShipmentCompaniesResponse = GetShipmentCompaniesResponse;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ShipmentCompanyServicePortChannel : lystikaServer.n11ShipmentCompanyService.ShipmentCompanyServicePort, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ShipmentCompanyServicePortClient : System.ServiceModel.ClientBase<lystikaServer.n11ShipmentCompanyService.ShipmentCompanyServicePort>, lystikaServer.n11ShipmentCompanyService.ShipmentCompanyServicePort {
        
        public ShipmentCompanyServicePortClient() {
        }
        
        public ShipmentCompanyServicePortClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ShipmentCompanyServicePortClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ShipmentCompanyServicePortClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ShipmentCompanyServicePortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        lystikaServer.n11ShipmentCompanyService.GetShipmentCompaniesResponse1 lystikaServer.n11ShipmentCompanyService.ShipmentCompanyServicePort.GetShipmentCompanies(lystikaServer.n11ShipmentCompanyService.GetShipmentCompaniesRequest1 request) {
            return base.Channel.GetShipmentCompanies(request);
        }
        
        public lystikaServer.n11ShipmentCompanyService.GetShipmentCompaniesResponse GetShipmentCompanies(lystikaServer.n11ShipmentCompanyService.GetShipmentCompaniesRequest GetShipmentCompaniesRequest) {
            lystikaServer.n11ShipmentCompanyService.GetShipmentCompaniesRequest1 inValue = new lystikaServer.n11ShipmentCompanyService.GetShipmentCompaniesRequest1();
            inValue.GetShipmentCompaniesRequest = GetShipmentCompaniesRequest;
            lystikaServer.n11ShipmentCompanyService.GetShipmentCompaniesResponse1 retVal = ((lystikaServer.n11ShipmentCompanyService.ShipmentCompanyServicePort)(this)).GetShipmentCompanies(inValue);
            return retVal.GetShipmentCompaniesResponse;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<lystikaServer.n11ShipmentCompanyService.GetShipmentCompaniesResponse1> lystikaServer.n11ShipmentCompanyService.ShipmentCompanyServicePort.GetShipmentCompaniesAsync(lystikaServer.n11ShipmentCompanyService.GetShipmentCompaniesRequest1 request) {
            return base.Channel.GetShipmentCompaniesAsync(request);
        }
        
        public System.Threading.Tasks.Task<lystikaServer.n11ShipmentCompanyService.GetShipmentCompaniesResponse1> GetShipmentCompaniesAsync(lystikaServer.n11ShipmentCompanyService.GetShipmentCompaniesRequest GetShipmentCompaniesRequest) {
            lystikaServer.n11ShipmentCompanyService.GetShipmentCompaniesRequest1 inValue = new lystikaServer.n11ShipmentCompanyService.GetShipmentCompaniesRequest1();
            inValue.GetShipmentCompaniesRequest = GetShipmentCompaniesRequest;
            return ((lystikaServer.n11ShipmentCompanyService.ShipmentCompanyServicePort)(this)).GetShipmentCompaniesAsync(inValue);
        }
    }
}
