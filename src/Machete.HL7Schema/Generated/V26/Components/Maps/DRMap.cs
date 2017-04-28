// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// DR (ComponentMap) - Date/Time Range
    /// </summary>
    public class DRMap :
        HL7ComponentMap<DR>
    {
        public DRMap()
        {
            Value(x => x.RangeStartDateTime, 1, x => {x.Format = "LONGDATETIME1";});
            Value(x => x.RangeEndDateTime, 2, x => {x.Format = "LONGDATETIME2";});
        }
    }
}