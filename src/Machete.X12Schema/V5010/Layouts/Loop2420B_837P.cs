namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2420B_837P :
        X12Layout
    {
        Segment<NM1> PurchasedServiceProvider { get; }
        
        SegmentList<REF> SecondaryIdentification { get; }
    }
}