namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2420C_837DMap :
        X12LayoutMap<L2420C_837D, X12Entity>
    {
        public L2420C_837DMap()
        {
            Id = "2420C";
            Name = "Supervising Provider Name";
            
            Segment(x => x.SupervisingProvider, 0);
            Segment(x => x.SecondaryIdentification, 1,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("0B") ||
                                                               p.ReferenceIdentificationQualifier.IsEqualTo("1G") ||
                                                               p.ReferenceIdentificationQualifier.IsEqualTo("G2") ||
                                                               p.ReferenceIdentificationQualifier.IsEqualTo("LU")));
        }
    }
}