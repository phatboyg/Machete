// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// DMI (Segment) - DRG Master File Information
    /// </summary>
    public interface DMI :
        HL7V26Segment
    {
        /// <summary>
        /// DMI-1: Diagnostic Related Group
        /// </summary>
        Value<CNE> DiagnosticRelatedGroup { get; }

        /// <summary>
        /// DMI-2: Major Diagnostic Category
        /// </summary>
        Value<CNE> MajorDiagnosticCategory { get; }

        /// <summary>
        /// DMI-3: Lower and Upper Trim Points
        /// </summary>
        Value<NR> LowerAndUpperTrimPoints { get; }

        /// <summary>
        /// DMI-4: Average Length of Stay
        /// </summary>
        Value<decimal> AverageLengthOfStay { get; }

        /// <summary>
        /// DMI-5: Relative Weight
        /// </summary>
        Value<decimal> RelativeWeight { get; }
    }
}