// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// OSD (Component) - Order Sequence Definition
    /// </summary>
    public interface OSD :
        HL7V26Component
    {
        /// <summary>
        /// OSD-1  Sequence/Results Flag
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> SequenceResultsFlag { get; }

        /// <summary>
        /// OSD-2  Placer Order Number: Entity Identifier
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> PlacerOrderNumberEntityIdentifier { get; }

        /// <summary>
        /// OSD-3  Placer Order Number: Namespace ID
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> PlacerOrderNumberNamespaceId { get; }

        /// <summary>
        /// OSD-4  Filler Order Number: Entity Identifier
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> FillerOrderNumberEntityIdentifier { get; }

        /// <summary>
        /// OSD-5  Filler Order Number: Namespace ID
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> FillerOrderNumberNamespaceId { get; }

        /// <summary>
        /// OSD-6  Sequence Condition Value
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> SequenceConditionValue { get; }

        /// <summary>
        /// OSD-7  Maximum Number of Repeats
        /// </summary>
        /// <returns>The decimal value</returns>
        Value<decimal> MaximumNumberOfRepeats { get; }

        /// <summary>
        /// OSD-8  Placer Order Number: Universal ID
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> PlacerOrderNumberUniversalId { get; }

        /// <summary>
        /// OSD-9  Placer Order Number: Universal ID Type
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> PlacerOrderNumberUniversalIdType { get; }

        /// <summary>
        /// OSD-10  Filler Order Number: Universal ID
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> FillerOrderNumberUniversalId { get; }

        /// <summary>
        /// OSD-11  Filler Order Number: Universal ID Type
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> FillerOrderNumberUniversalIdType { get; }
    }
}