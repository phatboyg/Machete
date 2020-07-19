// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// AL1 (SegmentMap) - Patient Allergy Information
    /// </summary>
    public class AL1Map :
        HL7V26SegmentMap<AL1>
    {
        public AL1Map()
        {
            Id = "AL1";

            Name = "Patient Allergy Information";

            Value(x => x.SetId, 1, x => x.IsRequired());
            Entity(x => x.AllergenTypeCode, 2);
            Entity(x => x.AllergenCodeMnemonicDescription, 3, x => x.IsRequired());
            Entity(x => x.AllergySeverityCode, 4);
            Value(x => x.AllergyReactionCode, 5);
            Value(x => x.IdentificationDate, 6, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
        }
    }
}