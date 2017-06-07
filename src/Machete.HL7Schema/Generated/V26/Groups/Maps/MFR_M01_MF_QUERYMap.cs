// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// MFR_M01_MF_QUERY (GroupMap) - 
    /// </summary>
    public class MFR_M01_MF_QUERYMap :
        HL7V26LayoutMap<MFR_M01_MF_QUERY>
    {
        public MFR_M01_MF_QUERYMap()
        {
            Segment(x => x.MFE, 0, x => x.Required = true);
            Segment(x => x.Hxx, 1);
        }
    }
}