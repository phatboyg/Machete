// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// RQA_I08_AUTHORIZATION (Group) - 
    /// </summary>
    public interface RQA_I08_AUTHORIZATION :
        HL7V26Layout
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