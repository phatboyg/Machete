// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// SSU_U03_SPECIMEN_CONTAINER (GroupMap) - 
    /// </summary>
    public class SSU_U03_SPECIMEN_CONTAINERMap :
        HL7V26LayoutMap<SSU_U03_SPECIMEN_CONTAINER>
    {
        public SSU_U03_SPECIMEN_CONTAINERMap()
        {
            Segment(x => x.SAC, 0, x => x.Required = true);
            Segment(x => x.OBX, 1);
            Layout(x => x.Specimen, 2);
        }
    }
}