namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop1000B_835Map :
        X12LayoutMap<Loop1000B_835, X12Entity>
    {
        public Loop1000B_835Map()
        {
            Id = "Loop_1000B_835";
            Name = "Payee Identification";
            
            Segment(x => x.PayeeIdentification, 0);
            Segment(x => x.Address, 1);
            Segment(x => x.GeographicInformation, 2);
            Segment(x => x.AdditionalIdentification, 3);
            Segment(x => x.RemittanceDeliveryMethod, 4);
        }
    }
}