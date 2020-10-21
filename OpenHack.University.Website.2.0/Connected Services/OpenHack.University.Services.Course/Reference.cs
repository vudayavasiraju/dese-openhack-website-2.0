﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OpenHack.University.Services.Course
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="OpenHack.University.Services.Course.ICourse")]
    public interface ICourse
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourse/Search", ReplyAction="http://tempuri.org/ICourse/SearchResponse")]
        OpenHack.University.Services.Contract.Course[] Search();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourse/Search", ReplyAction="http://tempuri.org/ICourse/SearchResponse")]
        System.Threading.Tasks.Task<OpenHack.University.Services.Contract.Course[]> SearchAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourse/GetById", ReplyAction="http://tempuri.org/ICourse/GetByIdResponse")]
        OpenHack.University.Services.Contract.Course GetById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourse/GetById", ReplyAction="http://tempuri.org/ICourse/GetByIdResponse")]
        System.Threading.Tasks.Task<OpenHack.University.Services.Contract.Course> GetByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourse/Create", ReplyAction="http://tempuri.org/ICourse/CreateResponse")]
        OpenHack.University.Services.Contract.Course Create(OpenHack.University.Services.Contract.Course courseToCreate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourse/Create", ReplyAction="http://tempuri.org/ICourse/CreateResponse")]
        System.Threading.Tasks.Task<OpenHack.University.Services.Contract.Course> CreateAsync(OpenHack.University.Services.Contract.Course courseToCreate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourse/Modify", ReplyAction="http://tempuri.org/ICourse/ModifyResponse")]
        OpenHack.University.Services.Contract.Course Modify(OpenHack.University.Services.Contract.Course courseToModify);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourse/Modify", ReplyAction="http://tempuri.org/ICourse/ModifyResponse")]
        System.Threading.Tasks.Task<OpenHack.University.Services.Contract.Course> ModifyAsync(OpenHack.University.Services.Contract.Course courseToModify);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourse/Delete", ReplyAction="http://tempuri.org/ICourse/DeleteResponse")]
        OpenHack.University.Services.Contract.Course Delete(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourse/Delete", ReplyAction="http://tempuri.org/ICourse/DeleteResponse")]
        System.Threading.Tasks.Task<OpenHack.University.Services.Contract.Course> DeleteAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface ICourseChannel : OpenHack.University.Services.Course.ICourse, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class CourseClient : System.ServiceModel.ClientBase<OpenHack.University.Services.Course.ICourse>, OpenHack.University.Services.Course.ICourse
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public CourseClient() : 
                base(CourseClient.GetDefaultBinding(), CourseClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_ICourse.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CourseClient(EndpointConfiguration endpointConfiguration) : 
                base(CourseClient.GetBindingForEndpoint(endpointConfiguration), CourseClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CourseClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(CourseClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CourseClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(CourseClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CourseClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public OpenHack.University.Services.Contract.Course[] Search()
        {
            return base.Channel.Search();
        }
        
        public System.Threading.Tasks.Task<OpenHack.University.Services.Contract.Course[]> SearchAsync()
        {
            return base.Channel.SearchAsync();
        }
        
        public OpenHack.University.Services.Contract.Course GetById(int id)
        {
            return base.Channel.GetById(id);
        }
        
        public System.Threading.Tasks.Task<OpenHack.University.Services.Contract.Course> GetByIdAsync(int id)
        {
            return base.Channel.GetByIdAsync(id);
        }
        
        public OpenHack.University.Services.Contract.Course Create(OpenHack.University.Services.Contract.Course courseToCreate)
        {
            return base.Channel.Create(courseToCreate);
        }
        
        public System.Threading.Tasks.Task<OpenHack.University.Services.Contract.Course> CreateAsync(OpenHack.University.Services.Contract.Course courseToCreate)
        {
            return base.Channel.CreateAsync(courseToCreate);
        }
        
        public OpenHack.University.Services.Contract.Course Modify(OpenHack.University.Services.Contract.Course courseToModify)
        {
            return base.Channel.Modify(courseToModify);
        }
        
        public System.Threading.Tasks.Task<OpenHack.University.Services.Contract.Course> ModifyAsync(OpenHack.University.Services.Contract.Course courseToModify)
        {
            return base.Channel.ModifyAsync(courseToModify);
        }
        
        public OpenHack.University.Services.Contract.Course Delete(int id)
        {
            return base.Channel.Delete(id);
        }
        
        public System.Threading.Tasks.Task<OpenHack.University.Services.Contract.Course> DeleteAsync(int id)
        {
            return base.Channel.DeleteAsync(id);
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ICourse))
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ICourse))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:1096/Course.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return CourseClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_ICourse);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return CourseClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_ICourse);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_ICourse,
        }
    }
}
