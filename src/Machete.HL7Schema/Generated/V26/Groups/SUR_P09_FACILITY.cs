// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// SUR_P09_FACILITY (Group) - 
    /// </summary>
    public interface SUR_P09_FACILITY :
        HL7Layout
    {
        /// <summary>
        /// FAC
        /// </summary>
        Segment<FAC> FAC { get; }

        /// <summary>
        /// PRODUCT
        /// </summary>
        LayoutList<SUR_P09_PRODUCT> Product { get; }

        /// <summary>
        /// PSH
        /// </summary>
        Segment<PSH> PSH { get; }

        /// <summary>
        /// FACILITY_DETAIL
        /// </summary>
        LayoutList<SUR_P09_FACILITY_DETAIL> FacilityDetail { get; }
    }
}