﻿#pragma checksum "..\..\..\..\Pages\Tracks.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4C9AFC09B78DF6BCBB7863CEF126C758C9F32D52"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PROG2500_A2_Chinook.Converters;
using PROG2500_A2_Chinook.Pages;
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


namespace PROG2500_A2_Chinook.Pages {
    
    
    /// <summary>
    /// Tracks
    /// </summary>
    public partial class Tracks : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\..\..\Pages\Tracks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TrackSearchTextBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.14.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/INFT3000_A_Chinook;V1.0.0.0;component/pages/tracks.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\Tracks.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.14.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.TrackSearchTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 35 "..\..\..\..\Pages\Tracks.xaml"
            this.TrackSearchTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.TrackSearchTextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 36 "..\..\..\..\Pages\Tracks.xaml"
            this.TrackSearchTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.TrackSearchTextBox_LostFocus);
            
            #line default
            #line hidden
            
            #line 37 "..\..\..\..\Pages\Tracks.xaml"
            this.TrackSearchTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SearchTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
