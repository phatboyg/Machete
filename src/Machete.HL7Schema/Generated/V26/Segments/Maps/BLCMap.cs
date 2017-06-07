// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// BLC (SegmentMap) - Blood Code
    /// </summary>
    public class BLCMap :
        HL7V26SegmentMap<BLC>
    {
        public BLCMap()
        {
            Id = "BLC";

            Name = "Blood Code";

            Entity(x => x.BloodProductCode, 1);
            Entity(x => x.BloodAmount, 2);
        }
    }
}