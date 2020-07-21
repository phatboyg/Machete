namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2100C_276Map :
        X12LayoutMap<Loop2100C_276, X12Entity>
    {
        public Loop2100C_276Map()
        {
            Id = "Loop_2100C_276";
            Name = "Provider Name";
            
            Segment(x => x.ServiceProvider, 0);
        }
    }
}