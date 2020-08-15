namespace Machete.X12Schema.V5010
{
    using X12;


    public interface V4 :
        X12Segment
    {
        Value<string> VesselStowageLocation { get; }
    }
}