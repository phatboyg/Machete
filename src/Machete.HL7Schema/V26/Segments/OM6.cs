// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// OM6 (Segment) - Observations that are Calculated from Other Observations
    /// </summary>
    public interface OM6 :
        HL7V26Segment
    {
        /// <summary>
        /// OM6-1: Sequence Number - Test/Observation Master File
        /// </summary>
        Value<decimal> SequenceNumberTestObservationMasterFile { get; }

        /// <summary>
        /// OM6-2: Derivation Rule
        /// </summary>
        Value<TX> DerivationRule { get; }
    }
}