namespace Machete.HL7.Tests.TestSchema
{
    public interface MacheteSample1Segment :
        HL7Segment
    {
        Value<string> Phone { get; }
    }
}