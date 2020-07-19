namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2110_835Map :
        X12LayoutMap<L2110_835, X12Entity>
    {
        public L2110_835Map()
        {
            Id = "2110";
            Name = "Service Payment Information";
            
            Segment(x => x.ServicePaymentInformation, 0);
            Segment(x => x.ServiceDate, 1);
            Segment(x => x.ServiceAdjustment, 2);
            Segment(x => x.ServiceIdentification, 3);
            Segment(x => x.LineItemControlNumber, 4);
            Segment(x => x.RenderingProviderInformation, 5);
            Segment(x => x.HealthcarePolicyIdentification, 6);
            Segment(x => x.ServiceSupplementalAmount, 7);
            Segment(x => x.ServiceSupplementalQuantity, 8);
            Segment(x => x.HealthcareRemarkCodes, 9);
        }
    }
}