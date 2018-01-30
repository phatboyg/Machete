namespace Machete.X12.Schema.Segments
{
    public interface IEA :
        X12Segment
    {
        Value<int> FunctionalGroupCount { get; }
        
        Value<int> ControlNumber { get; }
    }
}