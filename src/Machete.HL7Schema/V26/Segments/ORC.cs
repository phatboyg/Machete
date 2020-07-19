// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// ORC (Segment) - Common Order
    /// </summary>
    public interface ORC :
        HL7V26Segment
    {
        /// <summary>
        /// ORC-1: Order Control
        /// </summary>
        Value<string> OrderControl { get; }

        /// <summary>
        /// ORC-2: Placer Order Number
        /// </summary>
        Value<EI> PlacerOrderNumber { get; }

        /// <summary>
        /// ORC-3: Filler Order Number
        /// </summary>
        Value<EI> FillerOrderNumber { get; }

        /// <summary>
        /// ORC-4: Placer Group Number
        /// </summary>
        Value<EI> PlacerGroupNumber { get; }

        /// <summary>
        /// ORC-5: Order Status
        /// </summary>
        Value<string> OrderStatus { get; }

        /// <summary>
        /// ORC-6: Response Flag
        /// </summary>
        Value<string> ResponseFlag { get; }

        /// <summary>
        /// ORC-7: Quantity/Timing
        /// </summary>
        ValueList<TQ> QuantityTiming { get; }

        /// <summary>
        /// ORC-8: Parent
        /// </summary>
        Value<EIP> Parent { get; }

        /// <summary>
        /// ORC-9: Date/Time of Transaction
        /// </summary>
        Value<DateTimeOffset> DateTimeOfTransaction { get; }

        /// <summary>
        /// ORC-10: Entered By
        /// </summary>
        ValueList<XCN> EnteredBy { get; }

        /// <summary>
        /// ORC-11: Verified By
        /// </summary>
        ValueList<XCN> VerifiedBy { get; }

        /// <summary>
        /// ORC-12: Ordering Provider
        /// </summary>
        ValueList<XCN> OrderingProvider { get; }

        /// <summary>
        /// ORC-13: Enterer's Location
        /// </summary>
        Value<PL> EntererSLocation { get; }

        /// <summary>
        /// ORC-14: Call Back Phone Number
        /// </summary>
        Value<XTN> CallBackPhoneNumber { get; }

        /// <summary>
        /// ORC-15: Order Effective Date/Time
        /// </summary>
        Value<DateTimeOffset> OrderEffectiveDateTime { get; }

        /// <summary>
        /// ORC-16: Order Control Code Reason
        /// </summary>
        Value<CWE> OrderControlCodeReason { get; }

        /// <summary>
        /// ORC-17: Entering Organization
        /// </summary>
        Value<CWE> EnteringOrganization { get; }

        /// <summary>
        /// ORC-18: Entering Device
        /// </summary>
        Value<CWE> EnteringDevice { get; }

        /// <summary>
        /// ORC-19: Action By
        /// </summary>
        ValueList<XCN> ActionBy { get; }

        /// <summary>
        /// ORC-20: Advanced Beneficiary Notice Code
        /// </summary>
        Value<CWE> AdvancedBeneficiaryNoticeCode { get; }

        /// <summary>
        /// ORC-21: Ordering Facility Name
        /// </summary>
        ValueList<XON> OrderingFacilityName { get; }

        /// <summary>
        /// ORC-22: Ordering Facility Address
        /// </summary>
        ValueList<XAD> OrderingFacilityAddress { get; }

        /// <summary>
        /// ORC-23: Ordering Facility Phone Number
        /// </summary>
        ValueList<XTN> OrderingFacilityPhoneNumber { get; }

        /// <summary>
        /// ORC-24: Ordering Provider Address
        /// </summary>
        ValueList<XAD> OrderingProviderAddress { get; }

        /// <summary>
        /// ORC-25: Order Status Modifier
        /// </summary>
        Value<CWE> OrderStatusModifier { get; }

        /// <summary>
        /// ORC-26: Advanced Beneficiary Notice Override Reason
        /// </summary>
        Value<CWE> AdvancedBeneficiaryNoticeOverrideReason { get; }

        /// <summary>
        /// ORC-27: Filler's Expected Availability Date/Time
        /// </summary>
        Value<DateTimeOffset> FillerSExpectedAvailabilityDateTime { get; }

        /// <summary>
        /// ORC-28: Confidentiality Code
        /// </summary>
        Value<CWE> ConfidentialityCode { get; }

        /// <summary>
        /// ORC-29: Order Type
        /// </summary>
        Value<CWE> OrderType { get; }

        /// <summary>
        /// ORC-30: Enterer Authorization Mode
        /// </summary>
        Value<CNE> EntererAuthorizationMode { get; }

        /// <summary>
        /// ORC-31: Parent Universal Service Identifier
        /// </summary>
        Value<CWE> ParentUniversalServiceIdentifier { get; }
    }
}