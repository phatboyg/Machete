namespace Machete.X12Schema.V5010
{
    using X12;


    public interface T990 :
        X12Layout
    {
        Segment<GS> FunctionalGroupHeader { get; }
        
        Segment<ST> TransactionSetHeader { get; }
        
        Segment<B1> BeginningBookingOrPickupDelivery { get; }
        
        Segment<L11> BusinessInstructionsAndReferenceNumber { get; }
        
        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
    }
}