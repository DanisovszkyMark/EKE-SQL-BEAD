﻿#pragma checksum "..\..\LoginWindowView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3566B8768D5D28631A2490059529EC6AC828E8D5"
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
    /// LoginWindowView
    /// </summary>
    public partial class LoginWindowView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\LoginWindowView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_username;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\LoginWindowView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox pb_password;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\LoginWindowView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_signUp;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\LoginWindowView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_login;
        
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
            System.Uri resourceLocater = new System.Uri("/WPF_client;component/loginwindowview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\LoginWindowView.xaml"
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
            this.pb_password = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 3:
            this.lbl_signUp = ((System.Windows.Controls.Label)(target));
            
            #line 30 "..\..\LoginWindowView.xaml"
            this.lbl_signUp.MouseEnter += new System.Windows.Input.MouseEventHandler(this.lbl_signUp_MouseEnter);
            
            #line default
            #line hidden
            
            #line 30 "..\..\LoginWindowView.xaml"
            this.lbl_signUp.MouseLeave += new System.Windows.Input.MouseEventHandler(this.lbl_signUp_MouseLeave);
            
            #line default
            #line hidden
            
            #line 30 "..\..\LoginWindowView.xaml"
            this.lbl_signUp.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.lbl_signUp_MouseUp);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btn_login = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\LoginWindowView.xaml"
            this.btn_login.Click += new System.Windows.RoutedEventHandler(this.btn_login_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

