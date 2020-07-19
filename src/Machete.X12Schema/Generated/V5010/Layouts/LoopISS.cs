namespace Machete.X12Schema.V5010
{
    using Segments;
    using X12;


    public interface LoopISS :
        X12Layout
    {
        Segment<ISS> InvoiceShipmentSummary { get; }
        
        Segment<PID> ProductOrItemDescription { get; }
    }
}