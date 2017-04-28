// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// EHC_E10_INVOICE_PROCESSING_RESULTS_INFO (Group) - 
    /// </summary>
    public interface EHC_E10_INVOICE_PROCESSING_RESULTS_INFO :
        HL7Template
    {
        /// <summary>
        /// IPR
        /// </summary>
        Segment<IPR> IPR { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }

        /// <summary>
        /// PYE
        /// </summary>
        Segment<PYE> PYE { get; }

        /// <summary>
        /// IN1
        /// </summary>
        Segment<IN1> IN1 { get; }

        /// <summary>
        /// IN2
        /// </summary>
        Segment<IN2> IN2 { get; }

        /// <summary>
        /// IVC
        /// </summary>
        Segment<IVC> IVC { get; }

        /// <summary>
        /// PRODUCT_SERVICE_SECTION
        /// </summary>
        GroupList<EHC_E10_PRODUCT_SERVICE_SECTION> ProductServiceSection { get; }
    }
}