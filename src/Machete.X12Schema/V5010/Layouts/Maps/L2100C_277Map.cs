namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2100C_277Map :
        X12LayoutMap<L2100C_277, X12Entity>
    {
        public L2100C_277Map()
        {
            Id = "2100C";
            Name = "Service Provider Name";
            
            Segment(x => x.ServiceProviderName, 0, x => x.IsRequired());
        }
    }
}