namespace Machete.X12Schema.V5010.Layouts
{
    using X12;


    public interface L2310F_837I :
        X12Layout
    {
        Segment<NM1> ReferringProvider { get; }
        
        SegmentList<N4> SecondaryIdentification { get; }
    }
}