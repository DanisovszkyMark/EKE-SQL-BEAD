﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPF_client.ServiceReference {
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
    [System.Runtime.Serialization.DataContractAttribute(Name="PersonRecord", Namespace="http://schemas.datacontract.org/2004/07/WCFService.DatabaseManagers.Records")]
    [System.SerializableAttribute()]
    public partial class PersonRecord : WPF_client.ServiceReference.Record {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Birt_dayField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Job_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> SalaryField;
        
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
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Record", Namespace="http://schemas.datacontract.org/2004/07/WCFService.DatabaseManagers.Records")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(WPF_client.ServiceReference.PersonRecord))]
    public partial class Record : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool DeletedField;
        
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
        public bool Deleted {
            get {
                return this.DeletedField;
            }
            set {
                if ((this.DeletedField.Equals(value) != true)) {
                    this.DeletedField = value;
                    this.RaisePropertyChanged("Deleted");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SelectAllUser", ReplyAction="http://tempuri.org/IService/SelectAllUserResponse")]
        WPF_client.ServiceReference.UserRecord[] SelectAllUser();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SelectAllUser", ReplyAction="http://tempuri.org/IService/SelectAllUserResponse")]
        System.Threading.Tasks.Task<WPF_client.ServiceReference.UserRecord[]> SelectAllUserAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SelectAllPerson", ReplyAction="http://tempuri.org/IService/SelectAllPersonResponse")]
        WPF_client.ServiceReference.PersonRecord[] SelectAllPerson();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SelectAllPerson", ReplyAction="http://tempuri.org/IService/SelectAllPersonResponse")]
        System.Threading.Tasks.Task<WPF_client.ServiceReference.PersonRecord[]> SelectAllPersonAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : WPF_client.ServiceReference.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<WPF_client.ServiceReference.IService>, WPF_client.ServiceReference.IService {
        
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
        
        public WPF_client.ServiceReference.UserRecord[] SelectAllUser() {
            return base.Channel.SelectAllUser();
        }
        
        public System.Threading.Tasks.Task<WPF_client.ServiceReference.UserRecord[]> SelectAllUserAsync() {
            return base.Channel.SelectAllUserAsync();
        }
        
        public WPF_client.ServiceReference.PersonRecord[] SelectAllPerson() {
            return base.Channel.SelectAllPerson();
        }
        
        public System.Threading.Tasks.Task<WPF_client.ServiceReference.PersonRecord[]> SelectAllPersonAsync() {
            return base.Channel.SelectAllPersonAsync();
        }
    }
}