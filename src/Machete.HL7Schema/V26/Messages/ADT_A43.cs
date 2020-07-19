namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// ADT_A43 (Message) - 
    /// </summary>
    public interface ADT_A43 :
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
        LayoutList<ADT_A43_PATIENT> Patient { get; }
    }
}