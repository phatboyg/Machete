namespace Machete.X12Schema.V5010
{
    using X12;


    public interface G53 :
        X12Segment
    {
        Value<string> MaintenanceTypeCode { get; }
    }
}