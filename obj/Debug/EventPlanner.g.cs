﻿#pragma checksum "..\..\EventPlanner.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "577B00886B8F30328A1F70747ABAC9C5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using JuuniPraktika;
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


namespace JuuniPraktika {
    
    
    /// <summary>
    /// EventPlanner
    /// </summary>
    public partial class EventPlanner : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\EventPlanner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox PlannerListBox;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\EventPlanner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ClearAll;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\EventPlanner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Eventbox;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\EventPlanner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Timebox;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\EventPlanner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Placebox;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\EventPlanner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Commentbox;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\EventPlanner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddAll;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\EventPlanner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddComment;
        
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
            System.Uri resourceLocater = new System.Uri("/Planner;component/eventplanner.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\EventPlanner.xaml"
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
            this.PlannerListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 2:
            this.ClearAll = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\EventPlanner.xaml"
            this.ClearAll.Click += new System.Windows.RoutedEventHandler(this.ClearAll_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Eventbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Timebox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Placebox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.Commentbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.AddAll = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\EventPlanner.xaml"
            this.AddAll.Click += new System.Windows.RoutedEventHandler(this.AddAll_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.AddComment = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\EventPlanner.xaml"
            this.AddComment.Click += new System.Windows.RoutedEventHandler(this.AddComment_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

