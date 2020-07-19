// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ORM_O01 (MessageMap) - 
    /// </summary>
    public class ORM_O01Map :
        HL7V26LayoutMap<ORM_O01>
    {
        public ORM_O01Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.NTE, 1);
            Layout(x => x.Patient, 2);
            Layout(x => x.Order, 3, x => x.Required = true);
        }
    }
}