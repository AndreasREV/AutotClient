﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AutotClient.AutoPalvelu {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Auto", Namespace="http://schemas.datacontract.org/2004/07/WCFautot")]
    [System.SerializableAttribute()]
    public partial class Auto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AutonmalliIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AutonmerkkiIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal HintaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MittarilukemaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal Moottorin_tilavuusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PolttoaineIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Rekisteri_PaivamaaraField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int VaritIDField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int AutonmalliID {
            get {
                return this.AutonmalliIDField;
            }
            set {
                if ((this.AutonmalliIDField.Equals(value) != true)) {
                    this.AutonmalliIDField = value;
                    this.RaisePropertyChanged("AutonmalliID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int AutonmerkkiID {
            get {
                return this.AutonmerkkiIDField;
            }
            set {
                if ((this.AutonmerkkiIDField.Equals(value) != true)) {
                    this.AutonmerkkiIDField = value;
                    this.RaisePropertyChanged("AutonmerkkiID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Hinta {
            get {
                return this.HintaField;
            }
            set {
                if ((this.HintaField.Equals(value) != true)) {
                    this.HintaField = value;
                    this.RaisePropertyChanged("Hinta");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Mittarilukema {
            get {
                return this.MittarilukemaField;
            }
            set {
                if ((this.MittarilukemaField.Equals(value) != true)) {
                    this.MittarilukemaField = value;
                    this.RaisePropertyChanged("Mittarilukema");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Moottorin_tilavuus {
            get {
                return this.Moottorin_tilavuusField;
            }
            set {
                if ((this.Moottorin_tilavuusField.Equals(value) != true)) {
                    this.Moottorin_tilavuusField = value;
                    this.RaisePropertyChanged("Moottorin_tilavuus");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PolttoaineID {
            get {
                return this.PolttoaineIDField;
            }
            set {
                if ((this.PolttoaineIDField.Equals(value) != true)) {
                    this.PolttoaineIDField = value;
                    this.RaisePropertyChanged("PolttoaineID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Rekisteri_Paivamaara {
            get {
                return this.Rekisteri_PaivamaaraField;
            }
            set {
                if ((this.Rekisteri_PaivamaaraField.Equals(value) != true)) {
                    this.Rekisteri_PaivamaaraField = value;
                    this.RaisePropertyChanged("Rekisteri_Paivamaara");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int VaritID {
            get {
                return this.VaritIDField;
            }
            set {
                if ((this.VaritIDField.Equals(value) != true)) {
                    this.VaritIDField = value;
                    this.RaisePropertyChanged("VaritID");
                }
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Autonmerkki", Namespace="http://schemas.datacontract.org/2004/07/WCFautot")]
    [System.SerializableAttribute()]
    public partial class Autonmerkki : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string merkkinimiField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string merkkinimi {
            get {
                return this.merkkinimiField;
            }
            set {
                if ((object.ReferenceEquals(this.merkkinimiField, value) != true)) {
                    this.merkkinimiField = value;
                    this.RaisePropertyChanged("merkkinimi");
                }
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Autonmallit", Namespace="http://schemas.datacontract.org/2004/07/WCFautot")]
    [System.SerializableAttribute()]
    public partial class Autonmallit : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string mallinimiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string merkkiidField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string mallinimi {
            get {
                return this.mallinimiField;
            }
            set {
                if ((object.ReferenceEquals(this.mallinimiField, value) != true)) {
                    this.mallinimiField = value;
                    this.RaisePropertyChanged("mallinimi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string merkkiid {
            get {
                return this.merkkiidField;
            }
            set {
                if ((object.ReferenceEquals(this.merkkiidField, value) != true)) {
                    this.merkkiidField = value;
                    this.RaisePropertyChanged("merkkiid");
                }
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Varit", Namespace="http://schemas.datacontract.org/2004/07/WCFautot")]
    [System.SerializableAttribute()]
    public partial class Varit : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Varin_nimiField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Varin_nimi {
            get {
                return this.Varin_nimiField;
            }
            set {
                if ((object.ReferenceEquals(this.Varin_nimiField, value) != true)) {
                    this.Varin_nimiField = value;
                    this.RaisePropertyChanged("Varin_nimi");
                }
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Polttoaine", Namespace="http://schemas.datacontract.org/2004/07/WCFautot")]
    [System.SerializableAttribute()]
    public partial class Polttoaine : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Polttoaineen_nimiField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Polttoaineen_nimi {
            get {
                return this.Polttoaineen_nimiField;
            }
            set {
                if ((object.ReferenceEquals(this.Polttoaineen_nimiField, value) != true)) {
                    this.Polttoaineen_nimiField = value;
                    this.RaisePropertyChanged("Polttoaineen_nimi");
                }
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AutoPalvelu.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/TestDatabaseConnection", ReplyAction="http://tempuri.org/IService1/TestDatabaseConnectionResponse")]
        bool TestDatabaseConnection();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/TestDatabaseConnection", ReplyAction="http://tempuri.org/IService1/TestDatabaseConnectionResponse")]
        System.Threading.Tasks.Task<bool> TestDatabaseConnectionAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/saveAuto", ReplyAction="http://tempuri.org/IService1/saveAutoResponse")]
        bool saveAuto(AutotClient.AutoPalvelu.Auto newAuto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/saveAuto", ReplyAction="http://tempuri.org/IService1/saveAutoResponse")]
        System.Threading.Tasks.Task<bool> saveAutoAsync(AutotClient.AutoPalvelu.Auto newAuto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getAutoMakers", ReplyAction="http://tempuri.org/IService1/getAutoMakersResponse")]
        System.Collections.Generic.List<AutotClient.AutoPalvelu.Autonmerkki> getAutoMakers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getAutoMakers", ReplyAction="http://tempuri.org/IService1/getAutoMakersResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<AutotClient.AutoPalvelu.Autonmerkki>> getAutoMakersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAutonmallits", ReplyAction="http://tempuri.org/IService1/GetAutonmallitsResponse")]
        System.Collections.Generic.List<AutotClient.AutoPalvelu.Autonmallit> GetAutonmallits(int merkkiID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAutonmallits", ReplyAction="http://tempuri.org/IService1/GetAutonmallitsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<AutotClient.AutoPalvelu.Autonmallit>> GetAutonmallitsAsync(int merkkiID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetVarits", ReplyAction="http://tempuri.org/IService1/GetVaritsResponse")]
        System.Collections.Generic.List<AutotClient.AutoPalvelu.Varit> GetVarits();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetVarits", ReplyAction="http://tempuri.org/IService1/GetVaritsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<AutotClient.AutoPalvelu.Varit>> GetVaritsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetPolttoaines", ReplyAction="http://tempuri.org/IService1/GetPolttoainesResponse")]
        System.Collections.Generic.List<AutotClient.AutoPalvelu.Polttoaine> GetPolttoaines();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetPolttoaines", ReplyAction="http://tempuri.org/IService1/GetPolttoainesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<AutotClient.AutoPalvelu.Polttoaine>> GetPolttoainesAsync();
        
        // CODEGEN: Generating message contract since the wrapper name (SaveAuto) of message SaveAutoRequest does not match the default value (SaveAuto1)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SaveAuto", ReplyAction="http://tempuri.org/IService1/SaveAutoResponse")]
        AutotClient.AutoPalvelu.SaveAutoResponse SaveAuto1(AutotClient.AutoPalvelu.SaveAutoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SaveAuto", ReplyAction="http://tempuri.org/IService1/SaveAutoResponse")]
        System.Threading.Tasks.Task<AutotClient.AutoPalvelu.SaveAutoResponse> SaveAuto1Async(AutotClient.AutoPalvelu.SaveAutoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/NextCars", ReplyAction="http://tempuri.org/IService1/NextCarsResponse")]
        AutotClient.AutoPalvelu.Auto NextCars(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/NextCars", ReplyAction="http://tempuri.org/IService1/NextCarsResponse")]
        System.Threading.Tasks.Task<AutotClient.AutoPalvelu.Auto> NextCarsAsync(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PreviousCars", ReplyAction="http://tempuri.org/IService1/PreviousCarsResponse")]
        AutotClient.AutoPalvelu.Auto PreviousCars(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PreviousCars", ReplyAction="http://tempuri.org/IService1/PreviousCarsResponse")]
        System.Threading.Tasks.Task<AutotClient.AutoPalvelu.Auto> PreviousCarsAsync(int ID);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SaveAuto", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SaveAutoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public AutotClient.AutoPalvelu.Auto pirssi;
        
        public SaveAutoRequest() {
        }
        
        public SaveAutoRequest(AutotClient.AutoPalvelu.Auto pirssi) {
            this.pirssi = pirssi;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SaveAutoResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SaveAutoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public bool SaveAutoResult;
        
        public SaveAutoResponse() {
        }
        
        public SaveAutoResponse(bool SaveAutoResult) {
            this.SaveAutoResult = SaveAutoResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : AutotClient.AutoPalvelu.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<AutotClient.AutoPalvelu.IService1>, AutotClient.AutoPalvelu.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool TestDatabaseConnection() {
            return base.Channel.TestDatabaseConnection();
        }
        
        public System.Threading.Tasks.Task<bool> TestDatabaseConnectionAsync() {
            return base.Channel.TestDatabaseConnectionAsync();
        }
        
        public bool saveAuto(AutotClient.AutoPalvelu.Auto newAuto) {
            return base.Channel.saveAuto(newAuto);
        }
        
        public System.Threading.Tasks.Task<bool> saveAutoAsync(AutotClient.AutoPalvelu.Auto newAuto) {
            return base.Channel.saveAutoAsync(newAuto);
        }
        
        public System.Collections.Generic.List<AutotClient.AutoPalvelu.Autonmerkki> getAutoMakers() {
            return base.Channel.getAutoMakers();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<AutotClient.AutoPalvelu.Autonmerkki>> getAutoMakersAsync() {
            return base.Channel.getAutoMakersAsync();
        }
        
        public System.Collections.Generic.List<AutotClient.AutoPalvelu.Autonmallit> GetAutonmallits(int merkkiID) {
            return base.Channel.GetAutonmallits(merkkiID);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<AutotClient.AutoPalvelu.Autonmallit>> GetAutonmallitsAsync(int merkkiID) {
            return base.Channel.GetAutonmallitsAsync(merkkiID);
        }
        
        public System.Collections.Generic.List<AutotClient.AutoPalvelu.Varit> GetVarits() {
            return base.Channel.GetVarits();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<AutotClient.AutoPalvelu.Varit>> GetVaritsAsync() {
            return base.Channel.GetVaritsAsync();
        }
        
        public System.Collections.Generic.List<AutotClient.AutoPalvelu.Polttoaine> GetPolttoaines() {
            return base.Channel.GetPolttoaines();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<AutotClient.AutoPalvelu.Polttoaine>> GetPolttoainesAsync() {
            return base.Channel.GetPolttoainesAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AutotClient.AutoPalvelu.SaveAutoResponse AutotClient.AutoPalvelu.IService1.SaveAuto1(AutotClient.AutoPalvelu.SaveAutoRequest request) {
            return base.Channel.SaveAuto1(request);
        }
        
        public bool SaveAuto1(AutotClient.AutoPalvelu.Auto pirssi) {
            AutotClient.AutoPalvelu.SaveAutoRequest inValue = new AutotClient.AutoPalvelu.SaveAutoRequest();
            inValue.pirssi = pirssi;
            AutotClient.AutoPalvelu.SaveAutoResponse retVal = ((AutotClient.AutoPalvelu.IService1)(this)).SaveAuto1(inValue);
            return retVal.SaveAutoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AutotClient.AutoPalvelu.SaveAutoResponse> AutotClient.AutoPalvelu.IService1.SaveAuto1Async(AutotClient.AutoPalvelu.SaveAutoRequest request) {
            return base.Channel.SaveAuto1Async(request);
        }
        
        public System.Threading.Tasks.Task<AutotClient.AutoPalvelu.SaveAutoResponse> SaveAuto1Async(AutotClient.AutoPalvelu.Auto pirssi) {
            AutotClient.AutoPalvelu.SaveAutoRequest inValue = new AutotClient.AutoPalvelu.SaveAutoRequest();
            inValue.pirssi = pirssi;
            return ((AutotClient.AutoPalvelu.IService1)(this)).SaveAuto1Async(inValue);
        }
        
        public AutotClient.AutoPalvelu.Auto NextCars(int ID) {
            return base.Channel.NextCars(ID);
        }
        
        public System.Threading.Tasks.Task<AutotClient.AutoPalvelu.Auto> NextCarsAsync(int ID) {
            return base.Channel.NextCarsAsync(ID);
        }
        
        public AutotClient.AutoPalvelu.Auto PreviousCars(int ID) {
            return base.Channel.PreviousCars(ID);
        }
        
        public System.Threading.Tasks.Task<AutotClient.AutoPalvelu.Auto> PreviousCarsAsync(int ID) {
            return base.Channel.PreviousCarsAsync(ID);
        }
    }
}
