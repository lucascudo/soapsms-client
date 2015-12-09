﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.1.
// 
#pragma warning disable 1591

namespace soapsms.SivSoap {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="sivsoapBinding", Namespace="urn:sivsoap")]
    public partial class sivsoap : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback sendmailOperationCompleted;
        
        private System.Threading.SendOrPostCallback sendsmsOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public sivsoap() {
            this.Url = global::soapsms.Properties.Settings.Default.soapsms_SivSoap_sivsoap;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event sendmailCompletedEventHandler sendmailCompleted;
        
        /// <remarks/>
        public event sendsmsCompletedEventHandler sendsmsCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:sivsoap#sendmail", RequestNamespace="urn:sivsoap", ResponseNamespace="urn:sivsoap")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public string sendmail(string mailTo, string mailFrom, string subject, string text, string mailFromName, string SMTPServer, [System.Xml.Serialization.SoapElementAttribute(DataType="integer")] string SMTPPort, bool IsHTML, bool SMTPAuth, string Username, string Password, string SMTPSecure) {
            object[] results = this.Invoke("sendmail", new object[] {
                        mailTo,
                        mailFrom,
                        subject,
                        text,
                        mailFromName,
                        SMTPServer,
                        SMTPPort,
                        IsHTML,
                        SMTPAuth,
                        Username,
                        Password,
                        SMTPSecure});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void sendmailAsync(string mailTo, string mailFrom, string subject, string text, string mailFromName, string SMTPServer, string SMTPPort, bool IsHTML, bool SMTPAuth, string Username, string Password, string SMTPSecure) {
            this.sendmailAsync(mailTo, mailFrom, subject, text, mailFromName, SMTPServer, SMTPPort, IsHTML, SMTPAuth, Username, Password, SMTPSecure, null);
        }
        
        /// <remarks/>
        public void sendmailAsync(string mailTo, string mailFrom, string subject, string text, string mailFromName, string SMTPServer, string SMTPPort, bool IsHTML, bool SMTPAuth, string Username, string Password, string SMTPSecure, object userState) {
            if ((this.sendmailOperationCompleted == null)) {
                this.sendmailOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsendmailOperationCompleted);
            }
            this.InvokeAsync("sendmail", new object[] {
                        mailTo,
                        mailFrom,
                        subject,
                        text,
                        mailFromName,
                        SMTPServer,
                        SMTPPort,
                        IsHTML,
                        SMTPAuth,
                        Username,
                        Password,
                        SMTPSecure}, this.sendmailOperationCompleted, userState);
        }
        
        private void OnsendmailOperationCompleted(object arg) {
            if ((this.sendmailCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.sendmailCompleted(this, new sendmailCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:sivsoap#sendsms", RequestNamespace="urn:sivsoap", ResponseNamespace="urn:sivsoap")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public string sendsms(string phone, string text, string nmliente) {
            object[] results = this.Invoke("sendsms", new object[] {
                        phone,
                        text,
                        nmliente});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void sendsmsAsync(string phone, string text, string nmliente) {
            this.sendsmsAsync(phone, text, nmliente, null);
        }
        
        /// <remarks/>
        public void sendsmsAsync(string phone, string text, string nmliente, object userState) {
            if ((this.sendsmsOperationCompleted == null)) {
                this.sendsmsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsendsmsOperationCompleted);
            }
            this.InvokeAsync("sendsms", new object[] {
                        phone,
                        text,
                        nmliente}, this.sendsmsOperationCompleted, userState);
        }
        
        private void OnsendsmsOperationCompleted(object arg) {
            if ((this.sendsmsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.sendsmsCompleted(this, new sendsmsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void sendmailCompletedEventHandler(object sender, sendmailCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class sendmailCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal sendmailCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void sendsmsCompletedEventHandler(object sender, sendsmsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class sendsmsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal sendsmsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591