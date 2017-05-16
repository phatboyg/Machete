// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RPI_I01 (MessageMap) - 
    /// </summary>
    public class RPI_I01Map :
        HL7LayoutMap<RPI_I01>
    {
        public RPI_I01Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.SFT, 1);
            Segment(x => x.UAC, 2);
            Segment(x => x.MSA, 3, x => x.Required = true);
            Layout(x => x.Provider, 4, x => x.Required = true);
            Segment(x => x.PID, 5, x => x.Required = true);
            Segment(x => x.NK1, 6);
            Layout(x => x.GuarantorInsurance, 7);
            Segment(x => x.NTE, 8);
        }
    }
}