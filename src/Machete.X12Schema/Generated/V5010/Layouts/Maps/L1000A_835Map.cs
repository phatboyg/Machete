namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L1000A_835Map :
        X12LayoutMap<L1000A_835, X12Entity>
    {
        public L1000A_835Map()
        {
            Id = "1000A";
            Name = "Payer Identification";
            
            Segment(x => x.Identification, 0, x => x.IsRequired());
            Segment(x => x.Address, 1, x => x.IsRequired());
            Segment(x => x.GeographicInformation, 2, x => x.IsRequired());
            Segment(x => x.AdditionalIdentification, 3);
            Segment(x => x.BusinessContactInformation, 4);
            Segment(x => x.TechnicalContactInformation, 5, x => x.IsRequired());
            Segment(x => x.PayerWebsite, 6);
        }
    }
}