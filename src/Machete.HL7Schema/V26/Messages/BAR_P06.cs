namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// BAR_P06 (Message) - 
    /// </summary>
    public interface BAR_P06 :
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
        /// PATIENT
        /// </summary>
        LayoutList<BAR_P06_PATIENT> Patient { get; }
    }
}