namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2100D_270Map :
        X12LayoutMap<L2100D_270, X12Entity>
    {
        public L2100D_270Map()
        {
            Id = "2100D";
            Name = "Dependent Name";
            
            Segment(x => x.Dependent, 0, x => x.IsRequired());
            Segment(x => x.AdditionalIdentification, 1);
            Segment(x => x.Address, 2);
            Segment(x => x.GeographicInformation, 3);
            Segment(x => x.ProviderInformation, 4);
            Segment(x => x.DemographicInformation, 5);
            Segment(x => x.DependentRelationship, 6);
            Segment(x => x.HealthcareDiagnosisCode, 7);
            Segment(x => x.DependentDate, 8);
            Layout(x => x.EligibilityOrBenefitInquiry, 9);
        }
    }
}