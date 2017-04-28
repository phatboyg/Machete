// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// SRR_S01_SCHEDULE (GroupMap) - 
    /// </summary>
    public class SRR_S01_SCHEDULEMap :
        HL7TemplateMap<SRR_S01_SCHEDULE>
    {
        public SRR_S01_SCHEDULEMap()
        {
            Map(x => x.SCH, 0, x => x.Required = true);
            Map(x => x.TQ1, 1);
            Map(x => x.NTE, 2);
            Map(x => x.Patient, 3);
            Map(x => x.Resources, 4, x => x.Required = true);
        }
    }
}