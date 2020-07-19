namespace Machete.HL7Schema.V26
{
    using System;
    using HL7;


    public interface CON :
        HL7V26Segment
    {
        Value<int> SetId { get; }
        
        Value<CWE> ConsentType { get; }
        
        Value<string> ConsentFormIdAndVersion { get; }
        
        Value<EI> ConsentFormNumber { get; }
        
        ValueList<FT> ConsentText { get; }
        
        ValueList<FT> SubjectSpecificConsentText { get; }
        
        ValueList<FT> ConsentBackgroundInformation { get; }
        
        ValueList<FT> SubjectSpecificConsentBackgroundInformation { get; }
        
        ValueList<FT> ConsenterImposedLimitation { get; }
        
        Value<CNE> ConsentMode { get; }
        
        Value<CNE> ConsentStatus { get; }
        
        Value<DateTimeOffset> ConsentDiscussionDatetime { get; }
        
        Value<DateTimeOffset> ConsentDecisionDatetime { get; }
        
        Value<DateTimeOffset> ConsentEffectiveDatetime { get; }
        
        Value<DateTimeOffset> ConsentEndDatetime { get; }
        
        Value<string> SubjectCompetenceIndicator { get; }
        
        Value<string> TranslatorAssistanceIndicator { get; }
        
        Value<CWE> LanguageTranslatedTo { get; }
        
        Value<string> InformationalMaterialSuppliedIndicator { get; }
        
        Value<CWE> ConsentBypassReason { get; }
        
        Value<string> ConsentDisclosureLevel { get; }
        
        Value<CWE> ConsentNonDisclosureReason { get; }
        
        Value<CWE> NonSubjectConsenterReason { get; }
        
        ValueList<XPN> ConsenterId { get; }
        
        ValueList<string> RelationshipToSubject { get; }
    }
}