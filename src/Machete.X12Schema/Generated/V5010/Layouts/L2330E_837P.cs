namespace Machete.X12Schema.V5010.Layouts
{
    using X12;


    public interface L2330E_837P :
        X12Layout
    {
        Segment<NM1> FacilityLocation { get; }
        
        SegmentList<REF> SecondaryIdentification { get; }
    }
}