﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IShareStorageService")]
public interface IShareStorageService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShareStorageService/getShares", ReplyAction="http://tempuri.org/IShareStorageService/getSharesResponse")]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(byte[][]))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
    byte[][] getShares(ShareLibrary.ShareFile file, int UserID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShareStorageService/getShares", ReplyAction="http://tempuri.org/IShareStorageService/getSharesResponse")]
    System.Threading.Tasks.Task<byte[][]> getSharesAsync(ShareLibrary.ShareFile file, int UserID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShareStorageService/uploadShares", ReplyAction="http://tempuri.org/IShareStorageService/uploadSharesResponse")]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(byte[][]))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
    void uploadShares(ShareLibrary.ShareFile file);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShareStorageService/uploadShares", ReplyAction="http://tempuri.org/IShareStorageService/uploadSharesResponse")]
    System.Threading.Tasks.Task uploadSharesAsync(ShareLibrary.ShareFile file);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IShareStorageServiceChannel : IShareStorageService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class ShareStorageServiceClient : System.ServiceModel.ClientBase<IShareStorageService>, IShareStorageService
{
    
    public ShareStorageServiceClient()
    {
    }
    
    public ShareStorageServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public ShareStorageServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public ShareStorageServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public ShareStorageServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public byte[][] getShares(ShareLibrary.ShareFile file, int UserID)
    {
        return base.Channel.getShares(file, UserID);
    }
    
    public System.Threading.Tasks.Task<byte[][]> getSharesAsync(ShareLibrary.ShareFile file, int UserID)
    {
        return base.Channel.getSharesAsync(file, UserID);
    }
    
    public void uploadShares(ShareLibrary.ShareFile file)
    {
        base.Channel.uploadShares(file);
    }
    
    public System.Threading.Tasks.Task uploadSharesAsync(ShareLibrary.ShareFile file)
    {
        return base.Channel.uploadSharesAsync(file);
    }
}