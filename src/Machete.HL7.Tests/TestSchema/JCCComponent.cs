namespace Machete.HL7.Tests.TestSchema
{
    public interface JCCComponent :
        HL7Component
    {
        Value<string> JobCode { get; }
        Value<string> JobClass { get; }
    }
}