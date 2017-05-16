// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// RRA_O18_ORDER (Group) - 
    /// </summary>
    public interface RRA_O18_ORDER :
        HL7Layout
    {
        /// <summary>
        /// ORC
        /// </summary>
        Segment<ORC> ORC { get; }

        /// <summary>
        /// TIMING
        /// </summary>
        LayoutList<RRA_O18_TIMING> Timing { get; }

        /// <summary>
        /// ADMINISTRATION
        /// </summary>
        Layout<RRA_O18_ADMINISTRATION> Administration { get; }
    }
}