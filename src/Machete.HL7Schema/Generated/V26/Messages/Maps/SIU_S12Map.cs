// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// SIU_S12 (MessageMap) - 
    /// </summary>
    public class SIU_S12Map :
        HL7LayoutMap<SIU_S12>
    {
        public SIU_S12Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.SCH, 1, x => x.Required = true);
            Segment(x => x.TQ1, 2);
            Segment(x => x.NTE, 3);
            Layout(x => x.Patient, 4);
            Layout(x => x.Resources, 5, x => x.Required = true);
        }
    }
}