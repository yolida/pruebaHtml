﻿#pragma checksum "..\..\..\pages\FormPruebas.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "BFCDBB01D14EECC0D5FE26157EAF63E3A5A4CFEC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FEI.pages;
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


namespace FEI.pages {
    
    
    /// <summary>
    /// FormPruebas
    /// </summary>
    public partial class FormPruebas : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\pages\FormPruebas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSerieNumero;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\pages\FormPruebas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCodigoComprobante;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\pages\FormPruebas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtIdentificacionCliente;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\pages\FormPruebas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEjecutar;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\pages\FormPruebas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEjecutar_ConInterfaces;
        
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
            System.Uri resourceLocater = new System.Uri("/FEI;component/pages/formpruebas.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\pages\FormPruebas.xaml"
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
            this.txtSerieNumero = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtCodigoComprobante = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtIdentificacionCliente = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.btnEjecutar = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\pages\FormPruebas.xaml"
            this.btnEjecutar.Click += new System.Windows.RoutedEventHandler(this.Ejecutar_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnEjecutar_ConInterfaces = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\pages\FormPruebas.xaml"
            this.btnEjecutar_ConInterfaces.Click += new System.Windows.RoutedEventHandler(this.btnEjecutar_ConInterfaces_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

