// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// EHC_E15_PAYMENT_REMITTANCE_DETAIL_INFO (Group) - 
    /// </summary>
    public interface EHC_E15_PAYMENT_REMITTANCE_DETAIL_INFO :
        HL7Layout
    {
        /// <summary>
        /// IPR
        /// </summary>
        Segment<IPR> IPR { get; }

        /// <summary>
        /// IVC
        /// </summary>
        Segment<IVC> IVC { get; }

        /// <summary>
        /// PRODUCT_SERVICE_SECTION
        /// </summary>
        LayoutList<EHC_E15_PRODUCT_SERVICE_SECTION> ProductServiceSection { get; }
    }
}