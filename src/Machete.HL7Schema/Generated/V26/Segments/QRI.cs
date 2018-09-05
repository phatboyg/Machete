// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// QRI (Segment) - Query Response Instance
    /// </summary>
    public interface QRI :
        HL7V26Segment
    {
        /// <summary>
        /// QRI-1: Candidate Confidence
        /// </summary>
        Value<decimal> CandidateConfidence { get; }

        /// <summary>
        /// QRI-2: Match Reason Code
        /// </summary>
        ValueList<string> MatchReasonCode { get; }

        /// <summary>
        /// QRI-3: Algorithm Descriptor
        /// </summary>
        Value<CWE> AlgorithmDescriptor { get; }
    }
}