// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// RQI_I01_PROVIDER (Group) - 
    /// </summary>
    public interface RQI_I01_PROVIDER :
        HL7Layout
    {
        /// <summary>
        /// PRD
        /// </summary>
        Segment<PRD> PRD { get; }

        /// <summary>
        /// CTD
        /// </summary>
        SegmentList<CTD> CTD { get; }
    }
}