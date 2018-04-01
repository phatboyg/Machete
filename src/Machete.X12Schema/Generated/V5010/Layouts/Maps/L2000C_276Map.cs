namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2000C_276Map :
        X12LayoutMap<L2000C_276, X12Entity>
    {
        public L2000C_276Map()
        {
            Id = "2000C";
            Name = "Service Provider Detail";
            
            Segment(x => x.ServiceProviderLevel, 0, x => x.IsRequired());
            Layout(x => x.ServiceProviderName, 1);
        }
    }
}