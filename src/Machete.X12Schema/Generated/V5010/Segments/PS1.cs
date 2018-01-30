namespace Machete.X12Schema.V5010
{
    using X12;
    
    
    public interface PS1 :
        X12Segment
    {
        Value<string> ReferenceIdentification { get; }

        Value<decimal> MonetaryAmount { get; }
    }
}