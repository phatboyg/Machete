namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopL0_858Map :
        X12LayoutMap<LoopL0_858, X12Entity>
    {
        public LoopL0_858Map()
        {
            Id = "Loop_L0_858";
            Name = "Loop L0";
            
            Segment(x => x.LineItemQuantityAndWeight, 0);
            Segment(x => x.RateAndCharges, 1);
            Segment(x => x.Measurements, 2);
        }
    }
}