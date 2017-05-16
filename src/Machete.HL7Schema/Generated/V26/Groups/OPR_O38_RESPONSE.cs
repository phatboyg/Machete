// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// OPR_O38_RESPONSE (Group) - 
    /// </summary>
    public interface OPR_O38_RESPONSE :
        HL7Layout
    {
        /// <summary>
        /// NK1
        /// </summary>
        SegmentList<NK1> NK1 { get; }

        /// <summary>
        /// PID
        /// </summary>
        Segment<PID> PID { get; }

        /// <summary>
        /// SPECIMEN
        /// </summary>
        LayoutList<OPR_O38_SPECIMEN> Specimen { get; }
    }
}