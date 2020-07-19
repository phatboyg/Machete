// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// EHC_E01_PRODUCT_SERVICE_SECTION (Group) - 
    /// </summary>
    public interface EHC_E01_PRODUCT_SERVICE_SECTION :
        HL7V26Layout
    {
        /// <summary>
        /// PSS
        /// </summary>
        Segment<PSS> PSS { get; }

        /// <summary>
        /// PRODUCT_SERVICE_GROUP
        /// </summary>
        LayoutList<EHC_E01_PRODUCT_SERVICE_GROUP> ProductServiceGroup { get; }
    }
}