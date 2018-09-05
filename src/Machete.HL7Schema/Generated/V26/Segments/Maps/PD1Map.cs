// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PD1 (SegmentMap) - Patient Additional Demographic
    /// </summary>
    public class PD1Map :
        HL7V26SegmentMap<PD1>
    {
        public PD1Map()
        {
            Id = "PD1";

            Name = "Patient Additional Demographic";

            Value(x => x.LivingDependency, 1);
            Value(x => x.LivingArrangement, 2);
            Entity(x => x.PatientPrimaryFacility, 3);
            Entity(x => x.PatientPrimaryCareProviderNameIdNo, 4);
            Value(x => x.StudentIndicator, 5);
            Value(x => x.Handicap, 6);
            Value(x => x.LivingWillCode, 7);
            Value(x => x.OrganDonorCode, 8);
            Value(x => x.SeparateBill, 9);
            Entity(x => x.DuplicatePatient, 10);
            Entity(x => x.PublicityCode, 11);
            Value(x => x.ProtectionIndicator, 12);
            Value(x => x.ProtectionIndicatorEffectiveDate, 13, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Entity(x => x.PlaceOfWorship, 14);
            Entity(x => x.AdvanceDirectiveCode, 15);
            Value(x => x.ImmunizationRegistryStatus, 16);
            Value(x => x.ImmunizationRegistryStatusEffectiveDate, 17, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.PublicityCodeEffectiveDate, 18, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.MilitaryBranch, 19);
            Value(x => x.MilitaryRankGrade, 20);
            Value(x => x.MilitaryStatus, 21);
            Value(x => x.AdvanceDirectiveLastVerifiedDate, 22, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
        }
    }
}