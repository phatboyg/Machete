namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2220D_277 :
        X12Layout
    {
        Segment<SVC> ServiceLineInformation { get; }
        
        SegmentList<STC> StatusInformation { get; }
        
        Segment<REF> ItemIdentification { get; }
        
        Segment<REF> PharmacyPrescriptionNumber { get; }
        
        Segment<DTP> Date { get; }
    }
}