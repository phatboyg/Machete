namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2420A_837P :
        X12Layout
    {
        Segment<NM1> RenderingProvider { get; }
        
        Segment<PRV> SpecialtyInformation { get; }
        
        SegmentList<REF> SecondaryIdentification { get; }
    }
}