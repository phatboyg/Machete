// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// RAR_RAR_ORDER (Group) - 
    /// </summary>
    public interface RAR_RAR_ORDER :
        HL7V26Layout
    {
        /// <summary>
        /// ORC
        /// </summary>
        Segment<ORC> ORC { get; }

        /// <summary>
        /// ENCODING
        /// </summary>
        Layout<RAR_RAR_ENCODING> Encoding { get; }

        /// <summary>
        /// RXA
        /// </summary>
        SegmentList<RXA> RXA { get; }

        /// <summary>
        /// RXR
        /// </summary>
        Segment<RXR> RXR { get; }
    }
}