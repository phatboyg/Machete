// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// LCC (SegmentMap) - Location Charge Code
    /// </summary>
    public class LCCMap :
        HL7V26SegmentMap<LCC>
    {
        public LCCMap()
        {
            Id = "LCC";

            Name = "Location Charge Code";

            Entity(x => x.PrimaryKeyValue, 1, x => x.IsRequired());
            Entity(x => x.LocationDepartment, 2, x => x.IsRequired());
            Entity(x => x.AccommodationType, 3);
            Entity(x => x.ChargeCode, 4, x => x.IsRequired());
        }
    }
}