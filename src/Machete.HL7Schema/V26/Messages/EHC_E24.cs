namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// EHC_E24 (Message) - 
    /// </summary>
    public interface EHC_E24 :
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
        /// MSA
        /// </summary>
        Segment<MSA> MSA { get; }

        /// <summary>
        /// ERR
        /// </summary>
        SegmentList<ERR> ERR { get; }

        /// <summary>
        /// IVC
        /// </summary>
        Segment<IVC> IVC { get; }

        /// <summary>
        /// PSL_ITEM_INFO
        /// </summary>
        LayoutList<EHC_E24_PSL_ITEM_INFO> PslItemInfo { get; }
    }
}