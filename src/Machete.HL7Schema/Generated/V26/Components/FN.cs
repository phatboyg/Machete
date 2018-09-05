// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// FN (Component) - Family Name
    /// </summary>
    public interface FN :
        HL7V26Component
    {
        /// <summary>
        /// FN-1  Surname
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> Surname { get; }

        /// <summary>
        /// FN-2  Own Surname Prefix
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> OwnSurnamePrefix { get; }

        /// <summary>
        /// FN-3  Own Surname
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> OwnSurname { get; }

        /// <summary>
        /// FN-4  Surname Prefix from Partner/Spouse
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> SurnamePrefixFromPartnerSpouse { get; }

        /// <summary>
        /// FN-5  Surname from Partner/Spouse
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> SurnameFromPartnerSpouse { get; }
    }
}