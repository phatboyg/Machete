// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// RSP_K25 (Message) - 
    /// </summary>
    public interface RSP_K25 :
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
        /// MSA
        /// </summary>
        Segment<MSA> MSA { get; }

        /// <summary>
        /// ERR
        /// </summary>
        SegmentList<ERR> ERR { get; }

        /// <summary>
        /// QAK
        /// </summary>
        Segment<QAK> QAK { get; }

        /// <summary>
        /// QPD
        /// </summary>
        Segment<QPD> QPD { get; }

        /// <summary>
        /// RCP
        /// </summary>
        Segment<RCP> RCP { get; }

        /// <summary>
        /// STAFF
        /// </summary>
        LayoutList<RSP_K25_STAFF> Staff { get; }

        /// <summary>
        /// DSC
        /// </summary>
        Segment<DSC> DSC { get; }
    }
}