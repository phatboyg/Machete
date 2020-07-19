// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// RDF (Segment) - Table Row Definition
    /// </summary>
    public interface RDF :
        HL7V26Segment
    {
        /// <summary>
        /// RDF-1: Number of Columns per Row
        /// </summary>
        Value<decimal> NumberOfColumnsPerRow { get; }

        /// <summary>
        /// RDF-2: Column Description
        /// </summary>
        ValueList<RCD> ColumnDescription { get; }
    }
}