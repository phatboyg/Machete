// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// EAR_U08_COMMAND_RESPONSE (Group) - 
    /// </summary>
    public interface EAR_U08_COMMAND_RESPONSE :
        HL7Layout
    {
        /// <summary>
        /// ECD
        /// </summary>
        Segment<ECD> ECD { get; }

        /// <summary>
        /// SPECIMEN_CONTAINER
        /// </summary>
        Layout<EAR_U08_SPECIMEN_CONTAINER> SpecimenContainer { get; }

        /// <summary>
        /// ECR
        /// </summary>
        Segment<ECR> ECR { get; }
    }
}