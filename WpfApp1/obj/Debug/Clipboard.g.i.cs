﻿#pragma checksum "..\..\Clipboard.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "631A1DA371BDAC8228F837E2B2EED6FEEB97A468"
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
using WpfApp1;


namespace WpfApp1 {
    
    
    /// <summary>
    /// Clipboard
    /// </summary>
    public partial class Clipboard : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\Clipboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label num;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\Clipboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Email;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\Clipboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Print;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\Clipboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox userEmail;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\Clipboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ScrollBar disable;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\Clipboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label End;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/clipboard.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Clipboard.xaml"
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
            
            #line 11 "..\..\Clipboard.xaml"
            ((System.Windows.Controls.Image)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Back_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 14 "..\..\Clipboard.xaml"
            ((System.Windows.Controls.Image)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Back_MouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.num = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            
            #line 43 "..\..\Clipboard.xaml"
            ((System.Windows.Controls.Image)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Trash_MouseDown);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 44 "..\..\Clipboard.xaml"
            ((System.Windows.Controls.Image)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Trash_MouseDown);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 45 "..\..\Clipboard.xaml"
            ((System.Windows.Controls.Image)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Trash_MouseDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Email = ((System.Windows.Controls.Image)(target));
            
            #line 48 "..\..\Clipboard.xaml"
            this.Email.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Email_MouseDown);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Print = ((System.Windows.Controls.Image)(target));
            
            #line 59 "..\..\Clipboard.xaml"
            this.Print.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Print_MouseDown);
            
            #line default
            #line hidden
            return;
            case 9:
            this.userEmail = ((System.Windows.Controls.TextBox)(target));
            
            #line 72 "..\..\Clipboard.xaml"
            this.userEmail.MouseEnter += new System.Windows.Input.MouseEventHandler(this.enterEmail);
            
            #line default
            #line hidden
            
            #line 72 "..\..\Clipboard.xaml"
            this.userEmail.MouseLeave += new System.Windows.Input.MouseEventHandler(this.restorePrompt);
            
            #line default
            #line hidden
            return;
            case 10:
            this.disable = ((System.Windows.Controls.Primitives.ScrollBar)(target));
            return;
            case 11:
            this.End = ((System.Windows.Controls.Label)(target));
            
            #line 74 "..\..\Clipboard.xaml"
            this.End.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Label_MouseDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

