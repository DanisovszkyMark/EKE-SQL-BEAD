﻿#pragma checksum "..\..\ChangeUserDataViewWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20BED4FDF4910497BC29EDE11E820A6B493B70B5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using WPF_client;


namespace WPF_client {
    
    
    /// <summary>
    /// ChangeUserDataViewWindow
    /// </summary>
    public partial class ChangeUserDataViewWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\ChangeUserDataViewWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_username;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\ChangeUserDataViewWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_newPassword;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\ChangeUserDataViewWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox pb_newPassword;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\ChangeUserDataViewWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_password;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\ChangeUserDataViewWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox pb_password;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\ChangeUserDataViewWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cb_show_password;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\ChangeUserDataViewWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_ok;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPF_client;component/changeuserdataviewwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ChangeUserDataViewWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.tb_username = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.tb_newPassword = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.pb_newPassword = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 4:
            this.tb_password = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.pb_password = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 6:
            this.cb_show_password = ((System.Windows.Controls.CheckBox)(target));
            
            #line 37 "..\..\ChangeUserDataViewWindow.xaml"
            this.cb_show_password.Checked += new System.Windows.RoutedEventHandler(this.cb_show_password_Checked);
            
            #line default
            #line hidden
            
            #line 37 "..\..\ChangeUserDataViewWindow.xaml"
            this.cb_show_password.Unchecked += new System.Windows.RoutedEventHandler(this.cb_show_password_Unchecked);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btn_ok = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\ChangeUserDataViewWindow.xaml"
            this.btn_ok.Click += new System.Windows.RoutedEventHandler(this.btn_ok_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

