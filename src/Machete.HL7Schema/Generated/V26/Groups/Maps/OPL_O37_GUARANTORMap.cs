// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OPL_O37_GUARANTOR (GroupMap) - 
    /// </summary>
    public class OPL_O37_GUARANTORMap :
        HL7LayoutMap<OPL_O37_GUARANTOR>
    {
        public OPL_O37_GUARANTORMap()
        {
            Segment(x => x.GT1, 0, x => x.Required = true);
            Segment(x => x.NTE, 1);
        }
    }
}