namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2010AC_837DMap :
        X12LayoutMap<L2010AC_837D, X12Entity>
    {
        public L2010AC_837DMap()
        {
            Id = "2010AC";
            Name = "Pay-to Plan Name";
            
            Segment(x => x.Plan, 0);
            Segment(x => x.Address, 1, x => x.IsRequired());
            Segment(x => x.GeographicInformation, 2, x => x.IsRequired());
            Segment(x => x.SecondaryIdentification, 3);
            Segment(x => x.TaxIdNumber, 4, x => x.IsRequired());
        }
    }
}