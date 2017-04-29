// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RAS_O17_ADMINISTRATION (GroupMap) - 
    /// </summary>
    public class RAS_O17_ADMINISTRATIONMap :
        HL7TemplateMap<RAS_O17_ADMINISTRATION>
    {
        public RAS_O17_ADMINISTRATIONMap()
        {
            Segments(x => x.RXA, 0, x => x.Required = true);
            Segment(x => x.RXR, 1, x => x.Required = true);
            Groups(x => x.Observation, 2);
        }
    }
}