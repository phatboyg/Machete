// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// ODT (Segment) - Diet Tray Instructions
    /// </summary>
    public interface ODT :
        HL7V26Segment
    {
        /// <summary>
        /// ODT-1: Tray Type
        /// </summary>
        Value<CWE> TrayType { get; }

        /// <summary>
        /// ODT-2: Service Period
        /// </summary>
        Value<CWE> ServicePeriod { get; }

        /// <summary>
        /// ODT-3: Text Instruction
        /// </summary>
        Value<string> TextInstruction { get; }
    }
}