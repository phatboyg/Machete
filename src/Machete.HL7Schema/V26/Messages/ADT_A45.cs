namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// ADT_A45 (Message) - 
    /// </summary>
    public interface ADT_A45 :
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
        /// MERGE_INFO
        /// </summary>
        LayoutList<ADT_A45_MERGE_INFO> MergeInfo { get; }
    }
}