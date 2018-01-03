namespace Machete.HL7.Tests.TestSchema
{
    public interface FNComponent :
        HL7Component
    {
        Value<string> Surname { get; }
        Value<string> OwnSurnamePrefix { get; }
        Value<string> OwnSurname { get; }
        Value<string> SurnamePrefixFromPartnerSpouse { get; }
        Value<string> SurnameFromPartnerSpouse { get; }
    }
}