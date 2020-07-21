namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop1000A_835Map :
        X12LayoutMap<Loop1000A_835, X12Entity>
    {
        public Loop1000A_835Map()
        {
            Id = "Loop_1000A_835";
            Name = "Payer Identification";
            
            Segment(x => x.PayerIdentification, 0);
            Segment(x => x.Address, 1);
            Segment(x => x.GeographicInformation, 2);
            Segment(x => x.AdditionalIdentification, 3);
            Segment(x => x.BusinessContactInformation, 4,
                x => x.Condition = parser => parser.Where(p => p.ContactFunctionCode.IsEqualTo("CX")));
            Segment(x => x.TechnicalContactInformation, 5,
                x => x.Condition = parser => parser.Where(p => p.ContactFunctionCode.IsEqualTo("BL")));
            Segment(x => x.PayerWebsite, 6,
                x => x.Condition = parser => parser.Where(p => p.ContactFunctionCode.IsEqualTo("IC")));
        }
    }
}