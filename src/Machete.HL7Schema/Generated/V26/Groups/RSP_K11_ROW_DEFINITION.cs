// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// RSP_K11_ROW_DEFINITION (Group) - 
    /// </summary>
    public interface RSP_K11_ROW_DEFINITION :
        HL7Template
    {
        /// <summary>
        /// RDF
        /// </summary>
        Segment<RDF> RDF { get; }

        /// <summary>
        /// RDT
        /// </summary>
        SegmentList<RDT> RDT { get; }
    }
}