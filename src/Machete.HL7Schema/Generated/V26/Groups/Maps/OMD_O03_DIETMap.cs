// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OMD_O03_DIET (GroupMap) - 
    /// </summary>
    public class OMD_O03_DIETMap :
        HL7V26LayoutMap<OMD_O03_DIET>
    {
        public OMD_O03_DIETMap()
        {
            Segment(x => x.ODS, 0, x => x.Required = true);
            Segment(x => x.NTE, 1);
            Layout(x => x.Observation, 2);
        }
    }
}