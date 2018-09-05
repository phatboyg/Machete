// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// OBX (Segment) - Observation/Result
    /// </summary>
    public interface OBX :
        HL7V26Segment
    {
        /// <summary>
        /// OBX-1: Set ID - OBX
        /// </summary>
        Value<int> SetId { get; }

        /// <summary>
        /// OBX-2: Value Type
        /// </summary>
        Value<string> ValueType { get; }

        /// <summary>
        /// OBX-3: Observation Identifier
        /// </summary>
        Value<CWE> ObservationIdentifier { get; }

        /// <summary>
        /// OBX-4: Observation Sub-ID
        /// </summary>
        Value<string> ObservationSubId { get; }

        /// <summary>
        /// OBX-5: Observation Value
        /// </summary>
        ValueList<string> ObservationValue { get; }

        /// <summary>
        /// OBX-6: Units
        /// </summary>
        Value<CWE> Units { get; }

        /// <summary>
        /// OBX-7: References Range
        /// </summary>
        Value<string> ReferenceRange { get; }

        /// <summary>
        /// OBX-8: Abnormal Flags
        /// </summary>
        ValueList<string> AbnormalFlags { get; }

        /// <summary>
        /// OBX-9: Probability
        /// </summary>
        Value<decimal> Probability { get; }

        /// <summary>
        /// OBX-10: Nature of Abnormal Test
        /// </summary>
        ValueList<string> NatureOfAbnormalTest { get; }

        /// <summary>
        /// OBX-11: Observation Result Status
        /// </summary>
        Value<string> ObservationResultStatus { get; }

        /// <summary>
        /// OBX-12: Effective Date of Reference Range
        /// </summary>
        Value<DateTimeOffset> EffectiveDateOfReferenceRange { get; }

        /// <summary>
        /// OBX-13: User Defined Access Checks
        /// </summary>
        Value<string> UserDefinedAccessChecks { get; }

        /// <summary>
        /// OBX-14: Date/Time of the Observation
        /// </summary>
        Value<DateTimeOffset> DateTimeOfObservation { get; }

        /// <summary>
        /// OBX-15: Producer's ID
        /// </summary>
        Value<CWE> ProducerSId { get; }

        /// <summary>
        /// OBX-16: Responsible Observer
        /// </summary>
        ValueList<XCN> ResponsibleObserver { get; }

        /// <summary>
        /// OBX-17: Observation Method
        /// </summary>
        ValueList<CWE> ObservationMethod { get; }

        /// <summary>
        /// OBX-18: Equipment Instance Identifier
        /// </summary>
        ValueList<EI> EquipmentInstanceIdentifier { get; }

        /// <summary>
        /// OBX-19: Date/Time of the Analysis
        /// </summary>
        Value<DateTimeOffset> DateTimeOfAnalysis { get; }

        /// <summary>
        /// OBX-20: Observation Site
        /// </summary>
        ValueList<CWE> ObservationSite { get; }

        /// <summary>
        /// OBX-21: Observation Instance Identifier
        /// </summary>
        Value<EI> ObservationInstanceIdentifier { get; }

        /// <summary>
        /// OBX-22: Mood Code
        /// </summary>
        Value<CNE> MoodCode { get; }

        /// <summary>
        /// OBX-23: Performing Organization Name
        /// </summary>
        Value<XON> PerformingOrganizationName { get; }

        /// <summary>
        /// OBX-24: Performing Organization Address
        /// </summary>
        Value<XAD> PerformingOrganizationAddress { get; }

        /// <summary>
        /// OBX-25: Performing Organization Medical Director
        /// </summary>
        Value<XCN> PerformingOrganizationMedicalDirector { get; }
    }
}