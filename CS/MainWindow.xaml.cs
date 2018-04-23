using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;
using System.Windows.Controls;
using System.Windows.Media;
using System.ComponentModel;
using DevExpress.Xpf.PropertyGrid;

namespace DXSample {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
        private void PropertyGridControl_ValidateCell(object sender, ValidateCellEventArgs e) {
            if (e.NewValue == null || string.IsNullOrEmpty(e.NewValue.ToString()))
                e.ValidationException = new System.Exception("A cell cannot be empty");
        }
    }
}