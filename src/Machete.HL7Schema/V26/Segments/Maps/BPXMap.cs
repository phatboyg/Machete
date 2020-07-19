// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// BPX (SegmentMap) - Blood product dispense status
    /// </summary>
    public class BPXMap :
        HL7V26SegmentMap<BPX>
    {
        public BPXMap()
        {
            Id = "BPX";

            Name = "Blood product dispense status";

            Value(x => x.SetId, 1, x => x.IsRequired());
            Entity(x => x.BPDispenseStatus, 2, x => x.IsRequired());
            Value(x => x.BPStatus, 3, x => x.IsRequired());
            Value(x => x.BPDateTimeOfStatus, 4, x =>
            {
                x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;
                x.IsRequired();
            });
            Entity(x => x.BCDonationId, 5);
            Entity(x => x.BCComponent, 6);
            Entity(x => x.BCDonationTypeIntendedUse, 7);
            Entity(x => x.CPCommercialProduct, 8);
            Entity(x => x.CPManufacturer, 9);
            Entity(x => x.CPLotNumber, 10);
            Entity(x => x.BPBloodGroup, 11);
            Entity(x => x.BCSpecialTesting, 12);
            Value(x => x.BPExpirationDateTime, 13, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.BPQuantity, 14, x => x.IsRequired());
            Value(x => x.BPAmount, 15);
            Entity(x => x.BPUnits, 16);
            Entity(x => x.BPUniqueId, 17);
            Entity(x => x.BPActualDispensedToLocation, 18);
            Entity(x => x.BPActualDispensedToAddress, 19);
            Entity(x => x.BPDispensedToReceiver, 20);
            Entity(x => x.BPDispensingIndividual, 21);
        }
    }
}