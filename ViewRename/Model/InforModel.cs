#region Namespaces

using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using Autodesk.Revit.DB.Structure;
using Autodesk.Revit.UI;

#endregion

namespace TGL
{
    public class InfoModel : ViewModelBase
    {
        public UIDocument UiDoc;
        public Document Doc;
        
        public InfoModel(Document doc, Element e)
        {
            BeamName = e.LookupParameter("00.BeamName").AsString();
            TopMainRebar = e.LookupParameter("01.Top_MainRebar").AsString();
            BotMainRebar = e.LookupParameter("02.Bot_MainRebar").AsString();

            ElementId beam_Cover_Id_Top = e.get_Parameter(BuiltInParameter.CLEAR_COVER_TOP).AsElementId();
            ElementId beam_Cover_Id_Bot = e.get_Parameter(BuiltInParameter.CLEAR_COVER_BOTTOM).AsElementId();
            ElementId beam_Cover_Id_Other = e.get_Parameter(BuiltInParameter.CLEAR_COVER_OTHER).AsElementId();

            RebarCoverType beam_Cover_Top = doc.GetElement(beam_Cover_Id_Top) as RebarCoverType;
            RebarCoverType beam_Cover_Bot = doc.GetElement(beam_Cover_Id_Top) as RebarCoverType;
            RebarCoverType beam_Cover_Other = doc.GetElement(beam_Cover_Id_Top) as RebarCoverType;
           
            TopConcrete = beam_Cover_Top.CoverDistance;
            BotConcrete = beam_Cover_Bot.CoverDistance;
            OtherConcrete = beam_Cover_Other.CoverDistance;

        }

        private string _BeamName;
        public string BeamName { get => _BeamName; set { _BeamName = value; OnPropertyChanged(); } }
        private string _TopMainRebar;
        public string TopMainRebar { get => _TopMainRebar; set { _TopMainRebar = value; OnPropertyChanged(); } }
        private string _BotMainRebar;
        public string BotMainRebar { get => _BotMainRebar; set { _BotMainRebar = value; OnPropertyChanged(); } }
       
        private double _TopConcrete;
        public double TopConcrete { get => _TopConcrete; set { _TopConcrete = value; OnPropertyChanged(); } }

        private double _BotConcrete;
        public double BotConcrete { get => _BotConcrete; set { _BotConcrete = value; OnPropertyChanged(); } }

        private double _OtherConcrete;
        public double OtherConcrete { get => _OtherConcrete; set { _OtherConcrete = value; OnPropertyChanged(); } }


    }

}
