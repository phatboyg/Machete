namespace Machete.X12Schema.V5010.Layouts
{
    using X12;


    public interface L2330C_837I :
        X12Layout
    {
        Segment<NM1> AttendingProvider { get; }
        
        SegmentList<REF> SecondaryIdentification { get; }
    }
}