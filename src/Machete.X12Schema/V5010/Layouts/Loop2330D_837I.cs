namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2330D_837I :
        X12Layout
    {
        Segment<NM1> OtherPayerOperatingPhysician { get; }
        
        SegmentList<REF> SecondaryIdentification { get; }
    }
}