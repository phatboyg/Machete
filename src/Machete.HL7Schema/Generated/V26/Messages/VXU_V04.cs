// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// VXU_V04 (Message) - 
    /// </summary>
    public interface VXU_V04 :
        HL7Template
    {
        /// <summary>
        /// MSH
        /// </summary>
        Segment<MSH> MSH { get; }

        /// <summary>
        /// SFT
        /// </summary>
        SegmentList<SFT> SFT { get; }

        /// <summary>
        /// UAC
        /// </summary>
        Segment<UAC> UAC { get; }

        /// <summary>
        /// PID
        /// </summary>
        Segment<PID> PID { get; }

        /// <summary>
        /// PD1
        /// </summary>
        Segment<PD1> PD1 { get; }

        /// <summary>
        /// NK1
        /// </summary>
        SegmentList<NK1> NK1 { get; }

        /// <summary>
        /// PATIENT
        /// </summary>
        Group<VXU_V04_PATIENT> Patient { get; }

        /// <summary>
        /// GT1
        /// </summary>
        SegmentList<GT1> GT1 { get; }

        /// <summary>
        /// INSURANCE
        /// </summary>
        GroupList<VXU_V04_INSURANCE> Insurance { get; }

        /// <summary>
        /// ORDER
        /// </summary>
        GroupList<VXU_V04_ORDER> Order { get; }
    }
}