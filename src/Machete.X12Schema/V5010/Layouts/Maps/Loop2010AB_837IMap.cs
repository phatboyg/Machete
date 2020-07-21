namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2010AB_837IMap :
        X12LayoutMap<Loop2010AB_837I, X12Entity>
    {
        public Loop2010AB_837IMap()
        {
            Id = "Loop_2010AB_837I";
            Name = "Pay-to Address Name";
            
            Segment(x => x.PayToAddressName, 0,
                x => x.Condition = parser => parser.Where(p => p.EntityIdentifierCode.IsEqualTo("87")));
            Segment(x => x.Address, 1);
            Segment(x => x.GeographicInformation, 2);
        }
    }
}