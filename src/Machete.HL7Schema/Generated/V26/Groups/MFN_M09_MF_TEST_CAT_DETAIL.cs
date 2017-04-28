// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// MFN_M09_MF_TEST_CAT_DETAIL (Group) - 
    /// </summary>
    public interface MFN_M09_MF_TEST_CAT_DETAIL :
        HL7Template
    {
        /// <summary>
        /// OM3
        /// </summary>
        Segment<OM3> OM3 { get; }

        /// <summary>
        /// OM4
        /// </summary>
        SegmentList<OM4> OM4 { get; }
    }
}