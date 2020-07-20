namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2330A_837D :
        X12Layout
    {
        Segment<NM1> OtherSubscriber { get; }
        
        Segment<N3> Address { get; }
        
        Segment<N4> GeographicInformation { get; }
        
        SegmentList<REF> SecondaryIdentification { get; }
    }
}