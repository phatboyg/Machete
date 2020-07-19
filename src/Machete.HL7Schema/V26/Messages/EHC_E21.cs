namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// EHC_E21 (Message) - 
    /// </summary>
    public interface EHC_E21 :
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
        /// IVC
        /// </summary>
        Segment<IVC> IVC { get; }

        /// <summary>
        /// PSL_ITEM_INFO
        /// </summary>
        LayoutList<EHC_E21_PSL_ITEM_INFO> PslItemInfo { get; }
    }
}