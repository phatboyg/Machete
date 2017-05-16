// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// SUR_P09_FACILITY_DETAIL (Group) - 
    /// </summary>
    public interface SUR_P09_FACILITY_DETAIL :
        HL7Layout
    {
        /// <summary>
        /// FAC
        /// </summary>
        Segment<FAC> FAC { get; }

        /// <summary>
        /// PDC
        /// </summary>
        Segment<PDC> PDC { get; }

        /// <summary>
        /// NTE
        /// </summary>
        Segment<NTE> NTE { get; }
    }
}