namespace Machete.X12Schema.V5010
{
    using X12;


    public interface PRS :
        X12Segment
    {
        Value<string> PartReleaseStatusCode { get; }
        
        Value<string> Description { get; }
    }
}