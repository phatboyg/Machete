namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2100A_277Map :
        X12LayoutMap<Loop2100A_277, X12Entity>
    {
        public Loop2100A_277Map()
        {
            Id = "Loop_2100A_277";
            Name = "Payer Name";
            
            Segment(x => x.Payer, 0);
        }
    }
}