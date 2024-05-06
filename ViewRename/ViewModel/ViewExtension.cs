#region Namespaces
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Threading;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Structure;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;

using ComboBox = System.Windows.Forms.ComboBox;
using MessageBox = System.Windows.Forms.MessageBox;

#endregion

namespace TGL
{
    public class ViewExtension : ViewModelBase
    {
        public ViewExtension(string name)
        {
            ViewItems = new ObservableCollection<ViewExtension>();
            Name = name;
            IsSelected = false;
        }

        public ViewExtension(Element e)
        {
            ViewItems = new ObservableCollection<ViewExtension>();
            Name = e.Name;
            IsSelected = false;
        }

        public ObservableCollection<ViewExtension> ViewItems { get; set; }

        private string _name;
        public string Name { get => _name; set { _name = value; OnPropertyChanged(); } }
        private bool _isSelected;
        public bool IsSelected {get => _isSelected; set { _isSelected = value; OnPropertyChanged(); } }
    }

}
