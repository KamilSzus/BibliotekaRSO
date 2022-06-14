﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference1
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Book", Namespace="http://schemas.datacontract.org/2004/07/Biblioteka")]
    public partial class Book : object
    {
        
        private ServiceReference1.Author[] AuthorsField;
        
        private int BookIdField;
        
        private string TitleField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.Author[] Authors
        {
            get
            {
                return this.AuthorsField;
            }
            set
            {
                this.AuthorsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int BookId
        {
            get
            {
                return this.BookIdField;
            }
            set
            {
                this.BookIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title
        {
            get
            {
                return this.TitleField;
            }
            set
            {
                this.TitleField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Author", Namespace="http://schemas.datacontract.org/2004/07/Biblioteka")]
    public partial class Author : object
    {
        
        private string NameField;
        
        private string SurnameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Surname
        {
            get
            {
                return this.SurnameField;
            }
            set
            {
                this.SurnameField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ILbraryOperations")]
    public interface ILbraryOperations
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILbraryOperations/GetBookById", ReplyAction="http://tempuri.org/ILbraryOperations/GetBookByIdResponse")]
        System.Threading.Tasks.Task<ServiceReference1.Book> GetBookByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILbraryOperations/GetBookByTitle", ReplyAction="http://tempuri.org/ILbraryOperations/GetBookByTitleResponse")]
        System.Threading.Tasks.Task<ServiceReference1.Book[]> GetBookByTitleAsync(string title);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILbraryOperations/dump", ReplyAction="http://tempuri.org/ILbraryOperations/dumpResponse")]
        System.Threading.Tasks.Task<string> dumpAsync(ServiceReference1.Book book);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public interface ILbraryOperationsChannel : ServiceReference1.ILbraryOperations, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public partial class LbraryOperationsClient : System.ServiceModel.ClientBase<ServiceReference1.ILbraryOperations>, ServiceReference1.ILbraryOperations
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public LbraryOperationsClient() : 
                base(LbraryOperationsClient.GetDefaultBinding(), LbraryOperationsClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_ILbraryOperations.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public LbraryOperationsClient(EndpointConfiguration endpointConfiguration) : 
                base(LbraryOperationsClient.GetBindingForEndpoint(endpointConfiguration), LbraryOperationsClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public LbraryOperationsClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(LbraryOperationsClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public LbraryOperationsClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(LbraryOperationsClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public LbraryOperationsClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.Book> GetBookByIdAsync(int id)
        {
            return base.Channel.GetBookByIdAsync(id);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.Book[]> GetBookByTitleAsync(string title)
        {
            return base.Channel.GetBookByTitleAsync(title);
        }
        
        public System.Threading.Tasks.Task<string> dumpAsync(ServiceReference1.Book book)
        {
            return base.Channel.dumpAsync(book);
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ILbraryOperations))
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ILbraryOperations))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:8733/Design_Time_Addresses/Biblioteka/Library/");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return LbraryOperationsClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_ILbraryOperations);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return LbraryOperationsClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_ILbraryOperations);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_ILbraryOperations,
        }
    }
}
