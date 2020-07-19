namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// EHC_E12 (Message) - 
    /// </summary>
    public interface EHC_E12 :
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
        SegmentList<UAC> UAC { get; }

        /// <summary>
        /// RFI
        /// </summary>
        Segment<RFI> RFI { get; }

        /// <summary>
        /// CTD
        /// </summary>
        SegmentList<CTD> CTD { get; }

        /// <summary>
        /// IVC
        /// </summary>
        Segment<IVC> IVC { get; }

        /// <summary>
        /// PSS
        /// </summary>
        Segment<PSS> PSS { get; }

        /// <summary>
        /// PSG
        /// </summary>
        Segment<PSG> PSG { get; }

        /// <summary>
        /// PID
        /// </summary>
        Segment<PID> PID { get; }

        /// <summary>
        /// PSL
        /// </summary>
        SegmentList<PSL> PSL { get; }

        /// <summary>
        /// REQUEST
        /// </summary>
        LayoutList<EHC_E12_REQUEST> Request { get; }
    }
}