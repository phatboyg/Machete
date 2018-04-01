namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2100A_277Map :
        X12LayoutMap<L2100A_277, X12Entity>
    {
        public L2100A_277Map()
        {
            Id = "2100A";
            Name = "Payer Name";
            
            Segment(x => x.PayerName, 0, x => x.IsRequired());
            Segment(x => x.ContactInformation, 1);
        }
    }
}