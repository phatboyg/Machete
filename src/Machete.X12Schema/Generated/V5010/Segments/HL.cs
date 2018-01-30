namespace Machete.X12.Schema.Segments
{
    public interface HL :
        X12Segment
    {
        Value<string> IdNumber { get; }
        
        Value<string> ParentIdNumber { get; }
        
        Value<string> LevelCode { get; }
        
        Value<string> ChildCode { get; }
    }
}