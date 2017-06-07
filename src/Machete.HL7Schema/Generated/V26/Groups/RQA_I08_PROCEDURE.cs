// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// RQA_I08_PROCEDURE (Group) - 
    /// </summary>
    public interface RQA_I08_PROCEDURE :
        HL7V26Layout
    {
        /// <summary>
        /// PR1
        /// </summary>
        Segment<PR1> PR1 { get; }

        /// <summary>
        /// AUTHORIZATION
        /// </summary>
        Layout<RQA_I08_AUTHORIZATION> Authorization { get; }
    }
}