// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ORC (SegmentMap) - Common Order
    /// </summary>
    public class ORCMap :
        HL7V26SegmentMap<ORC>
    {
        public ORCMap()
        {
            Id = "ORC";

            Name = "Common Order";

            Value(x => x.OrderControl, 1, x => x.IsRequired());
            Entity(x => x.PlacerOrderNumber, 2);
            Entity(x => x.FillerOrderNumber, 3);
            Entity(x => x.PlacerGroupNumber, 4);
            Value(x => x.OrderStatus, 5);
            Value(x => x.ResponseFlag, 6);
            Entity(x => x.QuantityTiming, 7);
            Entity(x => x.Parent, 8);
            Value(x => x.DateTimeOfTransaction, 9, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Entity(x => x.EnteredBy, 10);
            Entity(x => x.VerifiedBy, 11);
            Entity(x => x.OrderingProvider, 12);
            Entity(x => x.EntererSLocation, 13);
            Entity(x => x.CallBackPhoneNumber, 14);
            Value(x => x.OrderEffectiveDateTime, 15, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Entity(x => x.OrderControlCodeReason, 16);
            Entity(x => x.EnteringOrganization, 17);
            Entity(x => x.EnteringDevice, 18);
            Entity(x => x.ActionBy, 19);
            Entity(x => x.AdvancedBeneficiaryNoticeCode, 20);
            Entity(x => x.OrderingFacilityName, 21);
            Entity(x => x.OrderingFacilityAddress, 22);
            Entity(x => x.OrderingFacilityPhoneNumber, 23);
            Entity(x => x.OrderingProviderAddress, 24);
            Entity(x => x.OrderStatusModifier, 25);
            Entity(x => x.AdvancedBeneficiaryNoticeOverrideReason, 26);
            Value(x => x.FillerSExpectedAvailabilityDateTime, 27, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Entity(x => x.ConfidentialityCode, 28);
            Entity(x => x.OrderType, 29);
            Entity(x => x.EntererAuthorizationMode, 30);
            Entity(x => x.ParentUniversalServiceIdentifier, 31);
        }
    }
}