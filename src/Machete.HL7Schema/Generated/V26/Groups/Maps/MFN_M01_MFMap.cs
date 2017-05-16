// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// MFN_M01_MF (GroupMap) - 
    /// </summary>
    public class MFN_M01_MFMap :
        HL7LayoutMap<MFN_M01_MF>
    {
        public MFN_M01_MFMap()
        {
            Segment(x => x.MFE, 0, x => x.Required = true);
            Segment(x => x.Hxx, 1);
        }
    }
}