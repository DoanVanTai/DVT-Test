#region Namespaces

using System.Windows;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Application = Autodesk.Revit.ApplicationServices.Application;
#endregion

namespace TGL
{
    [Transaction(TransactionMode.Manual)]
    public class ViewRenameCmd : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData,
            ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Application app = uiapp.Application;
            Document doc = uidoc.Document;

            // code

            using (TransactionGroup transG = new TransactionGroup(doc))
            {
                transG.Start();
                
                ViewRenameViewModel viewModel = new ViewRenameViewModel(uidoc);
                ViewRenameWindow window = new ViewRenameWindow(viewModel);

                bool? showDialog = window.ShowDialog();

                if (showDialog == null || showDialog == false)
                {
                    transG.RollBack();
                    return Result.Cancelled;
                }
                transG.Assimilate();
                return Result.Succeeded;
            }


        }
    }
}