﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IShareService")]
public interface IShareService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShareService/Login", ReplyAction="http://tempuri.org/IShareService/LoginResponse")]
    void Login(string username, string password);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShareService/Login", ReplyAction="http://tempuri.org/IShareService/LoginResponse")]
    System.Threading.Tasks.Task LoginAsync(string username, string password);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShareService/Register", ReplyAction="http://tempuri.org/IShareService/RegisterResponse")]
    void Register(string fName, string lName, string Username, string password);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShareService/Register", ReplyAction="http://tempuri.org/IShareService/RegisterResponse")]
    System.Threading.Tasks.Task RegisterAsync(string fName, string lName, string Username, string password);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShareService/UploadFile", ReplyAction="http://tempuri.org/IShareService/UploadFileResponse")]
    void UploadFile();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShareService/UploadFile", ReplyAction="http://tempuri.org/IShareService/UploadFileResponse")]
    System.Threading.Tasks.Task UploadFileAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShareService/DownloadFile", ReplyAction="http://tempuri.org/IShareService/DownloadFileResponse")]
    void DownloadFile();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShareService/DownloadFile", ReplyAction="http://tempuri.org/IShareService/DownloadFileResponse")]
    System.Threading.Tasks.Task DownloadFileAsync();
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IShareServiceChannel : IShareService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class ShareServiceClient : System.ServiceModel.ClientBase<IShareService>, IShareService
{
    
    public ShareServiceClient()
    {
    }
    
    public ShareServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public ShareServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public ShareServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public ShareServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public void Login(string username, string password)
    {
        base.Channel.Login(username, password);
    }
    
    public System.Threading.Tasks.Task LoginAsync(string username, string password)
    {
        return base.Channel.LoginAsync(username, password);
    }
    
    public void Register(string fName, string lName, string Username, string password)
    {
        base.Channel.Register(fName, lName, Username, password);
    }
    
    public System.Threading.Tasks.Task RegisterAsync(string fName, string lName, string Username, string password)
    {
        return base.Channel.RegisterAsync(fName, lName, Username, password);
    }
    
    public void UploadFile()
    {
        base.Channel.UploadFile();
    }
    
    public System.Threading.Tasks.Task UploadFileAsync()
    {
        return base.Channel.UploadFileAsync();
    }
    
    public void DownloadFile()
    {
        base.Channel.DownloadFile();
    }
    
    public System.Threading.Tasks.Task DownloadFileAsync()
    {
        return base.Channel.DownloadFileAsync();
    }
}
