namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// ADT_A05 (Message) - 
    /// </summary>
    public interface ADT_A05 :
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
        LayoutList<ADT_A05_PROCEDURE> Procedure { get; }

        /// <summary>
        /// GT1
        /// </summary>
        SegmentList<GT1> GT1 { get; }

        /// <summary>
        /// INSURANCE
        /// </summary>
        LayoutList<ADT_A05_INSURANCE> Insurance { get; }

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
    }
}