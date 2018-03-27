namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2330B_837IMap :
        X12LayoutMap<L2330B_837I, X12Entity>
    {
        public L2330B_837IMap()
        {
            Id = "2330B";
            Name = "Other Payer Name";
            
            Segment(x => x.Payer, 0, x => x.IsRequired());
            Segment(x => x.Address, 1);
            Segment(x => x.GeographicInformation, 2);
            Segment(x => x.ClaimCheckOrRemittanceDate, 3);
            Segment(x => x.SecondaryIdentification, 4);
            Segment(x => x.PriorAuthorizationNumber, 5);
            Segment(x => x.ReferralNumber, 6);
            Segment(x => x.ClaimAdjustmentIndicator, 7);
            Segment(x => x.ClaimControlNumber, 8);
        }
    }
}