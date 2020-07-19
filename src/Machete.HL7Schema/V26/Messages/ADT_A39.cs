namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// ADT_A39 (Message) - 
    /// </summary>
    public interface ADT_A39 :
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
        LayoutList<ADT_A39_PATIENT> Patient { get; }
    }
}