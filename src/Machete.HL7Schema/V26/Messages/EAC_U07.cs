namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// EAC_U07 (Message) - 
    /// </summary>
    public interface EAC_U07 :
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
        /// EQU
        /// </summary>
        Segment<EQU> EQU { get; }

        /// <summary>
        /// COMMAND
        /// </summary>
        LayoutList<EAC_U07_COMMAND> Command { get; }

        /// <summary>
        /// ROL
        /// </summary>
        Segment<ROL> ROL { get; }
    }
}