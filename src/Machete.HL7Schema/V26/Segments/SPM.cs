// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// SPM (Segment) - Specimen
    /// </summary>
    public interface SPM :
        HL7V26Segment
    {
        /// <summary>
        /// SPM-1: Set ID - SPM
        /// </summary>
        Value<int> SetId { get; }

        /// <summary>
        /// SPM-2: Specimen ID
        /// </summary>
        Value<EIP> SpecimenId { get; }

        /// <summary>
        /// SPM-3: Specimen Parent IDs
        /// </summary>
        ValueList<EIP> SpecimenParentIds { get; }

        /// <summary>
        /// SPM-4: Specimen Type
        /// </summary>
        Value<CWE> SpecimenType { get; }

        /// <summary>
        /// SPM-5: Specimen Type Modifier
        /// </summary>
        ValueList<CWE> SpecimenTypeModifier { get; }

        /// <summary>
        /// SPM-6: Specimen Additives
        /// </summary>
        ValueList<CWE> SpecimenAdditives { get; }

        /// <summary>
        /// SPM-7: Specimen Collection Method
        /// </summary>
        Value<CWE> SpecimenCollectionMethod { get; }

        /// <summary>
        /// SPM-8: Specimen Source Site
        /// </summary>
        Value<CWE> SpecimenSourceSite { get; }

        /// <summary>
        /// SPM-9: Specimen Source Site Modifier
        /// </summary>
        ValueList<CWE> SpecimenSourceSiteModifier { get; }

        /// <summary>
        /// SPM-10: Specimen Collection Site
        /// </summary>
        Value<CWE> SpecimenCollectionSite { get; }

        /// <summary>
        /// SPM-11: Specimen Role
        /// </summary>
        ValueList<CWE> SpecimenRole { get; }

        /// <summary>
        /// SPM-12: Specimen Collection Amount
        /// </summary>
        Value<CQ> SpecimenCollectionAmount { get; }

        /// <summary>
        /// SPM-13: Grouped Specimen Count
        /// </summary>
        Value<decimal> GroupedSpecimenCount { get; }

        /// <summary>
        /// SPM-14: Specimen Description
        /// </summary>
        ValueList<string> SpecimenDescription { get; }

        /// <summary>
        /// SPM-15: Specimen Handling Code
        /// </summary>
        ValueList<CWE> SpecimenHandlingCode { get; }

        /// <summary>
        /// SPM-16: Specimen Risk Code
        /// </summary>
        ValueList<CWE> SpecimenRiskCode { get; }

        /// <summary>
        /// SPM-17: Specimen Collection Date/Time
        /// </summary>
        Value<DR> SpecimenCollectionDateTime { get; }

        /// <summary>
        /// SPM-18: Specimen Received Date/Time
        /// </summary>
        Value<DateTimeOffset> SpecimenReceivedDateTime { get; }

        /// <summary>
        /// SPM-19: Specimen Expiration Date/Time
        /// </summary>
        Value<DateTimeOffset> SpecimenExpirationDateTime { get; }

        /// <summary>
        /// SPM-20: Specimen Availability
        /// </summary>
        Value<string> SpecimenAvailability { get; }

        /// <summary>
        /// SPM-21: Specimen Reject Reason
        /// </summary>
        ValueList<CWE> SpecimenRejectReason { get; }

        /// <summary>
        /// SPM-22: Specimen Quality
        /// </summary>
        Value<CWE> SpecimenQuality { get; }

        /// <summary>
        /// SPM-23: Specimen Appropriateness
        /// </summary>
        Value<CWE> SpecimenAppropriateness { get; }

        /// <summary>
        /// SPM-24: Specimen Condition
        /// </summary>
        ValueList<CWE> SpecimenCondition { get; }

        /// <summary>
        /// SPM-25: Specimen Current Quantity
        /// </summary>
        Value<CQ> SpecimenCurrentQuantity { get; }

        /// <summary>
        /// SPM-26: Number of Specimen Containers
        /// </summary>
        Value<decimal> NumberOfSpecimenContainers { get; }

        /// <summary>
        /// SPM-27: Container Type
        /// </summary>
        Value<CWE> ContainerType { get; }

        /// <summary>
        /// SPM-28: Container Condition
        /// </summary>
        Value<CWE> ContainerCondition { get; }

        /// <summary>
        /// SPM-29: Specimen Child Role
        /// </summary>
        Value<CWE> SpecimenChildRole { get; }
    }
}