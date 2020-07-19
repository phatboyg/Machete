namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2010CA_837IMap :
        X12LayoutMap<L2010CA_837I, X12Entity>
    {
        public L2010CA_837IMap()
        {
            Id = "2010CA";
            Name = "Patient Name";
            
            Segment(x => x.Name, 0,
                x => x.Condition = parser => parser.Where(p => p.EntityIdentifierCode.IsEqualTo("QC")));
            Segment(x => x.Address, 1);
            Segment(x => x.GeographicInformation, 2);
            Segment(x => x.DemographicInformation, 3);
            Segment(x => x.PropertyAndCasualtyClaimNumber, 4,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("Y4")));
            Segment(x => x.PropertyAndCasualtyPatientIdentifier, 5,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("1W") ||
                                                               p.ReferenceIdentificationQualifier.IsEqualTo("SY")));
        }
    }
}