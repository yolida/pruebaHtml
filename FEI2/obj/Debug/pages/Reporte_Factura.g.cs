﻿#pragma checksum "..\..\..\pages\Reporte_Factura.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5C65B9A864E1795A5A0D200A3AC721B5CD78BD6F"
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
    /// Reporte_Factura
    /// </summary>
    public partial class Reporte_Factura : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 297 "..\..\..\pages\Reporte_Factura.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label;
        
        #line default
        #line hidden
        
        
        #line 329 "..\..\..\pages\Reporte_Factura.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboTipoComprobante;
        
        #line default
        #line hidden
        
        
        #line 330 "..\..\..\pages\Reporte_Factura.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboEstadoSCC;
        
        #line default
        #line hidden
        
        
        #line 331 "..\..\..\pages\Reporte_Factura.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboEstadoSunat;
        
        #line default
        #line hidden
        
        
        #line 334 "..\..\..\pages\Reporte_Factura.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FEI.pages.DatePickerEx datePick_inicio;
        
        #line default
        #line hidden
        
        
        #line 335 "..\..\..\pages\Reporte_Factura.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FEI.pages.DatePickerEx datePick_fin;
        
        #line default
        #line hidden
        
        
        #line 339 "..\..\..\pages\Reporte_Factura.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imageButton;
        
        #line default
        #line hidden
        
        
        #line 345 "..\..\..\pages\Reporte_Factura.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgComprobantes;
        
        #line default
        #line hidden
        
        
        #line 523 "..\..\..\pages\Reporte_Factura.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btncdr;
        
        #line default
        #line hidden
        
        
        #line 532 "..\..\..\pages\Reporte_Factura.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboDownload;
        
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
            System.Uri resourceLocater = new System.Uri("/FEI;component/pages/reporte_factura.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\pages\Reporte_Factura.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            
            #line 7 "..\..\..\pages\Reporte_Factura.xaml"
            ((FEI.pages.Reporte_Factura)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            
            #line 7 "..\..\..\pages\Reporte_Factura.xaml"
            ((FEI.pages.Reporte_Factura)(target)).KeyDown += new System.Windows.Input.KeyEventHandler(this.Page_KeyDown);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 10 "..\..\..\pages\Reporte_Factura.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.DetalleItem_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.label = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.cboTipoComprobante = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.cboEstadoSCC = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.cboEstadoSunat = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.datePick_inicio = ((FEI.pages.DatePickerEx)(target));
            return;
            case 8:
            this.datePick_fin = ((FEI.pages.DatePickerEx)(target));
            return;
            case 9:
            
            #line 337 "..\..\..\pages\Reporte_Factura.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnFiltro_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.imageButton = ((System.Windows.Controls.Image)(target));
            return;
            case 11:
            this.dgComprobantes = ((System.Windows.Controls.DataGrid)(target));
            
            #line 345 "..\..\..\pages\Reporte_Factura.xaml"
            this.dgComprobantes.AddHandler(System.Windows.Input.Mouse.MouseUpEvent, new System.Windows.Input.MouseButtonEventHandler(this.m_Verificar_Duplicidad));
            
            #line default
            #line hidden
            return;
            case 12:
            this.btncdr = ((System.Windows.Controls.Button)(target));
            
            #line 523 "..\..\..\pages\Reporte_Factura.xaml"
            this.btncdr.Click += new System.Windows.RoutedEventHandler(this.btnDescargaCDR_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.cboDownload = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 14:
            
            #line 533 "..\..\..\pages\Reporte_Factura.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnReporte_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

