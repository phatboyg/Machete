// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// RRI_I12_PROCEDURE (Group) - 
    /// </summary>
    public interface RRI_I12_PROCEDURE :
        HL7Template
    {
        /// <summary>
        /// PR1
        /// </summary>
        Segment<PR1> PR1 { get; }

        /// <summary>
        /// AUTHORIZATION_CONTACT
        /// </summary>
        Group<RRI_I12_AUTHORIZATION_CONTACT> AuthorizationContact { get; }
    }
}