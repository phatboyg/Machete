namespace Machete.X12Schema.V5010
{
    using X12;


    public interface HL :
        X12Segment
    {
        Value<string> IdNumber { get; }
        
        Value<string> ParentIdNumber { get; }
        
        Value<string> LevelCode { get; }
        
        Value<string> ChildCode { get; }
    }
}