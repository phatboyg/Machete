namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2000C_276Map :
        X12LayoutMap<Loop2000C_276, X12Entity>
    {
        public Loop2000C_276Map()
        {
            Id = "Loop_2000C_276";
            Name = "Service Provider Detail";
            
            Segment(x => x.ServiceProviderLevel, 0);
            Layout(x => x.Loop2100C, 1);
        }
    }
}