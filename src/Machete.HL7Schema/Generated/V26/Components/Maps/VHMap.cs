// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// VH (ComponentMap) - Visiting Hours
    /// </summary>
    public class VHMap :
        HL7ComponentMap<VH>
    {
        public VHMap()
        {
            Value(x => x.StartDayRange, 1);
            Value(x => x.EndDayRange, 2);
            Value(x => x.StartHourRange, 3, x => {x.Format = "LONGDATETIME3";});
            Value(x => x.EndHourRange, 4, x => {x.Format = "LONGDATETIME4";});
        }
    }
}