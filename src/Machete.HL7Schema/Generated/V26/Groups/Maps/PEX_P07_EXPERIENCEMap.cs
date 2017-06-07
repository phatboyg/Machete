// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PEX_P07_EXPERIENCE (GroupMap) - 
    /// </summary>
    public class PEX_P07_EXPERIENCEMap :
        HL7V26LayoutMap<PEX_P07_EXPERIENCE>
    {
        public PEX_P07_EXPERIENCEMap()
        {
            Segment(x => x.PES, 0, x => x.Required = true);
            Layout(x => x.PexObservation, 1, x => x.Required = true);
        }
    }
}