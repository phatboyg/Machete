namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// CRM_C01 (Message) - 
    /// </summary>
    public interface CRM_C01 :
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
        LayoutList<CRM_C01_PATIENT> Patient { get; }
    }
}