﻿#pragma checksum "..\..\..\Frames\AddOrEditWorker.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "37C684CB4F997C9E9E57C6AC02DF498878B1E49CFC7D00E3A350C9D1A5413815"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using ProjectAndSolutions.Frames;
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


namespace ProjectAndSolutions.Frames {
    
    
    /// <summary>
    /// AddOrEditWorker
    /// </summary>
    public partial class AddOrEditWorker : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\..\Frames\AddOrEditWorker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBoxLogin;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Frames\AddOrEditWorker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBoxPassword;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Frames\AddOrEditWorker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBoxLastName;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Frames\AddOrEditWorker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CBoxWorkerDevision;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Frames\AddOrEditWorker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBoxPatronymic;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Frames\AddOrEditWorker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBoxCityAccommodation;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Frames\AddOrEditWorker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnOK;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Frames\AddOrEditWorker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCancel;
        
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
            System.Uri resourceLocater = new System.Uri("/ProjectAndSolutions;component/frames/addoreditworker.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Frames\AddOrEditWorker.xaml"
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
            
            #line 9 "..\..\..\Frames\AddOrEditWorker.xaml"
            ((ProjectAndSolutions.Frames.AddOrEditWorker)(target)).IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.PageIsVisibleChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TBoxLogin = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TBoxPassword = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TBoxLastName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.CBoxWorkerDevision = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.TBoxPatronymic = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.TBoxCityAccommodation = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.BtnOK = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\Frames\AddOrEditWorker.xaml"
            this.BtnOK.Click += new System.Windows.RoutedEventHandler(this.BtnOkClick);
            
            #line default
            #line hidden
            return;
            case 9:
            this.BtnCancel = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\Frames\AddOrEditWorker.xaml"
            this.BtnCancel.Click += new System.Windows.RoutedEventHandler(this.BtnCancelClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

