namespace Machete.HL7.Tests.Segments
{
    public interface MacheteSample1Segment :
        HL7Segment
    {
        Value<string> Phone { get; }
    }
}