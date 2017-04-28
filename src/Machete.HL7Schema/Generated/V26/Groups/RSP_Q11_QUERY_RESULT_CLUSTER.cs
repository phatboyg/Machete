// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// RSP_Q11_QUERY_RESULT_CLUSTER (Group) - 
    /// </summary>
    public interface RSP_Q11_QUERY_RESULT_CLUSTER :
        HL7Template
    {
        /// <summary>
        /// MFE
        /// </summary>
        Segment<MFE> MFE { get; }

        /// <summary>
        /// LOC
        /// </summary>
        Segment<LOC> LOC { get; }

        /// <summary>
        /// LCH
        /// </summary>
        SegmentList<LCH> LCH { get; }

        /// <summary>
        /// LRL
        /// </summary>
        SegmentList<LRL> LRL { get; }

        /// <summary>
        /// MF_LOC_DEPT
        /// </summary>
        GroupList<RSP_Q11_MF_LOC_DEPT> MfLocDept { get; }
    }
}