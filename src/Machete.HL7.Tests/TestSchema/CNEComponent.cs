namespace Machete.HL7.Tests.TestSchema
{
    public interface CNEComponent :
        HL7Component
    {
        Value<string> Identifier { get; }
        Value<string> Text { get; }
        Value<string> NameOfCodingSystem { get; }
        Value<string> AlternateIdentifier { get; }
        Value<string> AlternateText { get; }
        Value<string> NameOfAlternateCodingSystem { get; }
        Value<string> CodingSystemVersionId { get; }
        Value<string> AlternateCodingSystemVersionId { get; }
        Value<string> OriginalText { get; }
    }
}