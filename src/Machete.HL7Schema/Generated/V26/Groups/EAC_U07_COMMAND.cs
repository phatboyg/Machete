// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// EAC_U07_COMMAND (Group) - 
    /// </summary>
    public interface EAC_U07_COMMAND :
        HL7Layout
    {
        /// <summary>
        /// ECD
        /// </summary>
        Segment<ECD> ECD { get; }

        /// <summary>
        /// TQ1
        /// </summary>
        Segment<TQ1> TQ1 { get; }

        /// <summary>
        /// SPECIMEN_CONTAINER
        /// </summary>
        Layout<EAC_U07_SPECIMEN_CONTAINER> SpecimenContainer { get; }

        /// <summary>
        /// CNS
        /// </summary>
        Segment<CNS> CNS { get; }
    }
}