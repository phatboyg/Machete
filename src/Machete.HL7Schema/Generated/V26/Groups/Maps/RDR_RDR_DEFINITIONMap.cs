// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RDR_RDR_DEFINITION (GroupMap) - 
    /// </summary>
    public class RDR_RDR_DEFINITIONMap :
        HL7LayoutMap<RDR_RDR_DEFINITION>
    {
        public RDR_RDR_DEFINITIONMap()
        {
            Segment(x => x.QRD, 0, x => x.Required = true);
            Segment(x => x.QRF, 1);
            Layout(x => x.Patient, 2);
            Layout(x => x.Order, 3, x => x.Required = true);
            Segment(x => x.RXR, 4, x => x.Required = true);
        }
    }
}