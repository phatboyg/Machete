// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PRC (SegmentMap) - Pricing
    /// </summary>
    public class PRCMap :
        HL7V26SegmentMap<PRC>
    {
        public PRCMap()
        {
            Id = "PRC";

            Name = "Pricing";

            Entity(x => x.PrimaryKeyValue, 1, x => x.IsRequired());
            Entity(x => x.FacilityId, 2);
            Entity(x => x.Department, 3);
            Value(x => x.ValidPatientClasses, 4);
            Entity(x => x.Price, 5);
            Value(x => x.Formula, 6);
            Value(x => x.MinimumQuantity, 7);
            Value(x => x.MaximumQuantity, 8);
            Entity(x => x.MinimumPrice, 9);
            Entity(x => x.MaximumPrice, 10);
            Value(x => x.EffectiveStartDate, 11, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.EffectiveEndDate, 12, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.PriceOverrideFlag, 13);
            Entity(x => x.BillingCategory, 14);
            Value(x => x.ChargeableFlag, 15);
            Value(x => x.ActiveInactiveFlag, 16);
            Entity(x => x.Cost, 17);
            Value(x => x.ChargeOnIndicator, 18);
        }
    }
}