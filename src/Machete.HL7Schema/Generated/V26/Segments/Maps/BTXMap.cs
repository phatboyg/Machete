// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// BTX (SegmentMap) - Blood Product Transfusion/Disposition
    /// </summary>
    public class BTXMap :
        HL7V26SegmentMap<BTX>
    {
        public BTXMap()
        {
            Id = "BTX";

            Name = "Blood Product Transfusion/Disposition";

            Value(x => x.SetId, 1, x => x.IsRequired());
            Entity(x => x.BCDonationId, 2);
            Entity(x => x.BCComponent, 3);
            Entity(x => x.BCBloodGroup, 4);
            Entity(x => x.CPCommercialProduct, 5);
            Entity(x => x.CPManufacturer, 6);
            Entity(x => x.CPLotNumber, 7);
            Value(x => x.BPQuantity, 8, x => x.IsRequired());
            Value(x => x.BPAmount, 9);
            Entity(x => x.BPUnits, 10);
            Entity(x => x.BPTransfusionDispositionStatus, 11, x => x.IsRequired());
            Value(x => x.BPMessageStatus, 12, x => x.IsRequired());
            Value(x => x.BPDateTimeOfStatus, 13, x =>
            {
                x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;
                x.IsRequired();
            });
            Entity(x => x.BPTransfusionAdministrator, 14);
            Entity(x => x.BPTransfusionVerifier, 15);
            Value(x => x.BPTransfusionStartDateTimeOfStatus, 16, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.BPTransfusionEndDateTimeOfStatus, 17, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Entity(x => x.BPAdverseReactionType, 18);
            Entity(x => x.BPTransfusionInterruptedReason, 19);
        }
    }
}