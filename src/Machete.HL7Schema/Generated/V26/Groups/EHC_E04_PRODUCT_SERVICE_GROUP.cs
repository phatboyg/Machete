// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// EHC_E04_PRODUCT_SERVICE_GROUP (Group) - 
    /// </summary>
    public interface EHC_E04_PRODUCT_SERVICE_GROUP :
        HL7Template
    {
        /// <summary>
        /// PSG
        /// </summary>
        Segment<PSG> PSG { get; }

        /// <summary>
        /// PSL
        /// </summary>
        SegmentList<PSL> PSL { get; }
    }
}