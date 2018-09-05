namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L2000D_277ACK :
        X12Layout
    {
        Segment<HL> PatientLevel { get; }
        
        Layout<L2100D_277ACK> PatientName { get; }
        
        LayoutList<L2200D_277ACK> ClaimStatusTrackingNumber { get; }
    }
}