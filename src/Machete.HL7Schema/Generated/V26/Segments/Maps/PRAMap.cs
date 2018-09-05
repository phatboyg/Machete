// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PRA (SegmentMap) - Practitioner Detail
    /// </summary>
    public class PRAMap :
        HL7V26SegmentMap<PRA>
    {
        public PRAMap()
        {
            Id = "PRA";

            Name = "Practitioner Detail";

            Entity(x => x.PrimaryKeyValue, 1);
            Entity(x => x.PractitionerGroup, 2);
            Value(x => x.PractitionerCategory, 3);
            Value(x => x.ProviderBilling, 4);
            Entity(x => x.Specialty, 5);
            Entity(x => x.PractitionerIdNumbers, 6);
            Entity(x => x.Privileges, 7);
            Value(x => x.DateEnteredPractice, 8, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Entity(x => x.Institution, 9);
            Value(x => x.DateLeftPractice, 10, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Entity(x => x.GovernmentReimbursementBillingEligibility, 11);
            Value(x => x.SetId, 12);
        }
    }
}