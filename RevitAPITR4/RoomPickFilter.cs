using Autodesk.Revit.DB;
using Autodesk.Revit.UI.Selection;

namespace RevitAPITR4
{
    public class RoomPickFilter : ISelectionFilter
    {
        public bool AllowElement(Element e) => e.Category.Id.IntegerValue.Equals(-2000160);

        public bool AllowReference(Reference r, XYZ p) => false;
    }
}
