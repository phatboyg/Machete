namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2010CA_837DMap :
        X12LayoutMap<L2010CA_837D, X12Entity>
    {
        public L2010CA_837DMap()
        {
            Id = "2010CA";
            Name = "Patient Name";
            
            Segment(x => x.Patient, 0, x => x.IsRequired());
            Segment(x => x.Address, 1, x => x.IsRequired());
            Segment(x => x.GeographicInformation, 2, x => x.IsRequired());
            Segment(x => x.DemographicInformation, 3, x => x.IsRequired());
            Segment(x => x.PropertyAndCasualtyClaimNumber, 4);
            Segment(x => x.PropertyAndCasualtyPatientIdentifier, 5);
        }
    }
}