namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L2420D_837I :
        X12Layout
    {
        Segment<NM1> ReferringProvider { get; }
        
        SegmentList<REF> SecondaryIdentification { get; }
    }
}