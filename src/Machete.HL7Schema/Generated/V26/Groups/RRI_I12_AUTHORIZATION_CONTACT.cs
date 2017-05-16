// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// RRI_I12_AUTHORIZATION_CONTACT (Group) - 
    /// </summary>
    public interface RRI_I12_AUTHORIZATION_CONTACT :
        HL7Layout
    {
        /// <summary>
        /// AUT
        /// </summary>
        Segment<AUT> AUT { get; }

        /// <summary>
        /// CTD
        /// </summary>
        Segment<CTD> CTD { get; }
    }
}