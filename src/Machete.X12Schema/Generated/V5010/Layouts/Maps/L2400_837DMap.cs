namespace Machete.X12Schema.V5010.Layouts.Maps
{
    using X12;
    using X12.Configuration;


    public class L2400_837DMap :
        X12LayoutMap<L2400_837D, X12Entity>
    {
        public L2400_837DMap()
        {
            Id = "2400";
            Name = "Service Line Number";
            
            Segment(x => x.ServiceLineNumber, 0, x => x.IsRequired());
            Segment(x => x.DentalService, 1, x => x.IsRequired());
            Segment(x => x.ToothInformation, 2);
            Segment(x => x.ServiceDate, 3);
            Segment(x => x.PriorPlacementDate, 4);
            Segment(x => x.AppliancePlacementDate, 5);
            Segment(x => x.ReplacementDate, 6);
            Segment(x => x.TreatmentStartDate, 7);
            Segment(x => x.TreatmentCompletionDate, 8);
            Segment(x => x.ContractInformation, 16);
            Segment(x => x.ServicePredeterminationIndentification, 9);
            Segment(x => x.PriorAuthorization, 10);
            Segment(x => x.LineItemControlNumber, 11);
            Segment(x => x.RepricedClaimNumber, 12);
            Segment(x => x.AdjustedRepricedClaimNumber, 13);
            Segment(x => x.ReferralNumber, 14);
            Segment(x => x.SalesTaxAmount, 15);
            Segment(x => x.FileInformation, 16);
            Segment(x => x.LinePricingOrRepricingInfo, 17);
            Layout(x => x.RenderingProvider, 18);
            Layout(x => x.AssistantSurgeon, 19);
            Layout(x => x.SupervisingProvider, 20);
            Layout(x => x.ServiceFacilityLocation, 21);
            Layout(x => x.LineAdjudicationInformation, 22);
        }
    }
}