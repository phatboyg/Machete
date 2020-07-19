// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// OM4 (Segment) - Observations that Require Specimens
    /// </summary>
    public interface OM4 :
        HL7V26Segment
    {
        /// <summary>
        /// OM4-1: Sequence Number - Test/Observation Master File
        /// </summary>
        Value<decimal> SequenceNumberTestObservationMasterFile { get; }

        /// <summary>
        /// OM4-2: Derived Specimen
        /// </summary>
        Value<string> DerivedSpecimen { get; }

        /// <summary>
        /// OM4-3: Container Description
        /// </summary>
        Value<TX> ContainerDescription { get; }

        /// <summary>
        /// OM4-4: Container Volume
        /// </summary>
        Value<decimal> ContainerVolume { get; }

        /// <summary>
        /// OM4-5: Container Units
        /// </summary>
        Value<CWE> ContainerUnits { get; }

        /// <summary>
        /// OM4-6: Specimen
        /// </summary>
        Value<CWE> Specimen { get; }

        /// <summary>
        /// OM4-7: Additive
        /// </summary>
        Value<CWE> Additive { get; }

        /// <summary>
        /// OM4-8: Preparation
        /// </summary>
        Value<TX> Preparation { get; }

        /// <summary>
        /// OM4-9: Special Handling Requirements
        /// </summary>
        Value<TX> SpecialHandlingRequirements { get; }

        /// <summary>
        /// OM4-10: Normal Collection Volume
        /// </summary>
        Value<CQ> NormalCollectionVolume { get; }

        /// <summary>
        /// OM4-11: Minimum Collection Volume
        /// </summary>
        Value<CQ> MinimumCollectionVolume { get; }

        /// <summary>
        /// OM4-12: Specimen Requirements
        /// </summary>
        Value<TX> SpecimenRequirements { get; }

        /// <summary>
        /// OM4-13: Specimen Priorities
        /// </summary>
        ValueList<string> SpecimenPriorities { get; }

        /// <summary>
        /// OM4-14: Specimen Retention Time
        /// </summary>
        Value<CQ> SpecimenRetentionTime { get; }
    }
}