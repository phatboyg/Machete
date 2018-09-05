// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// BPO (SegmentMap) - Blood product order
    /// </summary>
    public class BPOMap :
        HL7V26SegmentMap<BPO>
    {
        public BPOMap()
        {
            Id = "BPO";

            Name = "Blood product order";

            Value(x => x.SetId, 1, x => x.IsRequired());
            Entity(x => x.BPUniversalServiceIdentifier, 2, x => x.IsRequired());
            Entity(x => x.BPProcessingRequirements, 3);
            Value(x => x.BPQuantity, 4, x => x.IsRequired());
            Value(x => x.BPAmount, 5);
            Entity(x => x.BPUnits, 6);
            Value(x => x.BPIntendedUseDateTime, 7, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Entity(x => x.BPIntendedDispenseFromLocation, 8);
            Entity(x => x.BPIntendedDispenseFromAddress, 9);
            Value(x => x.BPRequestedDispenseDateTime, 10, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Entity(x => x.BPRequestedDispenseToLocation, 11);
            Entity(x => x.BPRequestedDispenseToAddress, 12);
            Entity(x => x.BPIndicationForUse, 13);
            Value(x => x.BPInformedConsentIndicator, 14);
        }
    }
}