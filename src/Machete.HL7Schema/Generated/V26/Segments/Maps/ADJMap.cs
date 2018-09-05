// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ADJ (SegmentMap) - Adjustment
    /// </summary>
    public class ADJMap :
        HL7V26SegmentMap<ADJ>
    {
        public ADJMap()
        {
            Id = "ADJ";

            Name = "Adjustment";

            Entity(x => x.ProviderAdjustmentNumber, 1, x => x.IsRequired());
            Entity(x => x.PayerAdjustmentNumber, 2, x => x.IsRequired());
            Value(x => x.AdjustmentSequenceNumber, 3, x => x.IsRequired());
            Value(x => x.AdjustmentCategory, 4, x => x.IsRequired());
            Entity(x => x.AdjustmentAmount, 5);
            Entity(x => x.AdjustmentQuantity, 6);
            Entity(x => x.AdjustmentReasonPA, 7);
            Value(x => x.AdjustmentDescription, 8);
            Value(x => x.OriginalValue, 9);
            Value(x => x.SubstituteValue, 10);
            Value(x => x.AdjustmentAction, 11);
            Entity(x => x.ProviderAdjustmentNumberCrossReference, 12);
            Entity(x => x.ProviderProductServiceLineItemNumberCrossReference, 13);
            Value(x => x.AdjustmentDate, 14, x =>
            {
                x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;
                x.IsRequired();
            });
            Entity(x => x.ResponsibleOrganization, 15);
        }
    }
}