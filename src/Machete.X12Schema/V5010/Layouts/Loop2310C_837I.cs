namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2310C_837I :
        X12Layout
    {
        Segment<NM1> OtherOperatingPhysician { get; }
        
        SegmentList<REF> SecondaryIdentification { get; }
    }
}