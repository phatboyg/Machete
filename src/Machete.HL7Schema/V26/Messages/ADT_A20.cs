namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// ADT_A20 (Message) - 
    /// </summary>
    public interface ADT_A20 :
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
        /// NPU
        /// </summary>
        Segment<NPU> NPU { get; }
    }
}