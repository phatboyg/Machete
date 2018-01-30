namespace Machete.X12Schema.V5010
{
    using X12;
    
    
    public interface LX :
        X12Segment
    {
        Value<int> NumberAssigned { get; }
    }
}