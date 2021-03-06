﻿using System;
using System.Globalization;
using System.Reflection;
using System.Windows;

namespace Decomp.Windows
{
    public partial class AboutWindow
    {
        public AboutWindow()
        {
            InitializeComponent();
            this.AttachCustomSystemMenu();
            var version = Assembly.GetEntryAssembly().GetName().Version;
            var v = $"{version.Major}.{version.Minor}.{version.Build}";
            VersionTextBlock.Text = String.Format(CultureInfo.GetCultureInfo("en-US"), Application.GetResource("LocalizationVersion"), v);
        }

        private void OkButtonClick(object sender, RoutedEventArgs e) => Close();
    }
}
