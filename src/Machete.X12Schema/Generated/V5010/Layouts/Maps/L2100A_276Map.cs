namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2100A_276Map :
        X12LayoutMap<L2100A_276, X12Entity>
    {
        public L2100A_276Map()
        {
            Id = "2100A";
            Name = "Payer Name";
            
            Segment(x => x.PayerName, 0, x => x.IsRequired());
        }
    }
}