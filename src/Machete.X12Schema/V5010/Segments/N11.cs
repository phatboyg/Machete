namespace Machete.X12Schema.V5010.Segments
{
    using X12;


    public interface N11 :
        X12Segment
    {
        Value<string> StoreNumber { get; }
        
        Value<string> LocationIdentifier { get; }
        
        Value<string> ReferenceIdentification { get; }
    }
}