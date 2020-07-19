// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// IAM (SegmentMap) - Patient Adverse Reaction Information
    /// </summary>
    public class IAMMap :
        HL7V26SegmentMap<IAM>
    {
        public IAMMap()
        {
            Id = "IAM";

            Name = "Patient Adverse Reaction Information";

            Value(x => x.SetId, 1, x => x.IsRequired());
            Entity(x => x.AllergenTypeCode, 2);
            Entity(x => x.AllergenCodeMnemonicDescription, 3, x => x.IsRequired());
            Entity(x => x.AllergySeverityCode, 4);
            Value(x => x.AllergyReactionCode, 5);
            Entity(x => x.AllergyActionCode, 6, x => x.IsRequired());
            Entity(x => x.AllergyUniqueIdentifier, 7);
            Value(x => x.ActionReason, 8);
            Entity(x => x.SensitivityToCausativeAgentCode, 9);
            Entity(x => x.AllergenGroupCodeMnemonicDescription, 10);
            Value(x => x.OnsetDate, 11, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.OnsetDateText, 12);
            Value(x => x.ReportedDateTime, 13, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Entity(x => x.ReportedBy, 14);
            Entity(x => x.RelationshipToPatientCode, 15);
            Entity(x => x.AlertDeviceCode, 16);
            Entity(x => x.AllergyClinicalStatusCode, 17);
            Entity(x => x.StatusedByPerson, 18);
            Entity(x => x.StatusedByOrganization, 19);
            Value(x => x.StatusedAtDateTime, 20, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
        }
    }
}