// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// VXX_V02_PATIENT (Group) - 
    /// </summary>
    public interface VXX_V02_PATIENT :
        HL7Template
    {
        /// <summary>
        /// PID
        /// </summary>
        Segment<PID> PID { get; }

        /// <summary>
        /// NK1
        /// </summary>
        SegmentList<NK1> NK1 { get; }
    }
}