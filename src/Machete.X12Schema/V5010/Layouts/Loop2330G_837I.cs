namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2330G_837I :
        X12Layout
    {
        Segment<NM1> OtherPayerRenderingProvider { get; }
        
        SegmentList<REF> SecondaryIdentification { get; }
    }
}