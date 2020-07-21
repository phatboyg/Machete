namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2010AA_837IMap :
        X12LayoutMap<Loop2010AA_837I, X12Entity>
    {
        public Loop2010AA_837IMap()
        {
            Id = "Loop_2010AA_837I";
            Name = "Billing Provider Name";
            
            Segment(x => x.BillingProvider, 0,
                x => x.Condition = parser => parser.Where(p => p.EntityIdentifierCode.IsEqualTo("85")));
            Segment(x => x.Address, 1);
            Segment(x => x.GeographicInformation, 2);
            Segment(x => x.TaxIdNumber, 3);
            Segment(x => x.ContactInformation, 4);
        }
    }
}