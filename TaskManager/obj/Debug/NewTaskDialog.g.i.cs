﻿#pragma checksum "..\..\NewTaskDialog.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "FE19066A0A00BF3BDE44582735748D363F943A25"
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
using TaskManager;


namespace TaskManager {
    
    
    /// <summary>
    /// NewTaskDialog
    /// </summary>
    public partial class NewTaskDialog : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\NewTaskDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label TitleLabel;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\NewTaskDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ContentLabel;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\NewTaskDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox contentTextBox;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\NewTaskDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label CalendarLabel;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\NewTaskDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Calendar dueDateCalendar;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\NewTaskDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label PriorityLabel;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\NewTaskDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox priorityComboBox;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\NewTaskDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OkButton;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\NewTaskDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CancelButton;
        
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
            System.Uri resourceLocater = new System.Uri("/TaskManager;component/newtaskdialog.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\NewTaskDialog.xaml"
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
            this.TitleLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.ContentLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.contentTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.CalendarLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.dueDateCalendar = ((System.Windows.Controls.Calendar)(target));
            return;
            case 6:
            this.PriorityLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.priorityComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.OkButton = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\NewTaskDialog.xaml"
            this.OkButton.Click += new System.Windows.RoutedEventHandler(this.OkButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.CancelButton = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\NewTaskDialog.xaml"
            this.CancelButton.Click += new System.Windows.RoutedEventHandler(this.CancelButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

