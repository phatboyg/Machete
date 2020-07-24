namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopINVMap :
        X12LayoutMap<LoopINV, X12Entity>
    {
        public LoopINVMap()
        {
            Id = "Loop_INV_820";
            Name = "Loop INV";
            
            Segment(x => x.InvestmentVehicleSelection, 0);
            Segment(x => x.DateOrTimeReference, 1);
        }
    }
}