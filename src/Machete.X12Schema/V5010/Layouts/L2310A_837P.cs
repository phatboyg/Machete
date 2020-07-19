namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L2310A_837P :
        X12Layout
    {
        Segment<NM1> Name { get; }
        
        SegmentList<REF> SecondaryIdentification { get; }
    }
}