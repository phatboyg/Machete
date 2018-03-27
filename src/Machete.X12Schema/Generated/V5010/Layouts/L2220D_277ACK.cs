namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L2220D_277ACK :
        X12Layout
    {
        Segment<SVC> Information { get; }
        
        SegmentList<STC> LevelStatusInformation { get; }
        
        Segment<REF> ItemIdentification { get; }
        
        Segment<REF> PharmacyPrescriptionNumber { get; }
        
        Segment<REF> InstitutionalBillTypeIdentification { get; }
        
        Segment<DTP> Date { get; }
    }
}