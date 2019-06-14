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
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CanLogin", ReplyAction="http://tempuri.org/IService/CanLoginResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WCFService.ServiceData), Action="http://tempuri.org/IService/CanLoginServiceDataFault", Name="ServiceData", Namespace="http://schemas.datacontract.org/2004/07/WCFService")]
        bool CanLogin(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CanLogin", ReplyAction="http://tempuri.org/IService/CanLoginResponse")]
        System.Threading.Tasks.Task<bool> CanLoginAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/InsertUser", ReplyAction="http://tempuri.org/IService/InsertUserResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WCFService.ServiceData), Action="http://tempuri.org/IService/InsertUserServiceDataFault", Name="ServiceData", Namespace="http://schemas.datacontract.org/2004/07/WCFService")]
        void InsertUser(WCFService.DatabaseManagers.Records.UserRecord record);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/InsertUser", ReplyAction="http://tempuri.org/IService/InsertUserResponse")]
        System.Threading.Tasks.Task InsertUserAsync(WCFService.DatabaseManagers.Records.UserRecord record);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Login", ReplyAction="http://tempuri.org/IService/LoginResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WCFService.ServiceData), Action="http://tempuri.org/IService/LoginServiceDataFault", Name="ServiceData", Namespace="http://schemas.datacontract.org/2004/07/WCFService")]
        void Login(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Login", ReplyAction="http://tempuri.org/IService/LoginResponse")]
        System.Threading.Tasks.Task LoginAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Logout", ReplyAction="http://tempuri.org/IService/LogoutResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WCFService.ServiceData), Action="http://tempuri.org/IService/LogoutServiceDataFault", Name="ServiceData", Namespace="http://schemas.datacontract.org/2004/07/WCFService")]
        void Logout(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Logout", ReplyAction="http://tempuri.org/IService/LogoutResponse")]
        System.Threading.Tasks.Task LogoutAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SelectAllPerson", ReplyAction="http://tempuri.org/IService/SelectAllPersonResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WCFService.ServiceData), Action="http://tempuri.org/IService/SelectAllPersonServiceDataFault", Name="ServiceData", Namespace="http://schemas.datacontract.org/2004/07/WCFService")]
        WCFService.DatabaseManagers.Records.PersonRecord[] SelectAllPerson(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SelectAllPerson", ReplyAction="http://tempuri.org/IService/SelectAllPersonResponse")]
        System.Threading.Tasks.Task<WCFService.DatabaseManagers.Records.PersonRecord[]> SelectAllPersonAsync(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SelectPersonById", ReplyAction="http://tempuri.org/IService/SelectPersonByIdResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WCFService.ServiceData), Action="http://tempuri.org/IService/SelectPersonByIdServiceDataFault", Name="ServiceData", Namespace="http://schemas.datacontract.org/2004/07/WCFService")]
        WCFService.DatabaseManagers.Records.PersonRecord SelectPersonById(string token, int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SelectPersonById", ReplyAction="http://tempuri.org/IService/SelectPersonByIdResponse")]
        System.Threading.Tasks.Task<WCFService.DatabaseManagers.Records.PersonRecord> SelectPersonByIdAsync(string token, int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/InsertPerson", ReplyAction="http://tempuri.org/IService/InsertPersonResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WCFService.ServiceData), Action="http://tempuri.org/IService/InsertPersonServiceDataFault", Name="ServiceData", Namespace="http://schemas.datacontract.org/2004/07/WCFService")]
        void InsertPerson(string token, WCFService.DatabaseManagers.Records.PersonRecord record);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/InsertPerson", ReplyAction="http://tempuri.org/IService/InsertPersonResponse")]
        System.Threading.Tasks.Task InsertPersonAsync(string token, WCFService.DatabaseManagers.Records.PersonRecord record);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UpdatePerson", ReplyAction="http://tempuri.org/IService/UpdatePersonResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WCFService.ServiceData), Action="http://tempuri.org/IService/UpdatePersonServiceDataFault", Name="ServiceData", Namespace="http://schemas.datacontract.org/2004/07/WCFService")]
        void UpdatePerson(string token, WCFService.DatabaseManagers.Records.PersonRecord record);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UpdatePerson", ReplyAction="http://tempuri.org/IService/UpdatePersonResponse")]
        System.Threading.Tasks.Task UpdatePersonAsync(string token, WCFService.DatabaseManagers.Records.PersonRecord record);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/RemovePerson", ReplyAction="http://tempuri.org/IService/RemovePersonResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WCFService.ServiceData), Action="http://tempuri.org/IService/RemovePersonServiceDataFault", Name="ServiceData", Namespace="http://schemas.datacontract.org/2004/07/WCFService")]
        void RemovePerson(string token, int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/RemovePerson", ReplyAction="http://tempuri.org/IService/RemovePersonResponse")]
        System.Threading.Tasks.Task RemovePersonAsync(string token, int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/generatePersons", ReplyAction="http://tempuri.org/IService/generatePersonsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WCFService.ServiceData), Action="http://tempuri.org/IService/generatePersonsServiceDataFault", Name="ServiceData", Namespace="http://schemas.datacontract.org/2004/07/WCFService")]
        void generatePersons(string token, int numberOfPersons, bool dropFirst);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/generatePersons", ReplyAction="http://tempuri.org/IService/generatePersonsResponse")]
        System.Threading.Tasks.Task generatePersonsAsync(string token, int numberOfPersons, bool dropFirst);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SelectAllJobs", ReplyAction="http://tempuri.org/IService/SelectAllJobsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WCFService.ServiceData), Action="http://tempuri.org/IService/SelectAllJobsServiceDataFault", Name="ServiceData", Namespace="http://schemas.datacontract.org/2004/07/WCFService")]
        WCFService.DatabaseManagers.Records.JobRecord[] SelectAllJobs(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SelectAllJobs", ReplyAction="http://tempuri.org/IService/SelectAllJobsResponse")]
        System.Threading.Tasks.Task<WCFService.DatabaseManagers.Records.JobRecord[]> SelectAllJobsAsync(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/NeedRefresh", ReplyAction="http://tempuri.org/IService/NeedRefreshResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WCFService.ServiceData), Action="http://tempuri.org/IService/NeedRefreshServiceDataFault", Name="ServiceData", Namespace="http://schemas.datacontract.org/2004/07/WCFService")]
        bool NeedRefresh(System.DateTime lastRefresh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/NeedRefresh", ReplyAction="http://tempuri.org/IService/NeedRefreshResponse")]
        System.Threading.Tasks.Task<bool> NeedRefreshAsync(System.DateTime lastRefresh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetToken", ReplyAction="http://tempuri.org/IService/GetTokenResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WCFService.ServiceData), Action="http://tempuri.org/IService/GetTokenServiceDataFault", Name="ServiceData", Namespace="http://schemas.datacontract.org/2004/07/WCFService")]
        string GetToken();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetToken", ReplyAction="http://tempuri.org/IService/GetTokenResponse")]
        System.Threading.Tasks.Task<string> GetTokenAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Identification", ReplyAction="http://tempuri.org/IService/IdentificationResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WCFService.ServiceData), Action="http://tempuri.org/IService/IdentificationServiceDataFault", Name="ServiceData", Namespace="http://schemas.datacontract.org/2004/07/WCFService")]
        bool Identification(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Identification", ReplyAction="http://tempuri.org/IService/IdentificationResponse")]
        System.Threading.Tasks.Task<bool> IdentificationAsync(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/DeleteToken", ReplyAction="http://tempuri.org/IService/DeleteTokenResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WCFService.ServiceData), Action="http://tempuri.org/IService/DeleteTokenServiceDataFault", Name="ServiceData", Namespace="http://schemas.datacontract.org/2004/07/WCFService")]
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
        
        public bool CanLogin(string username, string password) {
            return base.Channel.CanLogin(username, password);
        }
        
        public System.Threading.Tasks.Task<bool> CanLoginAsync(string username, string password) {
            return base.Channel.CanLoginAsync(username, password);
        }
        
        public void InsertUser(WCFService.DatabaseManagers.Records.UserRecord record) {
            base.Channel.InsertUser(record);
        }
        
        public System.Threading.Tasks.Task InsertUserAsync(WCFService.DatabaseManagers.Records.UserRecord record) {
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
        
        public WCFService.DatabaseManagers.Records.PersonRecord[] SelectAllPerson(string token) {
            return base.Channel.SelectAllPerson(token);
        }
        
        public System.Threading.Tasks.Task<WCFService.DatabaseManagers.Records.PersonRecord[]> SelectAllPersonAsync(string token) {
            return base.Channel.SelectAllPersonAsync(token);
        }
        
        public WCFService.DatabaseManagers.Records.PersonRecord SelectPersonById(string token, int id) {
            return base.Channel.SelectPersonById(token, id);
        }
        
        public System.Threading.Tasks.Task<WCFService.DatabaseManagers.Records.PersonRecord> SelectPersonByIdAsync(string token, int id) {
            return base.Channel.SelectPersonByIdAsync(token, id);
        }
        
        public void InsertPerson(string token, WCFService.DatabaseManagers.Records.PersonRecord record) {
            base.Channel.InsertPerson(token, record);
        }
        
        public System.Threading.Tasks.Task InsertPersonAsync(string token, WCFService.DatabaseManagers.Records.PersonRecord record) {
            return base.Channel.InsertPersonAsync(token, record);
        }
        
        public void UpdatePerson(string token, WCFService.DatabaseManagers.Records.PersonRecord record) {
            base.Channel.UpdatePerson(token, record);
        }
        
        public System.Threading.Tasks.Task UpdatePersonAsync(string token, WCFService.DatabaseManagers.Records.PersonRecord record) {
            return base.Channel.UpdatePersonAsync(token, record);
        }
        
        public void RemovePerson(string token, int id) {
            base.Channel.RemovePerson(token, id);
        }
        
        public System.Threading.Tasks.Task RemovePersonAsync(string token, int id) {
            return base.Channel.RemovePersonAsync(token, id);
        }
        
        public void generatePersons(string token, int numberOfPersons, bool dropFirst) {
            base.Channel.generatePersons(token, numberOfPersons, dropFirst);
        }
        
        public System.Threading.Tasks.Task generatePersonsAsync(string token, int numberOfPersons, bool dropFirst) {
            return base.Channel.generatePersonsAsync(token, numberOfPersons, dropFirst);
        }
        
        public WCFService.DatabaseManagers.Records.JobRecord[] SelectAllJobs(string token) {
            return base.Channel.SelectAllJobs(token);
        }
        
        public System.Threading.Tasks.Task<WCFService.DatabaseManagers.Records.JobRecord[]> SelectAllJobsAsync(string token) {
            return base.Channel.SelectAllJobsAsync(token);
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
