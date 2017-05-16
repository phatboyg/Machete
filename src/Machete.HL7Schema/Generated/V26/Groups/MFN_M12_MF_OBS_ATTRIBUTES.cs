// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// MFN_M12_MF_OBS_ATTRIBUTES (Group) - 
    /// </summary>
    public interface MFN_M12_MF_OBS_ATTRIBUTES :
        HL7Layout
    {
        /// <summary>
        /// MFE
        /// </summary>
        Segment<MFE> MFE { get; }

        /// <summary>
        /// OM1
        /// </summary>
        Segment<OM1> OM1 { get; }

        /// <summary>
        /// OM7
        /// </summary>
        Segment<OM7> OM7 { get; }
    }
}