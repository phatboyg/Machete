namespace Machete.HL7.Tests.TestSchema
{
    public interface WillNeverMatchLayout :
        HL7Layout
    {
        Segment<MSHSegment> MSH { get; }
        
        Segment<MTS> MTS { get; }
        
        Segment<PIDSegment> PID { get; }
    }
}