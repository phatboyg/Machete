namespace Machete.X12Schema.V5010
{
    using X12;


    public interface TDS :
        X12Segment
    {
        Value<decimal> Amount1 { get; }
        
        Value<decimal> Amount2 { get; }
        
        Value<decimal> Amount3 { get; }
        
        Value<decimal> Amount4 { get; }
    }
}