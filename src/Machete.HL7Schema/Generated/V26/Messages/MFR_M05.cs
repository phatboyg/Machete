// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// MFR_M05 (Message) - 
    /// </summary>
    public interface MFR_M05 :
        HL7Template
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
        /// QRD
        /// </summary>
        Segment<QRD> QRD { get; }

        /// <summary>
        /// QRF
        /// </summary>
        Segment<QRF> QRF { get; }

        /// <summary>
        /// MFI
        /// </summary>
        Segment<MFI> MFI { get; }

        /// <summary>
        /// MF_QUERY
        /// </summary>
        GroupList<MFR_M05_MF_QUERY> MfQuery { get; }

        /// <summary>
        /// DSC
        /// </summary>
        Segment<DSC> DSC { get; }
    }
}