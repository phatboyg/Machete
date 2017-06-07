// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// MFN_M11_MF_TEST_CALC_DETAIL (Group) - 
    /// </summary>
    public interface MFN_M11_MF_TEST_CALC_DETAIL :
        HL7V26Layout
    {
        /// <summary>
        /// OM6
        /// </summary>
        Segment<OM6> OM6 { get; }

        /// <summary>
        /// OM2
        /// </summary>
        Segment<OM2> OM2 { get; }
    }
}