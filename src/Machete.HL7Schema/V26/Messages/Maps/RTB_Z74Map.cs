// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RTB_Z74 (MessageMap) - 
    /// </summary>
    public class RTB_Z74Map :
        HL7V26LayoutMap<RTB_Z74>
    {
        public RTB_Z74Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.MSA, 1, x => x.Required = true);
            Segment(x => x.ERR, 2);
            Segment(x => x.SFT, 3);
            Segment(x => x.UAC, 4);
            Segment(x => x.QAK, 5, x => x.Required = true);
            Segment(x => x.QPD, 6, x => x.Required = true);
            Layout(x => x.RowDefinition, 7);
            Segment(x => x.DSC, 8);
        }
    }
}