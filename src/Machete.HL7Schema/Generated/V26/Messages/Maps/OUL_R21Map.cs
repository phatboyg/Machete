// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OUL_R21 (MessageMap) - 
    /// </summary>
    public class OUL_R21Map :
        HL7V26LayoutMap<OUL_R21>
    {
        public OUL_R21Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.SFT, 1);
            Segment(x => x.NTE, 2);
            Layout(x => x.Patient, 3);
            Layout(x => x.OrderObservation, 4, x => x.Required = true);
            Segment(x => x.DSC, 5);
        }
    }
}