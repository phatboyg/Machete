namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopISS_810 :
        X12Layout
    {
        Segment<ISS> InvoiceShipmentSummary { get; }
        
        Segment<PID> ProductOrItemDescription { get; }
    }
}