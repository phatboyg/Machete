// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// ARV (Segment) - Access Restriction
    /// </summary>
    public interface ARV :
        HL7V26Segment
    {
        /// <summary>
        /// ARV-1: Set ID
        /// </summary>
        Value<int> SetId { get; }

        /// <summary>
        /// ARV-2: Access Restriction Action Code
        /// </summary>
        Value<CNE> AccessRestrictionActionCode { get; }

        /// <summary>
        /// ARV-3: Access Restriction Value
        /// </summary>
        Value<CWE> AccessRestrictionValue { get; }

        /// <summary>
        /// ARV-4: Access Restriction Reason
        /// </summary>
        ValueList<CWE> AccessRestrictionReason { get; }

        /// <summary>
        /// ARV-5: Special Access Restriction Instructions
        /// </summary>
        ValueList<string> SpecialAccessRestrictionInstructions { get; }

        /// <summary>
        /// ARV-6: Access Restriction Date Range
        /// </summary>
        Value<DR> AccessRestrictionDateRange { get; }
    }
}