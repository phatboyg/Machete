namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LHT :
        X12Segment
    {
        Value<string> HazardousClassification { get; }
        
        Value<string> HazardousPlacardNotation { get; }
        
        Value<string> HazardousEndorsement { get; }
    }
}