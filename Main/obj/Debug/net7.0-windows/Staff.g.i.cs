﻿#pragma checksum "..\..\..\Staff.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "297596606C12B575F52095253703B2C294239AE6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Main;
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


namespace Main {
    
    
    /// <summary>
    /// Staff
    /// </summary>
    public partial class Staff : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 62 "..\..\..\Staff.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox StName;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\Staff.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox StPhone;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\Staff.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox StGender;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\Staff.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox StPass;
        
        #line default
        #line hidden
        
        
        #line 115 "..\..\..\Staff.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid StaffList;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Main;component/staff.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Staff.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 9 "..\..\..\Staff.xaml"
            ((Main.Staff)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Form_load);
            
            #line default
            #line hidden
            return;
            case 2:
            this.StName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.StPhone = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.StGender = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.StPass = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            
            #line 84 "..\..\..\Staff.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Add_Button);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 91 "..\..\..\Staff.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Edit_Button);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 98 "..\..\..\Staff.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Delete_Button);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 105 "..\..\..\Staff.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Reset_Button);
            
            #line default
            #line hidden
            return;
            case 10:
            this.StaffList = ((System.Windows.Controls.DataGrid)(target));
            
            #line 115 "..\..\..\Staff.xaml"
            this.StaffList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.StaffList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 118 "..\..\..\Staff.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LogOut);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

