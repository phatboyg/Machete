// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// OM3 (Segment) - Categorical Service/Test/Observation
    /// </summary>
    public interface OM3 :
        HL7V26Segment
    {
        /// <summary>
        /// OM3-1: Sequence Number - Test/Observation Master File
        /// </summary>
        Value<decimal> SequenceNumberTestObservationMasterFile { get; }

        /// <summary>
        /// OM3-2: Preferred Coding System
        /// </summary>
        Value<CWE> PreferredCodingSystem { get; }

        /// <summary>
        /// OM3-3: Valid Coded "Answers"
        /// </summary>
        ValueList<CWE> ValidCodedAnswers { get; }

        /// <summary>
        /// OM3-4: Normal Text/Codes for Categorical Observations
        /// </summary>
        ValueList<CWE> NormalTextCodesForCategoricalObservations { get; }

        /// <summary>
        /// OM3-5: Abnormal Text/Codes for Categorical Observations
        /// </summary>
        ValueList<CWE> AbnormalTextCodesForCategoricalObservations { get; }

        /// <summary>
        /// OM3-6: Critical Text/Codes for Categorical Observations
        /// </summary>
        ValueList<CWE> CriticalTextCodesForCategoricalObservations { get; }

        /// <summary>
        /// OM3-7: Value Type
        /// </summary>
        Value<string> ValueType { get; }
    }
}