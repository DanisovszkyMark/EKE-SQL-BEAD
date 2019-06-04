﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFService_host.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserRecord", Namespace="http://schemas.datacontract.org/2004/07/WCFService.DatabaseManagers.Records")]
    [System.SerializableAttribute()]
    public partial class UserRecord : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool LoggedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
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
        public bool Logged {
            get {
                return this.LoggedField;
            }
            set {
                if ((this.LoggedField.Equals(value) != true)) {
                    this.LoggedField = value;
                    this.RaisePropertyChanged("Logged");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ServiceData", Namespace="http://schemas.datacontract.org/2004/07/WCFService")]
    [System.SerializableAttribute()]
    public partial class ServiceData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorDetailsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorMessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool ResultField;
        
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
        public string ErrorDetails {
            get {
                return this.ErrorDetailsField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorDetailsField, value) != true)) {
                    this.ErrorDetailsField = value;
                    this.RaisePropertyChanged("ErrorDetails");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ErrorMessage {
            get {
                return this.ErrorMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorMessageField, value) != true)) {
                    this.ErrorMessageField = value;
                    this.RaisePropertyChanged("ErrorMessage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Result {
            get {
                return this.ResultField;
            }
            set {
                if ((this.ResultField.Equals(value) != true)) {
                    this.ResultField = value;
                    this.RaisePropertyChanged("Result");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="PersonRecord", Namespace="http://schemas.datacontract.org/2004/07/WCFService.DatabaseManagers.Records")]
    [System.SerializableAttribute()]
    public partial class PersonRecord : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Birt_dayField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Job_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> SalaryField;
        
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
        public System.DateTime Birt_day {
            get {
                return this.Birt_dayField;
            }
            set {
                if ((this.Birt_dayField.Equals(value) != true)) {
                    this.Birt_dayField = value;
                    this.RaisePropertyChanged("Birt_day");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Job_id {
            get {
                return this.Job_idField;
            }
            set {
                if ((this.Job_idField.Equals(value) != true)) {
                    this.Job_idField = value;
                    this.RaisePropertyChanged("Job_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Salary {
            get {
                return this.SalaryField;
            }
            set {
                if ((this.SalaryField.Equals(value) != true)) {
                    this.SalaryField = value;
                    this.RaisePropertyChanged("Salary");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SelectAllUser", ReplyAction="http://tempuri.org/IService/SelectAllUserResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WCFService_host.ServiceReference1.ServiceData), Action="http://tempuri.org/IService/SelectAllUserServiceDataFault", Name="ServiceData", Namespace="http://schemas.datacontract.org/2004/07/WCFService")]
        WCFService_host.ServiceReference1.UserRecord[] SelectAllUser();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SelectAllUser", ReplyAction="http://tempuri.org/IService/SelectAllUserResponse")]
        System.Threading.Tasks.Task<WCFService_host.ServiceReference1.UserRecord[]> SelectAllUserAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/InsertUser", ReplyAction="http://tempuri.org/IService/InsertUserResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WCFService_host.ServiceReference1.ServiceData), Action="http://tempuri.org/IService/InsertUserServiceDataFault", Name="ServiceData", Namespace="http://schemas.datacontract.org/2004/07/WCFService")]
        void InsertUser(WCFService_host.ServiceReference1.UserRecord record);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/InsertUser", ReplyAction="http://tempuri.org/IService/InsertUserResponse")]
        System.Threading.Tasks.Task InsertUserAsync(WCFService_host.ServiceReference1.UserRecord record);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Login", ReplyAction="http://tempuri.org/IService/LoginResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WCFService_host.ServiceReference1.ServiceData), Action="http://tempuri.org/IService/LoginServiceDataFault", Name="ServiceData", Namespace="http://schemas.datacontract.org/2004/07/WCFService")]
        void Login(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Login", ReplyAction="http://tempuri.org/IService/LoginResponse")]
        System.Threading.Tasks.Task LoginAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Logout", ReplyAction="http://tempuri.org/IService/LogoutResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WCFService_host.ServiceReference1.ServiceData), Action="http://tempuri.org/IService/LogoutServiceDataFault", Name="ServiceData", Namespace="http://schemas.datacontract.org/2004/07/WCFService")]
        void Logout(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Logout", ReplyAction="http://tempuri.org/IService/LogoutResponse")]
        System.Threading.Tasks.Task LogoutAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SelectAllPerson", ReplyAction="http://tempuri.org/IService/SelectAllPersonResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WCFService_host.ServiceReference1.ServiceData), Action="http://tempuri.org/IService/SelectAllPersonServiceDataFault", Name="ServiceData", Namespace="http://schemas.datacontract.org/2004/07/WCFService")]
        WCFService_host.ServiceReference1.PersonRecord[] SelectAllPerson(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SelectAllPerson", ReplyAction="http://tempuri.org/IService/SelectAllPersonResponse")]
        System.Threading.Tasks.Task<WCFService_host.ServiceReference1.PersonRecord[]> SelectAllPersonAsync(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SelectPersonById", ReplyAction="http://tempuri.org/IService/SelectPersonByIdResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WCFService_host.ServiceReference1.ServiceData), Action="http://tempuri.org/IService/SelectPersonByIdServiceDataFault", Name="ServiceData", Namespace="http://schemas.datacontract.org/2004/07/WCFService")]
        WCFService_host.ServiceReference1.PersonRecord SelectPersonById(string token, int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SelectPersonById", ReplyAction="http://tempuri.org/IService/SelectPersonByIdResponse")]
        System.Threading.Tasks.Task<WCFService_host.ServiceReference1.PersonRecord> SelectPersonByIdAsync(string token, int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/InsertPerson", ReplyAction="http://tempuri.org/IService/InsertPersonResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WCFService_host.ServiceReference1.ServiceData), Action="http://tempuri.org/IService/InsertPersonServiceDataFault", Name="ServiceData", Namespace="http://schemas.datacontract.org/2004/07/WCFService")]
        void InsertPerson(string token, WCFService_host.ServiceReference1.PersonRecord record);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/InsertPerson", ReplyAction="http://tempuri.org/IService/InsertPersonResponse")]
        System.Threading.Tasks.Task InsertPersonAsync(string token, WCFService_host.ServiceReference1.PersonRecord record);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UpdatePerson", ReplyAction="http://tempuri.org/IService/UpdatePersonResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WCFService_host.ServiceReference1.ServiceData), Action="http://tempuri.org/IService/UpdatePersonServiceDataFault", Name="ServiceData", Namespace="http://schemas.datacontract.org/2004/07/WCFService")]
        void UpdatePerson(string token, WCFService_host.ServiceReference1.PersonRecord record);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UpdatePerson", ReplyAction="http://tempuri.org/IService/UpdatePersonResponse")]
        System.Threading.Tasks.Task UpdatePersonAsync(string token, WCFService_host.ServiceReference1.PersonRecord record);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/RemovePerson", ReplyAction="http://tempuri.org/IService/RemovePersonResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WCFService_host.ServiceReference1.ServiceData), Action="http://tempuri.org/IService/RemovePersonServiceDataFault", Name="ServiceData", Namespace="http://schemas.datacontract.org/2004/07/WCFService")]
        void RemovePerson(string token, int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/RemovePerson", ReplyAction="http://tempuri.org/IService/RemovePersonResponse")]
        System.Threading.Tasks.Task RemovePersonAsync(string token, int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/NeedRefresh", ReplyAction="http://tempuri.org/IService/NeedRefreshResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WCFService_host.ServiceReference1.ServiceData), Action="http://tempuri.org/IService/NeedRefreshServiceDataFault", Name="ServiceData", Namespace="http://schemas.datacontract.org/2004/07/WCFService")]
        bool NeedRefresh(System.DateTime lastRefresh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/NeedRefresh", ReplyAction="http://tempuri.org/IService/NeedRefreshResponse")]
        System.Threading.Tasks.Task<bool> NeedRefreshAsync(System.DateTime lastRefresh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetToken", ReplyAction="http://tempuri.org/IService/GetTokenResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WCFService_host.ServiceReference1.ServiceData), Action="http://tempuri.org/IService/GetTokenServiceDataFault", Name="ServiceData", Namespace="http://schemas.datacontract.org/2004/07/WCFService")]
        string GetToken();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetToken", ReplyAction="http://tempuri.org/IService/GetTokenResponse")]
        System.Threading.Tasks.Task<string> GetTokenAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Identification", ReplyAction="http://tempuri.org/IService/IdentificationResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WCFService_host.ServiceReference1.ServiceData), Action="http://tempuri.org/IService/IdentificationServiceDataFault", Name="ServiceData", Namespace="http://schemas.datacontract.org/2004/07/WCFService")]
        bool Identification(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Identification", ReplyAction="http://tempuri.org/IService/IdentificationResponse")]
        System.Threading.Tasks.Task<bool> IdentificationAsync(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/DeleteToken", ReplyAction="http://tempuri.org/IService/DeleteTokenResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WCFService_host.ServiceReference1.ServiceData), Action="http://tempuri.org/IService/DeleteTokenServiceDataFault", Name="ServiceData", Namespace="http://schemas.datacontract.org/2004/07/WCFService")]
        void DeleteToken(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/DeleteToken", ReplyAction="http://tempuri.org/IService/DeleteTokenResponse")]
        System.Threading.Tasks.Task DeleteTokenAsync(string token);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : WCFService_host.ServiceReference1.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<WCFService_host.ServiceReference1.IService>, WCFService_host.ServiceReference1.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WCFService_host.ServiceReference1.UserRecord[] SelectAllUser() {
            return base.Channel.SelectAllUser();
        }
        
        public System.Threading.Tasks.Task<WCFService_host.ServiceReference1.UserRecord[]> SelectAllUserAsync() {
            return base.Channel.SelectAllUserAsync();
        }
        
        public void InsertUser(WCFService_host.ServiceReference1.UserRecord record) {
            base.Channel.InsertUser(record);
        }
        
        public System.Threading.Tasks.Task InsertUserAsync(WCFService_host.ServiceReference1.UserRecord record) {
            return base.Channel.InsertUserAsync(record);
        }
        
        public void Login(string username) {
            base.Channel.Login(username);
        }
        
        public System.Threading.Tasks.Task LoginAsync(string username) {
            return base.Channel.LoginAsync(username);
        }
        
        public void Logout(string username) {
            base.Channel.Logout(username);
        }
        
        public System.Threading.Tasks.Task LogoutAsync(string username) {
            return base.Channel.LogoutAsync(username);
        }
        
        public WCFService_host.ServiceReference1.PersonRecord[] SelectAllPerson(string token) {
            return base.Channel.SelectAllPerson(token);
        }
        
        public System.Threading.Tasks.Task<WCFService_host.ServiceReference1.PersonRecord[]> SelectAllPersonAsync(string token) {
            return base.Channel.SelectAllPersonAsync(token);
        }
        
        public WCFService_host.ServiceReference1.PersonRecord SelectPersonById(string token, int id) {
            return base.Channel.SelectPersonById(token, id);
        }
        
        public System.Threading.Tasks.Task<WCFService_host.ServiceReference1.PersonRecord> SelectPersonByIdAsync(string token, int id) {
            return base.Channel.SelectPersonByIdAsync(token, id);
        }
        
        public void InsertPerson(string token, WCFService_host.ServiceReference1.PersonRecord record) {
            base.Channel.InsertPerson(token, record);
        }
        
        public System.Threading.Tasks.Task InsertPersonAsync(string token, WCFService_host.ServiceReference1.PersonRecord record) {
            return base.Channel.InsertPersonAsync(token, record);
        }
        
        public void UpdatePerson(string token, WCFService_host.ServiceReference1.PersonRecord record) {
            base.Channel.UpdatePerson(token, record);
        }
        
        public System.Threading.Tasks.Task UpdatePersonAsync(string token, WCFService_host.ServiceReference1.PersonRecord record) {
            return base.Channel.UpdatePersonAsync(token, record);
        }
        
        public void RemovePerson(string token, int id) {
            base.Channel.RemovePerson(token, id);
        }
        
        public System.Threading.Tasks.Task RemovePersonAsync(string token, int id) {
            return base.Channel.RemovePersonAsync(token, id);
        }
        
        public bool NeedRefresh(System.DateTime lastRefresh) {
            return base.Channel.NeedRefresh(lastRefresh);
        }
        
        public System.Threading.Tasks.Task<bool> NeedRefreshAsync(System.DateTime lastRefresh) {
            return base.Channel.NeedRefreshAsync(lastRefresh);
        }
        
        public string GetToken() {
            return base.Channel.GetToken();
        }
        
        public System.Threading.Tasks.Task<string> GetTokenAsync() {
            return base.Channel.GetTokenAsync();
        }
        
        public bool Identification(string token) {
            return base.Channel.Identification(token);
        }
        
        public System.Threading.Tasks.Task<bool> IdentificationAsync(string token) {
            return base.Channel.IdentificationAsync(token);
        }
        
        public void DeleteToken(string token) {
            base.Channel.DeleteToken(token);
        }
        
        public System.Threading.Tasks.Task DeleteTokenAsync(string token) {
            return base.Channel.DeleteTokenAsync(token);
        }
    }
}
