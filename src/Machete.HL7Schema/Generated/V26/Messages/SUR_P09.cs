// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// SUR_P09 (Message) - 
    /// </summary>
    public interface SUR_P09 :
        HL7Layout
    {
        /// <summary>
        /// MSH
        /// </summary>
        Segment<MSH> MSH { get; }

        /// <summary>
        /// FACILITY
        /// </summary>
        LayoutList<SUR_P09_FACILITY> Facility { get; }
    }
}