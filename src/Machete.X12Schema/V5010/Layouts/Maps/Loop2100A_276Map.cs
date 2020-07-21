namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2100A_276Map :
        X12LayoutMap<Loop2100A_276, X12Entity>
    {
        public Loop2100A_276Map()
        {
            Id = "Loop_2100A_276";
            Name = "Payer Name";
            
            Segment(x => x.Payer, 0);
        }
    }
}