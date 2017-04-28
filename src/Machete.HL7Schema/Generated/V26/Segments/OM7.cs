// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;
    using HL7;

    /// <summary>
    /// OM7 (Segment) - Additional Basic Attributes
    /// </summary>
    public interface OM7 :
        HL7Segment
    {
        /// <summary>
        /// OM7-1: Sequence Number - Test/Observation Master File
        /// </summary>
        Value<decimal> SequenceNumberTestObservationMasterFile { get; }

        /// <summary>
        /// OM7-2: Universal Service Identifier
        /// </summary>
        Value<CWE> UniversalServiceIdentifier { get; }

        /// <summary>
        /// OM7-3: Category Identifier
        /// </summary>
        ValueList<CWE> CategoryIdentifier { get; }

        /// <summary>
        /// OM7-4: Category Description
        /// </summary>
        Value<TX> CategoryDescription { get; }

        /// <summary>
        /// OM7-5: Category Synonym
        /// </summary>
        ValueList<string> CategorySynonym { get; }

        /// <summary>
        /// OM7-6: Effective Test/Service Start Date/Time
        /// </summary>
        Value<DateTimeOffset> EffectiveTestServiceStartDateTime { get; }

        /// <summary>
        /// OM7-7: Effective Test/Service End Date/Time
        /// </summary>
        Value<DateTimeOffset> EffectiveTestServiceEndDateTime { get; }

        /// <summary>
        /// OM7-8: Test/Service Default Duration Quantity
        /// </summary>
        Value<decimal> TestServiceDefaultDurationQuantity { get; }

        /// <summary>
        /// OM7-9: Test/Service Default Duration Units
        /// </summary>
        Value<CWE> TestServiceDefaultDurationUnits { get; }

        /// <summary>
        /// OM7-10: Test/Service Default Frequency
        /// </summary>
        Value<string> TestServiceDefaultFrequency { get; }

        /// <summary>
        /// OM7-11: Consent Indicator
        /// </summary>
        Value<string> ConsentIndicator { get; }

        /// <summary>
        /// OM7-12: Consent Identifier
        /// </summary>
        Value<CWE> ConsentIdentifier { get; }

        /// <summary>
        /// OM7-13: Consent Effective Start Date/Time
        /// </summary>
        Value<DateTimeOffset> ConsentEffectiveStartDateTime { get; }

        /// <summary>
        /// OM7-14: Consent Effective End Date/Time
        /// </summary>
        Value<DateTimeOffset> ConsentEffectiveEndDateTime { get; }

        /// <summary>
        /// OM7-15: Consent Interval Quantity
        /// </summary>
        Value<decimal> ConsentIntervalQuantity { get; }

        /// <summary>
        /// OM7-16: Consent Interval Units
        /// </summary>
        Value<CWE> ConsentIntervalUnits { get; }

        /// <summary>
        /// OM7-17: Consent Waiting Period Quantity
        /// </summary>
        Value<decimal> ConsentWaitingPeriodQuantity { get; }

        /// <summary>
        /// OM7-18: Consent Waiting Period Units
        /// </summary>
        Value<CWE> ConsentWaitingPeriodUnits { get; }

        /// <summary>
        /// OM7-19: Effective Date/Time of Change
        /// </summary>
        Value<DateTimeOffset> EffectiveDateTimeOfChange { get; }

        /// <summary>
        /// OM7-20: Entered By
        /// </summary>
        Value<XCN> EnteredBy { get; }

        /// <summary>
        /// OM7-21: Orderable-at Location
        /// </summary>
        ValueList<PL> OrderableAtLocation { get; }

        /// <summary>
        /// OM7-22: Formulary Status
        /// </summary>
        Value<string> FormularyStatus { get; }

        /// <summary>
        /// OM7-23: Special Order Indicator
        /// </summary>
        Value<string> SpecialOrderIndicator { get; }

        /// <summary>
        /// OM7-24: Primary Key Value - CDM
        /// </summary>
        ValueList<CWE> PrimaryKeyValueCDM { get; }
    }
}