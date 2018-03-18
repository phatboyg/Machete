namespace Machete.X12Schema.V5010.Layouts
{
    using X12;


    public interface L2420A_837P :
        X12Layout
    {
        Segment<NM1> Provider { get; }
        
        Segment<PRV> SpecialtyInformation { get; }
        
        SegmentList<REF> SecondaryIdentification { get; }
    }
}