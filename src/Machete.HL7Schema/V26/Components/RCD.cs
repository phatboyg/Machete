// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// RCD (Component) - Row Column Definition
    /// </summary>
    public interface RCD :
        HL7V26Component
    {
        /// <summary>
        /// RCD-1  Segment Field Name
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> SegmentFieldName { get; }

        /// <summary>
        /// RCD-2  HL7 Data Type
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> HL7DataType { get; }

        /// <summary>
        /// RCD-3  Maximum Column Width
        /// </summary>
        /// <returns>The decimal value</returns>
        Value<decimal> MaximumColumnWidth { get; }
    }
}