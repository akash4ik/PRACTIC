﻿#pragma checksum "..\..\..\Kabinet.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3BEED0BA51AC7A994F7E67196C2CD543F7DB5D06"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
    /// Kabinet
    /// </summary>
    public partial class Kabinet : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\Kabinet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NewEmail;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Kabinet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Newepass;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Kabinet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button emailizm;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Kabinet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button passizm;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/kabinet.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Kabinet.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.NewEmail = ((System.Windows.Controls.TextBox)(target));
            
            #line 12 "..\..\..\Kabinet.xaml"
            this.NewEmail.GotFocus += new System.Windows.RoutedEventHandler(this.NewEmail_GotFocus);
            
            #line default
            #line hidden
            
            #line 12 "..\..\..\Kabinet.xaml"
            this.NewEmail.LostFocus += new System.Windows.RoutedEventHandler(this.NewEmail_LostFocus);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Newepass = ((System.Windows.Controls.TextBox)(target));
            
            #line 13 "..\..\..\Kabinet.xaml"
            this.Newepass.GotFocus += new System.Windows.RoutedEventHandler(this.Newepass_GotFocus);
            
            #line default
            #line hidden
            
            #line 13 "..\..\..\Kabinet.xaml"
            this.Newepass.LostFocus += new System.Windows.RoutedEventHandler(this.Newepass_LostFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.emailizm = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\Kabinet.xaml"
            this.emailizm.Click += new System.Windows.RoutedEventHandler(this.emailizm_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.passizm = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\Kabinet.xaml"
            this.passizm.Click += new System.Windows.RoutedEventHandler(this.passizm_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

