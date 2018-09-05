// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// OM5 (Segment) - Observation Batteries (Sets)
    /// </summary>
    public interface OM5 :
        HL7V26Segment
    {
        /// <summary>
        /// OM5-1: Sequence Number - Test/Observation Master File
        /// </summary>
        Value<decimal> SequenceNumberTestObservationMasterFile { get; }

        /// <summary>
        /// OM5-2: Test/Observations Included Within an Ordered Test Battery
        /// </summary>
        ValueList<CWE> TestObservationsIncludedWithinAnOrderedTestBattery { get; }

        /// <summary>
        /// OM5-3: Observation ID Suffixes
        /// </summary>
        Value<string> ObservationIdSuffixes { get; }
    }
}