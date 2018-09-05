// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// SID (Segment) - Substance Identifier
    /// </summary>
    public interface SID :
        HL7V26Segment
    {
        /// <summary>
        /// SID-1: Application/Method Identifier
        /// </summary>
        Value<CWE> ApplicationMethodIdentifier { get; }

        /// <summary>
        /// SID-2: Substance Lot Number
        /// </summary>
        Value<string> SubstanceLotNumber { get; }

        /// <summary>
        /// SID-3: Substance Container Identifier
        /// </summary>
        Value<string> SubstanceContainerIdentifier { get; }

        /// <summary>
        /// SID-4: Substance Manufacturer Identifier
        /// </summary>
        Value<CWE> SubstanceManufacturerIdentifier { get; }
    }
}