namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2100_835Map :
        X12LayoutMap<L2100_835, X12Entity>
    {
        public L2100_835Map()
        {
            Id = "2100";
            Name = "Claim Payment Information";
            
            Segment(x => x.ClaimPaymentInformation, 0, x => x.IsRequired());
            Segment(x => x.ClaimAdjustment, 1);
            Segment(x => x.PatientName, 2, x => x.IsRequired());
            Segment(x => x.InsuredName, 3);
            Segment(x => x.CorrectedPatientOrInsuredName, 4);
            Segment(x => x.ServiceProviderName, 5);
            Segment(x => x.CrossoverCarrierName, 6);
            Segment(x => x.CorrectedPriorityPayerName, 7);
            Segment(x => x.OtherSubscriberName, 8);
            Segment(x => x.InpatientAdjudicationInformation, 9);
            Segment(x => x.OutpatientAdjudicationInformation, 10);
            Segment(x => x.OtherClaimRelatedIdentification, 11);
            Segment(x => x.RenderingProviderIdentification, 12);
            Segment(x => x.StatementFromOrToDate, 13);
            Segment(x => x.CoverageExpirationDate, 14);
            Segment(x => x.ClaimReceivedDate, 15);
            Segment(x => x.ClaimContactInformation, 16);
            Segment(x => x.ClaimSupplementalInformation, 17);
            Segment(x => x.ClaimSupplementalInformationQuantity, 18);
            Layout(x => x.ServicePaymentInformation, 19);
        }
    }
}