// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// CCD (ComponentMap) - Charge Code and Date
    /// </summary>
    public class CCDMap :
        HL7ComponentMap<CCD>
    {
        public CCDMap()
        {
            Value(x => x.WhenToChargeCode, 1);
            Value(x => x.DateTime, 2, x => {x.Format = "LONGDATETIME2";});
        }
    }
}