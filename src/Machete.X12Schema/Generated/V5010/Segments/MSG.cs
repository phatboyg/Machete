namespace Machete.X12Schema.V5010
{
    using X12;
    
    
    public interface MSG :
        X12Segment
    {
        Value<string> FreeFormMessageText { get; }
    }
}