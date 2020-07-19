namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L2420A_837D :
        X12Layout
    {
        Segment<NM1> Name { get; }
        
        Segment<PRV> SpecialtyInformation { get; }
        
        SegmentList<REF> SecondaryIdentification { get; }
    }
}