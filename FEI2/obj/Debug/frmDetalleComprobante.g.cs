﻿#pragma checksum "..\..\frmDetalleComprobante.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "024650E97E8ABFDA67BB125D88E27385C1485647"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FEI;
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


namespace FEI {
    
    
    /// <summary>
    /// frmDetalleComprobante
    /// </summary>
    public partial class frmDetalleComprobante : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\frmDetalleComprobante.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTipoComprobante;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\frmDetalleComprobante.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSerieNumero;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\frmDetalleComprobante.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtRuc;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\frmDetalleComprobante.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtFechaEmision;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\frmDetalleComprobante.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtRazonSocial;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\frmDetalleComprobante.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgEmpresas;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\frmDetalleComprobante.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnXMLEnvio;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\frmDetalleComprobante.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnXMLRecepcion;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\frmDetalleComprobante.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRepresentacionImpresa;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\frmDetalleComprobante.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRemover;
        
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
            System.Uri resourceLocater = new System.Uri("/FEI;component/frmdetallecomprobante.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\frmDetalleComprobante.xaml"
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
            
            #line 8 "..\..\frmDetalleComprobante.xaml"
            ((FEI.frmDetalleComprobante)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 8 "..\..\frmDetalleComprobante.xaml"
            ((FEI.frmDetalleComprobante)(target)).KeyDown += new System.Windows.Input.KeyEventHandler(this.Window_KeyDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtTipoComprobante = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtSerieNumero = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtRuc = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtFechaEmision = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtRazonSocial = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.dgEmpresas = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 8:
            this.btnXMLEnvio = ((System.Windows.Controls.Button)(target));
            
            #line 99 "..\..\frmDetalleComprobante.xaml"
            this.btnXMLEnvio.Click += new System.Windows.RoutedEventHandler(this.btnXMLEnvio_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnXMLRecepcion = ((System.Windows.Controls.Button)(target));
            
            #line 101 "..\..\frmDetalleComprobante.xaml"
            this.btnXMLRecepcion.Click += new System.Windows.RoutedEventHandler(this.btnXMLRecepcion_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnRepresentacionImpresa = ((System.Windows.Controls.Button)(target));
            
            #line 104 "..\..\frmDetalleComprobante.xaml"
            this.btnRepresentacionImpresa.Click += new System.Windows.RoutedEventHandler(this.btnRepresentacionImpresa_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btnRemover = ((System.Windows.Controls.Button)(target));
            
            #line 107 "..\..\frmDetalleComprobante.xaml"
            this.btnRemover.Click += new System.Windows.RoutedEventHandler(this.btnRemover_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

