﻿#pragma checksum "..\..\..\..\Pages\PageMain.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24AE2E7AB08129FCF8BC79095044AE48B6919C04"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MiniShop_.NET_6.Pages;
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


namespace MiniShop_.NET_6.Pages {
    
    
    /// <summary>
    /// PageMain
    /// </summary>
    public partial class PageMain : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\..\Pages\PageMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnClients;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\Pages\PageMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAddClient;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\Pages\PageMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnProducts;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\Pages\PageMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAddProduct;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\Pages\PageMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnOrders;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\Pages\PageMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAddOrder;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MiniShop .NET 6;component/pages/pagemain.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\PageMain.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.BtnClients = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\..\Pages\PageMain.xaml"
            this.BtnClients.Click += new System.Windows.RoutedEventHandler(this.BtnClients_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BtnAddClient = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\..\Pages\PageMain.xaml"
            this.BtnAddClient.Click += new System.Windows.RoutedEventHandler(this.BtnAddClient_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnProducts = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\..\Pages\PageMain.xaml"
            this.BtnProducts.Click += new System.Windows.RoutedEventHandler(this.BtnProducts_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnAddProduct = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\..\Pages\PageMain.xaml"
            this.BtnAddProduct.Click += new System.Windows.RoutedEventHandler(this.BtnAddProduct_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BtnOrders = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\..\Pages\PageMain.xaml"
            this.BtnOrders.Click += new System.Windows.RoutedEventHandler(this.BtnOrders_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BtnAddOrder = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\..\Pages\PageMain.xaml"
            this.BtnAddOrder.Click += new System.Windows.RoutedEventHandler(this.BtnAddOrder_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

