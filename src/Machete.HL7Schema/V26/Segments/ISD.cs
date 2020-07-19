// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// ISD (Segment) - Interaction Status Detail
    /// </summary>
    public interface ISD :
        HL7V26Segment
    {
        /// <summary>
        /// ISD-1: Reference Interaction Number
        /// </summary>
        Value<decimal> ReferenceInteractionNumber { get; }

        /// <summary>
        /// ISD-2: Interaction Type Identifier
        /// </summary>
        Value<CWE> InteractionTypeIdentifier { get; }

        /// <summary>
        /// ISD-3: Interaction Active State
        /// </summary>
        Value<CWE> InteractionActiveState { get; }
    }
}