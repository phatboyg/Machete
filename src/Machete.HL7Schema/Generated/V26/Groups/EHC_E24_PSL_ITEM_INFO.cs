// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// EHC_E24_PSL_ITEM_INFO (Group) - 
    /// </summary>
    public interface EHC_E24_PSL_ITEM_INFO :
        HL7Template
    {
        /// <summary>
        /// PSL
        /// </summary>
        Segment<PSL> PSL { get; }

        /// <summary>
        /// AUT
        /// </summary>
        Segment<AUT> AUT { get; }

        /// <summary>
        /// PAYER_ADJUSTMENT
        /// </summary>
        GroupList<EHC_E24_PAYER_ADJUSTMENT> PayerAdjustment { get; }
    }
}