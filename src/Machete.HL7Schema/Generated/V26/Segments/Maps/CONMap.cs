namespace Machete.HL7Schema.V26.Maps
{
    public class CONMap :
        HL7V26SegmentMap<CON>
    {
        public CONMap()
        {
            Id = "CON";

            Name = "Consent";

            Value(x => x.SetId, 1, x => x.IsRequired());
            Entity(x => x.ConsentType, 2);
            Value(x => x.ConsentFormIdAndVersion, 3);
            Entity(x => x.ConsentFormNumber, 4);
            Value(x => x.ConsentText, 5);
            Value(x => x.SubjectSpecificConsentText, 6);
            Value(x => x.ConsentBackgroundInformation, 7);
            Value(x => x.SubjectSpecificConsentBackgroundInformation, 8);
            Value(x => x.ConsenterImposedLimitation, 9);
            Entity(x => x.ConsentMode, 10);
            Entity(x => x.ConsentStatus, 11, x => x.IsRequired());
            Value(x => x.ConsentDiscussionDatetime, 12, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.ConsentDecisionDatetime, 13, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.ConsentEffectiveDatetime, 14, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.ConsentEndDatetime, 15, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.SubjectCompetenceIndicator, 16);
            Value(x => x.TranslatorAssistanceIndicator, 17);
            Entity(x => x.LanguageTranslatedTo, 18);
            Value(x => x.InformationalMaterialSuppliedIndicator, 19);
            Entity(x => x.ConsentBypassReason, 20);
            Value(x => x.ConsentDisclosureLevel, 21);
            Entity(x => x.ConsentNonDisclosureReason, 22);
            Entity(x => x.NonSubjectConsenterReason, 23);
            Entity(x => x.ConsenterId, 24);
            Value(x => x.RelationshipToSubject, 25);
        }
    }
}