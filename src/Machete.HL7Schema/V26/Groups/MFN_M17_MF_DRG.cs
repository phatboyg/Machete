// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// MFN_M17_MF_DRG (Group) - 
    /// </summary>
    public interface MFN_M17_MF_DRG :
        HL7V26Layout
    {
        /// <summary>
        /// MFE
        /// </summary>
        Segment<MFE> MFE { get; }

        /// <summary>
        /// DMI
        /// </summary>
        Segment<DMI> DMI { get; }
    }
}