namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L1000B_835Map :
        X12LayoutMap<L1000B_835, X12Entity>
    {
        public L1000B_835Map()
        {
            Id = "1000B";
            Name = "Payee Identification";
            
            Segment(x => x.Identification, 0, x => x.IsRequired());
            Segment(x => x.Address, 1);
            Segment(x => x.GeographicInformation, 2);
            Segment(x => x.AdditionalIdentification, 3);
            Segment(x => x.RemittanceDeliveryMethod, 4);
        }
    }
}