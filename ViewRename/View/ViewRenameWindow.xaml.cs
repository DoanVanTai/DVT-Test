using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using Autodesk.Revit.DB;


namespace TGL
{
    public partial class ViewRenameWindow
    {
        private ViewRenameViewModel _viewModel;
        
        
        public ViewRenameWindow(ViewRenameViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
            DataContext = _viewModel;
           
        }
        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
           // _viewModel.TransferParameter(ProgressWindow1);
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
        private void TreeView_OnChecked(object sender, RoutedEventArgs e)
        {
            // code
        }
    }


}