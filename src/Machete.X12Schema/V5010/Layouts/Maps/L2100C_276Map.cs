namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2100C_276Map :
        X12LayoutMap<L2100C_276, X12Entity>
    {
        public L2100C_276Map()
        {
            Id = "2100C";
            Name = "Provider Name";
            
            Segment(x => x.ServiceProviderName, 0, x => x.IsRequired());
        }
    }
}