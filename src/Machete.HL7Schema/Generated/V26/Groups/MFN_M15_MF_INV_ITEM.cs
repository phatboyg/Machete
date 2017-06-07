// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// MFN_M15_MF_INV_ITEM (Group) - 
    /// </summary>
    public interface MFN_M15_MF_INV_ITEM :
        HL7V26Layout
    {
        /// <summary>
        /// MFE
        /// </summary>
        Segment<MFE> MFE { get; }

        /// <summary>
        /// IIM
        /// </summary>
        Segment<IIM> IIM { get; }
    }
}