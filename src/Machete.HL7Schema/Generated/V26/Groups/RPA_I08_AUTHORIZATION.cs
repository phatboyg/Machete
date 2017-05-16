// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// RPA_I08_AUTHORIZATION (Group) - 
    /// </summary>
    public interface RPA_I08_AUTHORIZATION :
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