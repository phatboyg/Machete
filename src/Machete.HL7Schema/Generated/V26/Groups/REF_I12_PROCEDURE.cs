// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// REF_I12_PROCEDURE (Group) - 
    /// </summary>
    public interface REF_I12_PROCEDURE :
        HL7Layout
    {
        /// <summary>
        /// PR1
        /// </summary>
        Segment<PR1> PR1 { get; }

        /// <summary>
        /// AUTHORIZATION_CONTACT
        /// </summary>
        Layout<REF_I12_AUTHORIZATION_CONTACT> AuthorizationContact { get; }
    }
}