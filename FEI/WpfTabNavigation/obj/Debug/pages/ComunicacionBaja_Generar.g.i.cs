﻿#pragma checksum "..\..\..\pages\ComunicacionBaja_Generar.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7AB0A6A4F26BEAB807072DCC40AC3321"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
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
    /// ComunicacionBaja_Generar
    /// </summary>
    public partial class ComunicacionBaja_Generar : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 78 "..\..\..\pages\ComunicacionBaja_Generar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\pages\ComunicacionBaja_Generar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboTipoComprobante;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\pages\ComunicacionBaja_Generar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboEstadoSCC;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\pages\ComunicacionBaja_Generar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboEstadoSunat;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\pages\ComunicacionBaja_Generar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker datePick_inicio;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\pages\ComunicacionBaja_Generar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker datePick_fin;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\pages\ComunicacionBaja_Generar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgComprobantes;
        
        #line default
        #line hidden
        
        
        #line 221 "..\..\..\pages\ComunicacionBaja_Generar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEnviarSunat;
        
        #line default
        #line hidden
        
        
        #line 224 "..\..\..\pages\ComunicacionBaja_Generar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label TextoBoton;
        
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
            System.Uri resourceLocater = new System.Uri("/FEIv2;component/pages/comunicacionbaja_generar.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\pages\ComunicacionBaja_Generar.xaml"
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
            
            #line 8 "..\..\..\pages\ComunicacionBaja_Generar.xaml"
            ((FEI.pages.ComunicacionBaja_Generar)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.label = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.cboTipoComprobante = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.cboEstadoSCC = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.cboEstadoSunat = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.datePick_inicio = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 7:
            this.datePick_fin = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 8:
            
            #line 105 "..\..\..\pages\ComunicacionBaja_Generar.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnFiltrar_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.dgComprobantes = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 11:
            this.btnEnviarSunat = ((System.Windows.Controls.Button)(target));
            
            #line 221 "..\..\..\pages\ComunicacionBaja_Generar.xaml"
            this.btnEnviarSunat.Click += new System.Windows.RoutedEventHandler(this.btnEnviarSunat_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.TextoBoton = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 10:
            
            #line 122 "..\..\..\pages\ComunicacionBaja_Generar.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.chkDiscontinue_Checked);
            
            #line default
            #line hidden
            
            #line 122 "..\..\..\pages\ComunicacionBaja_Generar.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.chkDiscontinue_Unchecked);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

