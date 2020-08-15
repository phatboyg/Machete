namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopE1_858 :
        X12Layout
    {
        Segment<E1> EmptyCarDispositionPendedDestinationConsignee { get; }
        
        Segment<E1> EmptyCarDispositionPendedDestinationCity { get; }
        
        SegmentList<E1> EmptyCarDispositionPendedDestinationRoute { get; }
        
        Segment<PI> PriceAuthorityIdentification { get; }
    }
}