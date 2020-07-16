namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2010AA_837IMap :
        X12LayoutMap<L2010AA_837I, X12Entity>
    {
        public L2010AA_837IMap()
        {
            Id = "2010AA";
            Name = "Billing Provider Name";
            
            Segment(x => x.Name, 0,
                x => x.Condition = parser => parser.Where(p => p.EntityIdentifierCode.IsEqualTo("85")));
            Segment(x => x.Address, 1);
            Segment(x => x.GeographicInformation, 2);
            Segment(x => x.TaxIdNumber, 3);
            Segment(x => x.ContactInformation, 4);
        }
    }
}