// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// ADT_AXX (Message) - 
    /// </summary>
    public interface ADT_AXX :
        HL7V26Layout
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
        /// EVN
        /// </summary>
        Segment<EVN> EVN { get; }

        /// <summary>
        /// PID
        /// </summary>
        Segment<PID> PID { get; }

        /// <summary>
        /// PD1
        /// </summary>
        Segment<PD1> PD1 { get; }

        /// <summary>
        /// ARV
        /// </summary>
        SegmentList<ARV> ARV { get; }

        /// <summary>
        /// ROL
        /// </summary>
        SegmentList<ROL> ROL { get; }

        /// <summary>
        /// MRG
        /// </summary>
        Segment<MRG> MRG { get; }

        /// <summary>
        /// NK1
        /// </summary>
        SegmentList<NK1> NK1 { get; }

        /// <summary>
        /// PV1
        /// </summary>
        Segment<PV1> PV1 { get; }

        /// <summary>
        /// PV2
        /// </summary>
        Segment<PV2> PV2 { get; }

        /// <summary>
        /// ARV2
        /// </summary>
        SegmentList<ARV> ARV2 { get; }

        /// <summary>
        /// ROL2
        /// </summary>
        SegmentList<ROL> ROL2 { get; }

        /// <summary>
        /// DB1
        /// </summary>
        SegmentList<DB1> DB1 { get; }

        /// <summary>
        /// OBX
        /// </summary>
        SegmentList<OBX> OBX { get; }

        /// <summary>
        /// AL1
        /// </summary>
        SegmentList<AL1> AL1 { get; }

        /// <summary>
        /// DG1
        /// </summary>
        SegmentList<DG1> DG1 { get; }

        /// <summary>
        /// DRG
        /// </summary>
        Segment<DRG> DRG { get; }

        /// <summary>
        /// PROCEDURE
        /// </summary>
        LayoutList<ADT_AXX_PROCEDURE> ADT_AXX_PROCEDURE { get; }

        /// <summary>
        /// GT1
        /// </summary>
        SegmentList<GT1> GT1 { get; }

        /// <summary>
        /// INSURANCE
        /// </summary>
        LayoutList<ADT_AXX_INSURANCE> ADT_AXX_INSURANCE { get; }

        /// <summary>
        /// ACC
        /// </summary>
        Segment<ACC> ACC { get; }

        /// <summary>
        /// UB1
        /// </summary>
        Segment<UB1> UB1 { get; }

        /// <summary>
        /// UB2
        /// </summary>
        Segment<UB2> UB2 { get; }

        /// <summary>
        /// PDA
        /// </summary>
        Segment<PDA> PDA { get; }

        /// <summary>
        /// PID2
        /// </summary>
        Segment<PID> PID2 { get; }

        /// <summary>
        /// PD12
        /// </summary>
        Segment<PD1> PD12 { get; }

        /// <summary>
        /// PV12
        /// </summary>
        Segment<PV1> PV12 { get; }

        /// <summary>
        /// PV22
        /// </summary>
        Segment<PV2> PV22 { get; }

        /// <summary>
        /// DB12
        /// </summary>
        SegmentList<DB1> DB12 { get; }

        /// <summary>
        /// OBX2
        /// </summary>
        SegmentList<OBX> OBX2 { get; }

        /// <summary>
        /// NPU
        /// </summary>
        Segment<NPU> NPU { get; }

        /// <summary>
        /// PATIENT
        /// </summary>
        LayoutList<ADT_AXX_PATIENT> ADT_AXX_PATIENT { get; }

        /// <summary>
        /// MERGE_INFO
        /// </summary>
        LayoutList<ADT_AXX_MERGE_INFO> ADT_AXX_MERGE_INFO { get; }

        /// <summary>
        /// IAM
        /// </summary>
        SegmentList<IAM> IAM { get; }
    }
}