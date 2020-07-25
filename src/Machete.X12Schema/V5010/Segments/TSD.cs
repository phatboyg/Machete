namespace Machete.X12Schema.V5010
{
    using X12;


    public interface TSD :
        X12Segment
    {
        Value<string> AssignedIdentification { get; }
        
        Value<string> Position { get; }
    }
}