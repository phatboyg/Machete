namespace Machete.X12Schema.V5010.Segments
{
    using X12;


    public interface PCT :
        X12Segment
    {
        Value<string> PercentQualifier { get; }
        
        Value<decimal> Percent { get; }
    }
}