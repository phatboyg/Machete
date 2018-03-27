namespace Machete.X12Schema.V5010
{
    using X12;


    public interface DN1 :
        X12Segment
    {
        Value<int> Quantity1 { get; }
        
        Value<int> Quantity2 { get; }
        
        Value<string> Description { get; }
    }
}