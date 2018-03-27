namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L2330F_837I :
        X12Layout
    {
        Segment<NM1> ServiceFacilityLocation { get; }
        
        SegmentList<REF> SecondaryIdentification { get; }
    }
}