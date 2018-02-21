namespace Machete.X12Schema.V5010.Layouts
{
    using X12;


    public interface L2420B_837P :
        X12Layout
    {
        Segment<NM1> Provider { get; }
        
        SegmentList<REF> SecondaryIdentification { get; }
    }
}