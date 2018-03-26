namespace Machete.HL7.Tests.TestSchema
{
    public interface MTS :
        HL7Segment
    {
        Value<string> Field1 { get; }
    }
}