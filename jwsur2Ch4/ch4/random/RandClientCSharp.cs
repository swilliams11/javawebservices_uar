﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

// 
// This source code was auto-generated by wsdl, Version=4.0.30319.1.
// 

class RandClient {
    static void Main()
    {
        RandServiceService service = new RandServiceService();
        Console.WriteLine("Call to next1():\n" + service.next1());
        Console.WriteLine("\nCall to nextN(4):");
        int?[] nums = service.nextN(4);
        foreach (int num in nums) Console.WriteLine(num);
        /*
         Call to next1():
680641940

Call to nextN(4):
1783826925
260390049
-48376976
-914903224
         */
    }
}


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Web.Services.WebServiceBindingAttribute(Name="RandServicePortBinding", Namespace="http://rand/")]
public partial class RandServiceService : System.Web.Services.Protocols.SoapHttpClientProtocol {
    
    private System.Threading.SendOrPostCallback next1OperationCompleted;
    
    private System.Threading.SendOrPostCallback nextNOperationCompleted;
    
    /// <remarks/>
    public RandServiceService() {
        this.Url = "http://localhost:8888/rs";
    }
    
    /// <remarks/>
    public event next1CompletedEventHandler next1Completed;
    
    /// <remarks/>
    public event nextNCompletedEventHandler nextNCompleted;
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://rand/", 
     ResponseNamespace="http://rand/", Use=System.Web.Services.Description.SoapBindingUse.Literal, 
     ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public int next1() {
        object[] results = this.Invoke("next1", new object[0]);
        return ((int)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult Beginnext1(System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("next1", new object[0], callback, asyncState);
    }
    
    /// <remarks/>
    public int Endnext1(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((int)(results[0]));
    }
    
    /// <remarks/>
    public void next1Async() {
        this.next1Async(null);
    }
    
    /// <remarks/>
    public void next1Async(object userState) {
        if ((this.next1OperationCompleted == null)) {
            this.next1OperationCompleted = new System.Threading.SendOrPostCallback(this.Onnext1OperationCompleted);
        }
        this.InvokeAsync("next1", new object[0], this.next1OperationCompleted, userState);
    }
    
    private void Onnext1OperationCompleted(object arg) {
        if ((this.next1Completed != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.next1Completed(this, new next1CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://rand/", ResponseNamespace="http://rand/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public System.Nullable<int>[] nextN([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] int arg0) {
        object[] results = this.Invoke("nextN", new object[] {
                    arg0});
        return ((System.Nullable<int>[])(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginnextN(int arg0, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("nextN", new object[] {
                    arg0}, callback, asyncState);
    }
    
    /// <remarks/>
    public System.Nullable<int>[] EndnextN(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((System.Nullable<int>[])(results[0]));
    }
    
    /// <remarks/>
    public void nextNAsync(int arg0) {
        this.nextNAsync(arg0, null);
    }
    
    /// <remarks/>
    public void nextNAsync(int arg0, object userState) {
        if ((this.nextNOperationCompleted == null)) {
            this.nextNOperationCompleted = new System.Threading.SendOrPostCallback(this.OnnextNOperationCompleted);
        }
        this.InvokeAsync("nextN", new object[] {
                    arg0}, this.nextNOperationCompleted, userState);
    }
    
    private void OnnextNOperationCompleted(object arg) {
        if ((this.nextNCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.nextNCompleted(this, new nextNCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    public new void CancelAsync(object userState) {
        base.CancelAsync(userState);
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
public delegate void next1CompletedEventHandler(object sender, next1CompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class next1CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal next1CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    /// <remarks/>
    public int Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((int)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
public delegate void nextNCompletedEventHandler(object sender, nextNCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class nextNCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal nextNCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    /// <remarks/>
    public System.Nullable<int>[] Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((System.Nullable<int>[])(this.results[0]));
        }
    }
}