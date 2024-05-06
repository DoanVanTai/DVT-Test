#region Namespaces

using System.Collections.Generic;
using System.Linq;
using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Structure;
using View = Autodesk.Revit.DB.View;

#endregion

namespace TGL
{
    public static class GetInfor
    {
        public static ICollection<Element> GetAllFamilyInstance(Document doc)
        {
            ICollection<Element> familyInstances = new FilteredElementCollector(doc)
                .OfCategory(BuiltInCategory.OST_StructuralFraming)
                .OfClass(typeof(FamilyInstance))
                .ToElements();

            return familyInstances;
        }
        public static List<string> GetAllInforRebar(Document doc, Element e)
        {

            InfoModel infoModel = new InfoModel(doc, e);
            List<string> resultViews = new List<string>();

            resultViews.Add(infoModel.BeamName);
            resultViews.Add(infoModel.TopMainRebar);
            resultViews.Add(infoModel.BotMainRebar);

            return resultViews;
        }

        public static List<double> GetAllInforConcrete(Document doc, Element e)
        {

            InfoModel infoModel = new InfoModel(doc, e);
            List<double> resultViews = new List<double>();

            resultViews.Add(infoModel.TopConcrete);
            resultViews.Add(infoModel.BotConcrete);
            resultViews.Add(infoModel.OtherConcrete);

            return resultViews;
        }
    }
}
