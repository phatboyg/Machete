// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// EHC_E13_REQUEST (Group) - 
    /// </summary>
    public interface EHC_E13_REQUEST :
        HL7Layout
    {
        /// <summary>
        /// CTD
        /// </summary>
        Segment<CTD> CTD { get; }

        /// <summary>
        /// OBR
        /// </summary>
        Segment<OBR> OBR { get; }

        /// <summary>
        /// NTE
        /// </summary>
        Segment<NTE> NTE { get; }

        /// <summary>
        /// RESPONSE
        /// </summary>
        LayoutList<EHC_E13_RESPONSE> Response { get; }
    }
}