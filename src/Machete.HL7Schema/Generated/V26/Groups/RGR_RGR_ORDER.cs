// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// RGR_RGR_ORDER (Group) - 
    /// </summary>
    public interface RGR_RGR_ORDER :
        HL7Template
    {
        /// <summary>
        /// ORC
        /// </summary>
        Segment<ORC> ORC { get; }

        /// <summary>
        /// ENCODING
        /// </summary>
        Group<RGR_RGR_ENCODING> Encoding { get; }

        /// <summary>
        /// RXG
        /// </summary>
        SegmentList<RXG> RXG { get; }

        /// <summary>
        /// RXR
        /// </summary>
        SegmentList<RXR> RXR { get; }

        /// <summary>
        /// RXC
        /// </summary>
        SegmentList<RXC> RXC { get; }
    }
}