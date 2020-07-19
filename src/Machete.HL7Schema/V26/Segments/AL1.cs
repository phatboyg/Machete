// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// AL1 (Segment) - Patient Allergy Information
    /// </summary>
    public interface AL1 :
        HL7V26Segment
    {
        /// <summary>
        /// AL1-1: Set ID - AL1
        /// </summary>
        Value<int> SetId { get; }

        /// <summary>
        /// AL1-2: Allergen Type Code
        /// </summary>
        Value<CWE> AllergenTypeCode { get; }

        /// <summary>
        /// AL1-3: Allergen Code/Mnemonic/Description
        /// </summary>
        Value<CWE> AllergenCodeMnemonicDescription { get; }

        /// <summary>
        /// AL1-4: Allergy Severity Code
        /// </summary>
        Value<CWE> AllergySeverityCode { get; }

        /// <summary>
        /// AL1-5: Allergy Reaction Code
        /// </summary>
        ValueList<string> AllergyReactionCode { get; }

        /// <summary>
        /// AL1-6: Identification Date
        /// </summary>
        Value<DateTimeOffset> IdentificationDate { get; }
    }
}