namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L2420D_837P :
        X12Layout
    {
        Segment<NM1> SupervisingProvider { get; }
        
        SegmentList<REF> SecondaryIdentification { get; }
    }
}