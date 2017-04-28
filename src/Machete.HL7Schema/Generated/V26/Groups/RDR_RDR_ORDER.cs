// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// RDR_RDR_ORDER (Group) - 
    /// </summary>
    public interface RDR_RDR_ORDER :
        HL7Template
    {
        /// <summary>
        /// ORC
        /// </summary>
        Segment<ORC> ORC { get; }

        /// <summary>
        /// ENCODING
        /// </summary>
        Group<RDR_RDR_ENCODING> Encoding { get; }

        /// <summary>
        /// DISPENSE
        /// </summary>
        GroupList<RDR_RDR_DISPENSE> Dispense { get; }
    }
}