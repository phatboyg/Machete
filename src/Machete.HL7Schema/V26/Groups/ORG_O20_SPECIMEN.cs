// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// ORG_O20_SPECIMEN (Group) - 
    /// </summary>
    public interface ORG_O20_SPECIMEN :
        HL7V26Layout
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