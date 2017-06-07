// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// PRL (Component) - Parent Result Link
    /// </summary>
    public interface PRL :
        HL7V26Component
    {
        /// <summary>
        /// PRL-1  Parent Observation Identifier
        /// </summary>
        /// <returns>The CWE value</returns>
        Value<CWE> ParentObservationIdentifier { get; }

        /// <summary>
        /// PRL-2  Parent Observation Sub-identifier
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> ParentObservationSubIdentifier { get; }

        /// <summary>
        /// PRL-3  Parent Observation Value Descriptor
        /// </summary>
        /// <returns>The TX value</returns>
        Value<TX> ParentObservationValueDescriptor { get; }
    }
}