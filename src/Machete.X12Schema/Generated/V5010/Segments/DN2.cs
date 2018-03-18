namespace Machete.X12Schema.V5010.Segments
{
    using X12;


    public interface DN2 :
        X12Segment
    {
        Value<string> ToothNumber { get; }
        
        Value<string> ToothStatusCode { get; }
        
        Value<decimal> Quantity { get; }
        
        Value<string> DateTimePeriodFormatQualifier { get; }
        
        Value<string> DateTimePeriod { get; }
        
        Value<string> CodeListQualifierCode { get; }
    }
}