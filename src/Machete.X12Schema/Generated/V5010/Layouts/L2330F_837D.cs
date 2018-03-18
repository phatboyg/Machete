namespace Machete.X12Schema.V5010.Layouts
{
    using X12;


    public interface L2330F_837D :
        X12Layout
    {
        Segment<NM1> BillingProvider { get; }
        
        SegmentList<REF> SecondaryIdentification { get; }
    }
}