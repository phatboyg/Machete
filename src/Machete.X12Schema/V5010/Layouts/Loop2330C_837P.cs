namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2330C_837P :
        X12Layout
    {
        Segment<NM1> OtherPayerReferringProvider { get; }
        
        SegmentList<REF> SecondaryIdentification { get; }
    }
}