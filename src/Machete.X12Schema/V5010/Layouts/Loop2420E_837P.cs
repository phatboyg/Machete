namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2420E_837P :
        X12Layout
    {
        Segment<NM1> OrderingProvider { get; }
        
        Segment<N3> Address { get; }
        
        Segment<N4> GeographicInformation { get; }
        
        SegmentList<REF> SecondaryIdentification { get; }
        
        Segment<PER> ContactInformation { get; }
    }
}