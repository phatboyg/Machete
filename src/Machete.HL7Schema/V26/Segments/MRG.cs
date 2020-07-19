// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// MRG (Segment) - Merge Patient Information
    /// </summary>
    public interface MRG :
        HL7V26Segment
    {
        /// <summary>
        /// MRG-1: Prior Patient Identifier List
        /// </summary>
        ValueList<CX> PriorPatientIdentifierList { get; }

        /// <summary>
        /// MRG-2: Prior Alternate Patient ID
        /// </summary>
        ValueList<CX> PriorAlternatePatientId { get; }

        /// <summary>
        /// MRG-3: Prior Patient Account Number
        /// </summary>
        Value<CX> PriorPatientAccountNumber { get; }

        /// <summary>
        /// MRG-4: Prior Patient ID
        /// </summary>
        Value<CX> PriorPatientId { get; }

        /// <summary>
        /// MRG-5: Prior Visit Number
        /// </summary>
        Value<CX> PriorVisitNumber { get; }

        /// <summary>
        /// MRG-6: Prior Alternate Visit ID
        /// </summary>
        Value<CX> PriorAlternateVisitId { get; }

        /// <summary>
        /// MRG-7: Prior Patient Name
        /// </summary>
        ValueList<XPN> PriorPatientName { get; }
    }
}