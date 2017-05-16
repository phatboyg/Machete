// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// MFN_M16_PURCHASING_VENDOR (Group) - 
    /// </summary>
    public interface MFN_M16_PURCHASING_VENDOR :
        HL7Layout
    {
        /// <summary>
        /// VND
        /// </summary>
        Segment<VND> VND { get; }

        /// <summary>
        /// PACKAGING
        /// </summary>
        LayoutList<MFN_M16_PACKAGING> Packaging { get; }
    }
}