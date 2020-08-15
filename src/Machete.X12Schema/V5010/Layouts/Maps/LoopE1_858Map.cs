namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopE1_858Map :
        X12LayoutMap<LoopE1_858, X12Entity>
    {
        public LoopE1_858Map()
        {
            Id = "Loop_E1_858";
            Name = "Loop E1";
            
            Segment(x => x.EmptyCarDispositionPendedDestinationConsignee, 0);
            Segment(x => x.EmptyCarDispositionPendedDestinationCity, 1);
            Segment(x => x.EmptyCarDispositionPendedDestinationRoute, 2);
            Segment(x => x.PriceAuthorityIdentification, 3);
        }
    }
}