namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopINV_820Map :
        X12LayoutMap<LoopINV_820, X12Entity>
    {
        public LoopINV_820Map()
        {
            Id = "Loop_INV_820";
            Name = "Loop INV";
            
            Segment(x => x.InvestmentVehicleSelection, 0);
            Segment(x => x.DateOrTimeReference, 1);
        }
    }
}