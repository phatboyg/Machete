// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// EHC_E15 (Message) - 
    /// </summary>
    public interface EHC_E15 :
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
        SegmentList<UAC> UAC { get; }

        /// <summary>
        /// PMT
        /// </summary>
        Segment<PMT> PMT { get; }

        /// <summary>
        /// PYE
        /// </summary>
        Segment<PYE> PYE { get; }

        /// <summary>
        /// PAYMENT_REMITTANCE_DETAIL_INFO
        /// </summary>
        LayoutList<EHC_E15_PAYMENT_REMITTANCE_DETAIL_INFO> PaymentRemittanceDetailInfo { get; }

        /// <summary>
        /// ADJUSTMENT_PAYEE
        /// </summary>
        LayoutList<EHC_E15_ADJUSTMENT_PAYEE> AdjustmentPayee { get; }
    }
}