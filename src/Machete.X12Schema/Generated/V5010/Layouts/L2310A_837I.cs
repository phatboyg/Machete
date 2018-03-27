namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L2310A_837I :
        X12Layout
    {
        Segment<NM1> AttendingProvider { get; }
        
        Segment<PRV> SpecialtyInformation { get; }
        
        SegmentList<REF> SecondaryIdentification { get; }
    }
}