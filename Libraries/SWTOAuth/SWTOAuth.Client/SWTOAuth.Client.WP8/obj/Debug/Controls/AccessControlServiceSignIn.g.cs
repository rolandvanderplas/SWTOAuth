﻿#pragma checksum "C:\Users\v-ahsab\Documents\Visual Studio 2012\Projects\Demos\OAuthWebAPIDemo\Libraries\SWTOAuth\SWTOAuth.Client\SWTOAuth.Client.WP8\Controls\AccessControlServiceSignIn.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "85B0FE68E1E72D896496CB2DA270C199"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18010
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace SWTOAuth.Client.WP8.Controls {
    
    
    public partial class AccessControlServiceSignIn : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel progressBar;
        
        internal System.Windows.Controls.TextBlock progressBarLabel;
        
        internal System.Windows.Controls.StackPanel identityProviderDiscovery;
        
        internal System.Windows.Controls.Grid HomeRealmSelection;
        
        internal System.Windows.Controls.ListBox IdentityProviderList;
        
        internal Microsoft.Phone.Controls.WebBrowser BrowserSigninControl;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/SWTOAuth.Client.WP8;component/Controls/AccessControlServiceSignIn.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.progressBar = ((System.Windows.Controls.StackPanel)(this.FindName("progressBar")));
            this.progressBarLabel = ((System.Windows.Controls.TextBlock)(this.FindName("progressBarLabel")));
            this.identityProviderDiscovery = ((System.Windows.Controls.StackPanel)(this.FindName("identityProviderDiscovery")));
            this.HomeRealmSelection = ((System.Windows.Controls.Grid)(this.FindName("HomeRealmSelection")));
            this.IdentityProviderList = ((System.Windows.Controls.ListBox)(this.FindName("IdentityProviderList")));
            this.BrowserSigninControl = ((Microsoft.Phone.Controls.WebBrowser)(this.FindName("BrowserSigninControl")));
        }
    }
}

