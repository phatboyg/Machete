// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// QBP_Qnn (Message) - 
    /// </summary>
    public interface QBP_Qnn :
        HL7Layout
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
        /// QPD
        /// </summary>
        Segment<QPD> QPD { get; }

        /// <summary>
        /// RDF
        /// </summary>
        Segment<RDF> RDF { get; }

        /// <summary>
        /// RCP
        /// </summary>
        Segment<RCP> RCP { get; }

        /// <summary>
        /// DSC
        /// </summary>
        Segment<DSC> DSC { get; }

        /// <summary>
        /// MSH2
        /// </summary>
        Segment<MSH> MSH2 { get; }

        /// <summary>
        /// SFT2
        /// </summary>
        SegmentList<SFT> SFT2 { get; }

        /// <summary>
        /// UAC2
        /// </summary>
        Segment<UAC> UAC2 { get; }

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
        /// QPD2
        /// </summary>
        Segment<QPD> QPD2 { get; }

        /// <summary>
        /// Hxx
        /// </summary>
        Segment<HL7Segment> Hxx { get; }

        /// <summary>
        /// DSC2
        /// </summary>
        Segment<DSC> DSC2 { get; }
    }
}