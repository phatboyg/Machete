// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// ODS (Segment) - Dietary Orders, Supplements, and Preferences
    /// </summary>
    public interface ODS :
        HL7V26Segment
    {
        /// <summary>
        /// ODS-1: Type
        /// </summary>
        Value<string> Type { get; }

        /// <summary>
        /// ODS-2: Service Period
        /// </summary>
        Value<CWE> ServicePeriod { get; }

        /// <summary>
        /// ODS-3: Diet, Supplement, or Preference Code
        /// </summary>
        Value<CWE> DietSupplementOrPreferenceCode { get; }

        /// <summary>
        /// ODS-4: Text Instruction
        /// </summary>
        Value<string> TextInstruction { get; }
    }
}