﻿#pragma checksum "..\..\..\Windows\AddNewCostumerWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B260FF59F21EEA74ED2B30C65ADE03E0"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using ThirdDay.Windows;


namespace ThirdDay.Windows {
    
    
    /// <summary>
    /// AddNewCostumerWindow
    /// </summary>
    public partial class AddNewCostumerWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\Windows\AddNewCostumerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxName;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Windows\AddNewCostumerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxPhone;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Windows\AddNewCostumerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxBank;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Windows\AddNewCostumerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxAccount;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Windows\AddNewCostumerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxINN;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Windows\AddNewCostumerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxAddress;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Windows\AddNewCostumerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxFioWorker;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Windows\AddNewCostumerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxPnoneWorker;
        
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
            System.Uri resourceLocater = new System.Uri("/ThirdDay;component/windows/addnewcostumerwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\AddNewCostumerWindow.xaml"
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
            
            #line 10 "..\..\..\Windows\AddNewCostumerWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.click_Back);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tbxName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.tbxPhone = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tbxBank = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.tbxAccount = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.tbxINN = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.tbxAddress = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.tbxFioWorker = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.tbxPnoneWorker = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            
            #line 53 "..\..\..\Windows\AddNewCostumerWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.click_AddNewCostumer);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

