﻿#pragma checksum "..\..\Admin_List.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4FBB66632FDDBC2255AD7D63E2ABE132"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using QuanLyDoanVien;
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


namespace QuanLyDoanVien {
    
    
    /// <summary>
    /// Admin_List
    /// </summary>
    public partial class Admin_List : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\Admin_List.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Admin_DataGrid;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Admin_List.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Add_admin;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Admin_List.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Modify_admin;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Admin_List.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Delete_admin;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Admin_List.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_Admin_ID;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Admin_List.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_Admin_Name;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Admin_List.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_Admin_Position;
        
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
            System.Uri resourceLocater = new System.Uri("/QuanLyDoanVien;component/admin_list.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Admin_List.xaml"
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
            this.Admin_DataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 13 "..\..\Admin_List.xaml"
            this.Admin_DataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Admin_DataGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Add_admin = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\Admin_List.xaml"
            this.Add_admin.Click += new System.Windows.RoutedEventHandler(this.Add_admin_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Modify_admin = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\Admin_List.xaml"
            this.Modify_admin.Click += new System.Windows.RoutedEventHandler(this.Modify_admin_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Delete_admin = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\Admin_List.xaml"
            this.Delete_admin.Click += new System.Windows.RoutedEventHandler(this.Delete_admin_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.tb_Admin_ID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.tb_Admin_Name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.tb_Admin_Position = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

