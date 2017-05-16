// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// RRE_O12_ORDER (Group) - 
    /// </summary>
    public interface RRE_O12_ORDER :
        HL7Layout
    {
        /// <summary>
        /// ORC
        /// </summary>
        Segment<ORC> ORC { get; }

        /// <summary>
        /// TIMING
        /// </summary>
        LayoutList<RRE_O12_TIMING> Timing { get; }

        /// <summary>
        /// ENCODING
        /// </summary>
        Layout<RRE_O12_ENCODING> Encoding { get; }
    }
}