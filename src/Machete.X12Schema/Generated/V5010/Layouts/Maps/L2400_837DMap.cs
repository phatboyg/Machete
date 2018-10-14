namespace Machete.X12Schema.V5010.Maps
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
            Segment(x => x.ServiceDate, 3,
                x => x.Condition = parser => parser.Where(p => p.DateTimeQualifier.IsEqualTo("472")));
            Segment(x => x.PriorPlacementDate, 4,
                x => x.Condition = parser => parser.Where(p => p.DateTimeQualifier.IsEqualTo("139") || p.DateTimeQualifier.IsEqualTo("441")));
            Segment(x => x.AppliancePlacementDate, 5,
                x => x.Condition = parser => parser.Where(p => p.DateTimeQualifier.IsEqualTo("452")));
            Segment(x => x.ReplacementDate, 6,
                x => x.Condition = parser => parser.Where(p => p.DateTimeQualifier.IsEqualTo("446")));
            Segment(x => x.TreatmentStartDate, 7,
                x => x.Condition = parser => parser.Where(p => p.DateTimeQualifier.IsEqualTo("196")));
            Segment(x => x.TreatmentCompletionDate, 8,
                x => x.Condition = parser => parser.Where(p => p.DateTimeQualifier.IsEqualTo("198")));
            Segment(x => x.ContractInformation, 9);
            Segment(x => x.ServicePredeterminationIndentification, 10,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("G3")));
            Segment(x => x.PriorAuthorization, 11,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("G1")));
            Segment(x => x.LineItemControlNumber, 12,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("6R")));
            Segment(x => x.RepricedClaimNumber, 13,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("9A")));
            Segment(x => x.AdjustedRepricedClaimNumber, 14,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("9C")));
            Segment(x => x.ReferralNumber, 15,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("9F")));
            Segment(x => x.SalesTaxAmount, 16);
            Segment(x => x.FileInformation, 17);
            Segment(x => x.LinePricingOrRepricingInfo, 18);
            Layout(x => x.RenderingProvider, 19);
            Layout(x => x.AssistantSurgeon, 20);
            Layout(x => x.SupervisingProvider, 21);
            Layout(x => x.ServiceFacilityLocation, 22);
            Layout(x => x.LineAdjudicationInformation, 23);
        }
    }
}