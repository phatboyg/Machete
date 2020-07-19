namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// EAR_U08 (Message) - 
    /// </summary>
    public interface EAR_U08 :
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
        /// COMMAND_RESPONSE
        /// </summary>
        LayoutList<EAR_U08_COMMAND_RESPONSE> CommandResponse { get; }

        /// <summary>
        /// ROL
        /// </summary>
        Segment<ROL> ROL { get; }
    }
}