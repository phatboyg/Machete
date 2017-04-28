// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// PRR_PC5_PROBLEM_PATHWAY (Group) - 
    /// </summary>
    public interface PRR_PC5_PROBLEM_PATHWAY :
        HL7Template
    {
        /// <summary>
        /// PTH
        /// </summary>
        Segment<PTH> PTH { get; }

        /// <summary>
        /// VAR
        /// </summary>
        SegmentList<VAR> VAR { get; }
    }
}