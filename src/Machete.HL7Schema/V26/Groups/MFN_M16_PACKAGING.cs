// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// MFN_M16_PACKAGING (Group) - 
    /// </summary>
    public interface MFN_M16_PACKAGING :
        HL7V26Layout
    {
        /// <summary>
        /// PKG
        /// </summary>
        Segment<PKG> PKG { get; }

        /// <summary>
        /// PCE
        /// </summary>
        SegmentList<PCE> PCE { get; }
    }
}