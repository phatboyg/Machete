namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// DOC_T12 (Message) - 
    /// </summary>
    public interface DOC_T12 :
        HL7V26Layout
    {
        /// <summary>
        /// MSH
        /// </summary>
        Segment<MSH> MSH { get; }

        /// <summary>
        /// MSA
        /// </summary>
        Segment<MSA> MSA { get; }

        /// <summary>
        /// ERR
        /// </summary>
        Segment<ERR> ERR { get; }

        /// <summary>
        /// QAK
        /// </summary>
        Segment<QAK> QAK { get; }

        /// <summary>
        /// QRD
        /// </summary>
        Segment<QRD> QRD { get; }

        /// <summary>
        /// RESULT
        /// </summary>
        LayoutList<DOC_T12_RESULT> Result { get; }

        /// <summary>
        /// DSC
        /// </summary>
        Segment<DSC> DSC { get; }
    }
}