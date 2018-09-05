// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// EIP (Component) - Entity Identifier Pair
    /// </summary>
    public interface EIP :
        HL7V26Component
    {
        /// <summary>
        /// EIP-1  Placer Assigned Identifier
        /// </summary>
        /// <returns>The EI value</returns>
        Value<EI> PlacerAssignedIdentifier { get; }

        /// <summary>
        /// EIP-2  Filler Assigned Identifier
        /// </summary>
        /// <returns>The EI value</returns>
        Value<EI> FillerAssignedIdentifier { get; }
    }
}