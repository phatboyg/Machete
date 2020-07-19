// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// RSP_E22 (Message) - 
    /// </summary>
    public interface RSP_E22 :
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
        /// QAK
        /// </summary>
        Segment<QAK> QAK { get; }

        /// <summary>
        /// QPD
        /// </summary>
        Segment<QPD> QPD { get; }

        /// <summary>
        /// AUTHORIZATION_INFO
        /// </summary>
        Layout<RSP_E22_AUTHORIZATION_INFO> AuthorizationInfo { get; }
    }
}