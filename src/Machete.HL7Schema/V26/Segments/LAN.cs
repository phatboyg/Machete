// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// LAN (Segment) - Language Detail
    /// </summary>
    public interface LAN :
        HL7V26Segment
    {
        /// <summary>
        /// LAN-1: Set ID - LAN
        /// </summary>
        Value<int> SetId { get; }

        /// <summary>
        /// LAN-2: Language Code
        /// </summary>
        Value<CWE> LanguageCode { get; }

        /// <summary>
        /// LAN-3: Language Ability Code
        /// </summary>
        ValueList<CWE> LanguageAbilityCode { get; }

        /// <summary>
        /// LAN-4: Language Proficiency Code
        /// </summary>
        Value<CWE> LanguageProficiencyCode { get; }
    }
}