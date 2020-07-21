namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2330B_837IMap :
        X12LayoutMap<Loop2330B_837I, X12Entity>
    {
        public Loop2330B_837IMap()
        {
            Id = "Loop_2330B_837I";
            Name = "Other Payer Name";
            
            Segment(x => x.Payer, 0,
                x => x.Condition = parser => parser.Where(p => p.EntityIdentifierCode.IsEqualTo("PR")));
            Segment(x => x.Address, 1);
            Segment(x => x.GeographicInformation, 2);
            Segment(x => x.ClaimCheckOrRemittanceDate, 3);
            Segment(x => x.SecondaryIdentification, 4,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("2U")
                    || p.ReferenceIdentificationQualifier.IsEqualTo("EI")
                    || p.ReferenceIdentificationQualifier.IsEqualTo("FY")
                    || p.ReferenceIdentificationQualifier.IsEqualTo("NF")));
            Segment(x => x.PriorAuthorizationNumber, 5,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("G1")));
            Segment(x => x.ReferralNumber, 6,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("9F")));
            Segment(x => x.ClaimAdjustmentIndicator, 7,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("T4")));
            Segment(x => x.ClaimControlNumber, 8,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("F8")));
        }
    }
}