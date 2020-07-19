// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// EHC_E15_PRODUCT_SERVICE_GROUP (Group) - 
    /// </summary>
    public interface EHC_E15_PRODUCT_SERVICE_GROUP :
        HL7V26Layout
    {
        /// <summary>
        /// PSG
        /// </summary>
        Segment<PSG> PSG { get; }

        /// <summary>
        /// PSL_ITEM_INFO
        /// </summary>
        LayoutList<EHC_E15_PSL_ITEM_INFO> PslItemInfo { get; }
    }
}