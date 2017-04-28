// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// CSU_C09_RX_ADMIN (Group) - 
    /// </summary>
    public interface CSU_C09_RX_ADMIN :
        HL7Template
    {
        /// <summary>
        /// RXA
        /// </summary>
        Segment<RXA> RXA { get; }

        /// <summary>
        /// RXR
        /// </summary>
        Segment<RXR> RXR { get; }
    }
}