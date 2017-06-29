namespace Machete.HL7.Tests.Segments
{
    public interface PIDSegment :
        HL7Segment
    {
        Value<int> SetId { get; }
        Value<CXComponent> PatientId { get; }
        ValueList<CXComponent> PatientIdentifierList { get; }
    }
}