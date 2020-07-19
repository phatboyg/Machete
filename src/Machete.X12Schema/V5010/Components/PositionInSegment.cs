namespace Machete.X12Schema.V5010
{
    using X12;


    public interface PositionInSegment :
        X12Component
    {
        Value<int> ElementPositionInSegment { get; }
        
        Value<int> ComponentDataElementPositionInComposite { get; }
        
        Value<int> RepeatingDataElementPosition { get; }
    }
}