﻿#pragma checksum "..\..\Main.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8871CB94FB7D350FD14D4C76901C822B4456DB74"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using CifradosGenerico;
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


namespace CifradosGenerico {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label test;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmb_cesar_1;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_cifrar;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmb_reverseg_1;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox res_cesar;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox res_reverse;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox res_reverseg;
        
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
            System.Uri resourceLocater = new System.Uri("/CifradosGenerico;component/main.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Main.xaml"
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
            this.test = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.cmb_cesar_1 = ((System.Windows.Controls.ComboBox)(target));
            
            #line 12 "..\..\Main.xaml"
            this.cmb_cesar_1.DropDownClosed += new System.EventHandler(this.eventoSalto);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txt_cifrar = ((System.Windows.Controls.TextBox)(target));
            
            #line 25 "..\..\Main.xaml"
            this.txt_cifrar.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.change);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cmb_reverseg_1 = ((System.Windows.Controls.ComboBox)(target));
            
            #line 28 "..\..\Main.xaml"
            this.cmb_reverseg_1.DropDownClosed += new System.EventHandler(this.eventoGrupo);
            
            #line default
            #line hidden
            return;
            case 5:
            this.res_cesar = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.res_reverse = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.res_reverseg = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
