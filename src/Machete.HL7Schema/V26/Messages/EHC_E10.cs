namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// EHC_E10 (Message) - 
    /// </summary>
    public interface EHC_E10 :
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
        /// INVOICE_PROCESSING_RESULTS_INFO
        /// </summary>
        LayoutList<EHC_E10_INVOICE_PROCESSING_RESULTS_INFO> InvoiceProcessingResultsInfo { get; }
    }
}