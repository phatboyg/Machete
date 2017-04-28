// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// EHC_E10_PRODUCT_SERVICE_GROUP (Group) - 
    /// </summary>
    public interface EHC_E10_PRODUCT_SERVICE_GROUP :
        HL7Template
    {
        /// <summary>
        /// PSG
        /// </summary>
        Segment<PSG> PSG { get; }

        /// <summary>
        /// PRODUCT_SERVICE_LINE_INFO
        /// </summary>
        GroupList<EHC_E10_PRODUCT_SERVICE_LINE_INFO> ProductServiceLineInfo { get; }
    }
}