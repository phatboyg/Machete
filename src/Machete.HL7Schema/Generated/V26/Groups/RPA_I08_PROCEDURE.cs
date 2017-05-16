// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// RPA_I08_PROCEDURE (Group) - 
    /// </summary>
    public interface RPA_I08_PROCEDURE :
        HL7Layout
    {
        /// <summary>
        /// PR1
        /// </summary>
        Segment<PR1> PR1 { get; }

        /// <summary>
        /// AUTHORIZATION
        /// </summary>
        Layout<RPA_I08_AUTHORIZATION> Authorization { get; }
    }
}