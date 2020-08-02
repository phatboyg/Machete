namespace Machete.X12Schema.V5010
{
    using X12;


    public interface G69 :
        X12Segment
    {
        Value<string> FreeformDescription { get; }
    }
}