﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace oBuddy.BuildServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="clientInfo", Namespace="http://schemas.datacontract.org/2004/07/ErrorLoggingTest")]
    [System.SerializableAttribute()]
    public partial class clientInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContactNoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DobField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SexField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TokenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
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
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ContactNo {
            get {
                return this.ContactNoField;
            }
            set {
                if ((object.ReferenceEquals(this.ContactNoField, value) != true)) {
                    this.ContactNoField = value;
                    this.RaisePropertyChanged("ContactNo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Dob {
            get {
                return this.DobField;
            }
            set {
                if ((this.DobField.Equals(value) != true)) {
                    this.DobField = value;
                    this.RaisePropertyChanged("Dob");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sex {
            get {
                return this.SexField;
            }
            set {
                if ((object.ReferenceEquals(this.SexField, value) != true)) {
                    this.SexField = value;
                    this.RaisePropertyChanged("Sex");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Token {
            get {
                return this.TokenField;
            }
            set {
                if ((object.ReferenceEquals(this.TokenField, value) != true)) {
                    this.TokenField = value;
                    this.RaisePropertyChanged("Token");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((object.ReferenceEquals(this.UserIdField, value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="bugData", Namespace="http://schemas.datacontract.org/2004/07/ErrorLoggingTest")]
    [System.SerializableAttribute()]
    public partial class bugData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BugIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorMessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FilenameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GuidField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MoreOptionsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameSpaceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OperatingSystemField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OutputTextField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SoftwareInfoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SoftwareNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StackTraceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] TagsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TokenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string VendorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string VersionField;
        
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
        public string BugId {
            get {
                return this.BugIdField;
            }
            set {
                if ((object.ReferenceEquals(this.BugIdField, value) != true)) {
                    this.BugIdField = value;
                    this.RaisePropertyChanged("BugId");
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
        public string Filename {
            get {
                return this.FilenameField;
            }
            set {
                if ((object.ReferenceEquals(this.FilenameField, value) != true)) {
                    this.FilenameField = value;
                    this.RaisePropertyChanged("Filename");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Guid {
            get {
                return this.GuidField;
            }
            set {
                if ((object.ReferenceEquals(this.GuidField, value) != true)) {
                    this.GuidField = value;
                    this.RaisePropertyChanged("Guid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MoreOptions {
            get {
                return this.MoreOptionsField;
            }
            set {
                if ((this.MoreOptionsField.Equals(value) != true)) {
                    this.MoreOptionsField = value;
                    this.RaisePropertyChanged("MoreOptions");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NameSpace {
            get {
                return this.NameSpaceField;
            }
            set {
                if ((object.ReferenceEquals(this.NameSpaceField, value) != true)) {
                    this.NameSpaceField = value;
                    this.RaisePropertyChanged("NameSpace");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OperatingSystem {
            get {
                return this.OperatingSystemField;
            }
            set {
                if ((object.ReferenceEquals(this.OperatingSystemField, value) != true)) {
                    this.OperatingSystemField = value;
                    this.RaisePropertyChanged("OperatingSystem");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OutputText {
            get {
                return this.OutputTextField;
            }
            set {
                if ((object.ReferenceEquals(this.OutputTextField, value) != true)) {
                    this.OutputTextField = value;
                    this.RaisePropertyChanged("OutputText");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SoftwareInfo {
            get {
                return this.SoftwareInfoField;
            }
            set {
                if ((object.ReferenceEquals(this.SoftwareInfoField, value) != true)) {
                    this.SoftwareInfoField = value;
                    this.RaisePropertyChanged("SoftwareInfo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SoftwareName {
            get {
                return this.SoftwareNameField;
            }
            set {
                if ((object.ReferenceEquals(this.SoftwareNameField, value) != true)) {
                    this.SoftwareNameField = value;
                    this.RaisePropertyChanged("SoftwareName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StackTrace {
            get {
                return this.StackTraceField;
            }
            set {
                if ((object.ReferenceEquals(this.StackTraceField, value) != true)) {
                    this.StackTraceField = value;
                    this.RaisePropertyChanged("StackTrace");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] Tags {
            get {
                return this.TagsField;
            }
            set {
                if ((object.ReferenceEquals(this.TagsField, value) != true)) {
                    this.TagsField = value;
                    this.RaisePropertyChanged("Tags");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Token {
            get {
                return this.TokenField;
            }
            set {
                if ((object.ReferenceEquals(this.TokenField, value) != true)) {
                    this.TokenField = value;
                    this.RaisePropertyChanged("Token");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((object.ReferenceEquals(this.UserIdField, value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Vendor {
            get {
                return this.VendorField;
            }
            set {
                if ((object.ReferenceEquals(this.VendorField, value) != true)) {
                    this.VendorField = value;
                    this.RaisePropertyChanged("Vendor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Version {
            get {
                return this.VersionField;
            }
            set {
                if ((object.ReferenceEquals(this.VersionField, value) != true)) {
                    this.VersionField = value;
                    this.RaisePropertyChanged("Version");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="responseInfo", Namespace="http://schemas.datacontract.org/2004/07/ErrorLoggingTest")]
    [System.SerializableAttribute()]
    public partial class responseInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BugIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string QuestionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] SolutionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int[] VoteField;
        
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
        public string BugId {
            get {
                return this.BugIdField;
            }
            set {
                if ((object.ReferenceEquals(this.BugIdField, value) != true)) {
                    this.BugIdField = value;
                    this.RaisePropertyChanged("BugId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Error {
            get {
                return this.ErrorField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorField, value) != true)) {
                    this.ErrorField = value;
                    this.RaisePropertyChanged("Error");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Question {
            get {
                return this.QuestionField;
            }
            set {
                if ((object.ReferenceEquals(this.QuestionField, value) != true)) {
                    this.QuestionField = value;
                    this.RaisePropertyChanged("Question");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] Solution {
            get {
                return this.SolutionField;
            }
            set {
                if ((object.ReferenceEquals(this.SolutionField, value) != true)) {
                    this.SolutionField = value;
                    this.RaisePropertyChanged("Solution");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((object.ReferenceEquals(this.UserIdField, value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int[] Vote {
            get {
                return this.VoteField;
            }
            set {
                if ((object.ReferenceEquals(this.VoteField, value) != true)) {
                    this.VoteField = value;
                    this.RaisePropertyChanged("Vote");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="subscriptionInfo", Namespace="http://schemas.datacontract.org/2004/07/ErrorLoggingTest")]
    [System.SerializableAttribute()]
    public partial class subscriptionInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DoeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DopField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PaymentModeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SubscriptionDaysField;
        
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
        public System.DateTime Doe {
            get {
                return this.DoeField;
            }
            set {
                if ((this.DoeField.Equals(value) != true)) {
                    this.DoeField = value;
                    this.RaisePropertyChanged("Doe");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Dop {
            get {
                return this.DopField;
            }
            set {
                if ((this.DopField.Equals(value) != true)) {
                    this.DopField = value;
                    this.RaisePropertyChanged("Dop");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PaymentMode {
            get {
                return this.PaymentModeField;
            }
            set {
                if ((object.ReferenceEquals(this.PaymentModeField, value) != true)) {
                    this.PaymentModeField = value;
                    this.RaisePropertyChanged("PaymentMode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SubscriptionDays {
            get {
                return this.SubscriptionDaysField;
            }
            set {
                if ((this.SubscriptionDaysField.Equals(value) != true)) {
                    this.SubscriptionDaysField = value;
                    this.RaisePropertyChanged("SubscriptionDays");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BuildServiceReference.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetUserDetail", ReplyAction="http://tempuri.org/IService1/GetUserDetailResponse")]
        oBuddy.BuildServiceReference.clientInfo GetUserDetail(string userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAnswer", ReplyAction="http://tempuri.org/IService1/GetAnswerResponse")]
        oBuddy.BuildServiceReference.responseInfo GetAnswer(oBuddy.BuildServiceReference.bugData input);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetSubscriptionDetail", ReplyAction="http://tempuri.org/IService1/GetSubscriptionDetailResponse")]
        oBuddy.BuildServiceReference.subscriptionInfo GetSubscriptionDetail(string userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/changeToken", ReplyAction="http://tempuri.org/IService1/changeTokenResponse")]
        oBuddy.BuildServiceReference.clientInfo changeToken(oBuddy.BuildServiceReference.clientInfo client);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : oBuddy.BuildServiceReference.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<oBuddy.BuildServiceReference.IService1>, oBuddy.BuildServiceReference.IService1 {
        
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
        
        public oBuddy.BuildServiceReference.clientInfo GetUserDetail(string userId) {
            return base.Channel.GetUserDetail(userId);
        }
        
        public oBuddy.BuildServiceReference.responseInfo GetAnswer(oBuddy.BuildServiceReference.bugData input) {
            return base.Channel.GetAnswer(input);
        }
        
        public oBuddy.BuildServiceReference.subscriptionInfo GetSubscriptionDetail(string userId) {
            return base.Channel.GetSubscriptionDetail(userId);
        }
        
        public oBuddy.BuildServiceReference.clientInfo changeToken(oBuddy.BuildServiceReference.clientInfo client) {
            return base.Channel.changeToken(client);
        }
    }
}
