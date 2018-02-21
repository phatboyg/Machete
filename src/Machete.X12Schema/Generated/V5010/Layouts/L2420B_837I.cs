namespace Machete.X12Schema.V5010.Layouts
{
    using X12;


    public interface L2420B_837I :
        X12Layout
    {
        Segment<NM1> Physician { get; }
        
        SegmentList<REF> SecondaryIdentification { get; }
    }
}