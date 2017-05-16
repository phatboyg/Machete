// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// EAC_U07_COMMAND (GroupMap) - 
    /// </summary>
    public class EAC_U07_COMMANDMap :
        HL7LayoutMap<EAC_U07_COMMAND>
    {
        public EAC_U07_COMMANDMap()
        {
            Segment(x => x.ECD, 0, x => x.Required = true);
            Segment(x => x.TQ1, 1);
            Layout(x => x.SpecimenContainer, 2);
            Segment(x => x.CNS, 3);
        }
    }
}