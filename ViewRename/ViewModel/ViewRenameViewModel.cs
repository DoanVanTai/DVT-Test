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

using View = Autodesk.Revit.DB.View;

#endregion

namespace TGL
{
    public class ViewRenameViewModel : ViewModelBase
    {
        public UIDocument UiDoc;
        public Document Doc;
        
        public ViewRenameViewModel(UIDocument uidoc)
        {
            Doc = uidoc.Document;
            UiDoc = uidoc;
            GetInforFamilyToView();
        }
        
        public ObservableCollection<ViewExtension> AllViewsExtension { get; set; } = new ObservableCollection<ViewExtension>();
        public List<ViewExtension> SelectedViewsExtension { get; set; }
        private void GetInforFamilyToView()
        {
            ViewExtension level1 = new ViewExtension("Structural Framing");

            ICollection<Element> eles = GetInfor.GetAllFamilyInstance(Doc);

            foreach (Element ele in eles)
            {
                
                ViewExtension level2 = new ViewExtension(ele);

                level1.ViewItems.Add(level2);

                List<string> AllInforRebar = GetInfor.GetAllInforRebar(Doc, ele);

                if (!AllInforRebar.Any()) continue;

                foreach (string InforRebar in AllInforRebar)
                {
                    ViewExtension level3 = new ViewExtension(InforRebar);
                    level2.ViewItems.Add(level3);
                }
            }

            AllViewsExtension = new ObservableCollection<ViewExtension>();
            AllViewsExtension.Add(level1);
        }

    }

}
