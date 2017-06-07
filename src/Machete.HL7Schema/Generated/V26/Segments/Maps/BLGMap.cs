// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// BLG (SegmentMap) - Billing
    /// </summary>
    public class BLGMap :
        HL7V26SegmentMap<BLG>
    {
        public BLGMap()
        {
            Id = "BLG";

            Name = "Billing";

            Entity(x => x.WhenToCharge, 1);
            Value(x => x.ChargeType, 2);
            Entity(x => x.AccountId, 3);
            Entity(x => x.ChargeTypeReason, 4);
        }
    }
}