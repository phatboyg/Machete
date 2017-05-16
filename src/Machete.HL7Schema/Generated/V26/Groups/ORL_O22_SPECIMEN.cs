// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// ORL_O22_SPECIMEN (Group) - 
    /// </summary>
    public interface ORL_O22_SPECIMEN :
        HL7Layout
    {
        /// <summary>
        /// SPM
        /// </summary>
        Segment<SPM> SPM { get; }

        /// <summary>
        /// SAC
        /// </summary>
        SegmentList<SAC> SAC { get; }
    }
}