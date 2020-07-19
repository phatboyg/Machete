namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// CSU_C09 (Message) - 
    /// </summary>
    public interface CSU_C09 :
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
        /// PATIENT
        /// </summary>
        LayoutList<CSU_C09_PATIENT> Patient { get; }
    }
}