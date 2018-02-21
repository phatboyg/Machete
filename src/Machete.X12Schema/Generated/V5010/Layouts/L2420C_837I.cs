namespace Machete.X12Schema.V5010.Layouts
{
    using X12;


    public interface L2420C_837I :
        X12Layout
    {
        Segment<NM1> ProviderName { get; }
        
        SegmentList<REF> SecondaryIdentification { get; }
    }
}