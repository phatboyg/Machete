namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// ESU_U01 (Message) - 
    /// </summary>
    public interface ESU_U01 :
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
        /// ISD
        /// </summary>
        SegmentList<ISD> ISD { get; }

        /// <summary>
        /// ROL
        /// </summary>
        Segment<ROL> ROL { get; }
    }
}