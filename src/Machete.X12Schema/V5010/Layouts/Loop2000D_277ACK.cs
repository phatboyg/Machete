namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2000D_277ACK :
        X12Layout
    {
        Segment<HL> PatientLevel { get; }
        
        Layout<Loop2100D_277ACK> Loop2100D { get; }
        
        LayoutList<Loop2200D_277ACK> Loop2200D { get; }
    }
}