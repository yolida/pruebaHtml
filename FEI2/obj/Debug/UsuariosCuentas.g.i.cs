﻿#pragma checksum "..\..\UsuariosCuentas.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5542BBD53943CE3B7E387CB3FA033B75927CCE2F"
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
    /// UsuariosCuentas
    /// </summary>
    public partial class UsuariosCuentas : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 68 "..\..\UsuariosCuentas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboEmpresas;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\UsuariosCuentas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGuardar;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\UsuariosCuentas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imageBoton;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\UsuariosCuentas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label TextBoton;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\UsuariosCuentas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgEmpresas;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\UsuariosCuentas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRemover;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\UsuariosCuentas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imageRemover;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\UsuariosCuentas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label TextRemover;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\UsuariosCuentas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSalir;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\UsuariosCuentas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imageSalir;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\UsuariosCuentas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label TextSalir;
        
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
            System.Uri resourceLocater = new System.Uri("/FEI;component/usuarioscuentas.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UsuariosCuentas.xaml"
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
            
            #line 8 "..\..\UsuariosCuentas.xaml"
            ((FEI.UsuariosCuentas)(target)).KeyDown += new System.Windows.Input.KeyEventHandler(this.Window_KeyDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cboEmpresas = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.btnGuardar = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\UsuariosCuentas.xaml"
            this.btnGuardar.Click += new System.Windows.RoutedEventHandler(this.btnGuardar_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.imageBoton = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.TextBoton = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.dgEmpresas = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            this.btnRemover = ((System.Windows.Controls.Button)(target));
            
            #line 99 "..\..\UsuariosCuentas.xaml"
            this.btnRemover.Click += new System.Windows.RoutedEventHandler(this.btnRemover_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.imageRemover = ((System.Windows.Controls.Image)(target));
            return;
            case 9:
            this.TextRemover = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.btnSalir = ((System.Windows.Controls.Button)(target));
            
            #line 105 "..\..\UsuariosCuentas.xaml"
            this.btnSalir.Click += new System.Windows.RoutedEventHandler(this.btnSalir_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.imageSalir = ((System.Windows.Controls.Image)(target));
            return;
            case 12:
            this.TextSalir = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
