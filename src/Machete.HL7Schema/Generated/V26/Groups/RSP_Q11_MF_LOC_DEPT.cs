// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// RSP_Q11_MF_LOC_DEPT (Group) - 
    /// </summary>
    public interface RSP_Q11_MF_LOC_DEPT :
        HL7Layout
    {
        /// <summary>
        /// LDP
        /// </summary>
        Segment<LDP> LDP { get; }

        /// <summary>
        /// LCH
        /// </summary>
        SegmentList<LCH> LCH { get; }

        /// <summary>
        /// LCC
        /// </summary>
        SegmentList<LCC> LCC { get; }
    }
}