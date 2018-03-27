namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2010BB_837DMap :
        X12LayoutMap<L2010BB_837D, X12Entity>
    {
        public L2010BB_837DMap()
        {
            Id = "2010BB";
            Name = "Payer Name";
            
            Segment(x => x.Payer, 0, x => x.IsRequired());
            Segment(x => x.Address, 1);
            Segment(x => x.GeographicInformation, 2);
            Segment(x => x.SecondaryIdentification, 3);
            Segment(x => x.BillingProviderSecondaryIdentification, 4);
        }
    }
}