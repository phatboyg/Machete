namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2330A_837IMap :
        X12LayoutMap<Loop2330A_837I, X12Entity>
    {
        public Loop2330A_837IMap()
        {
            Id = "Loop_2330A_837I";
            Name = "Other Subscriber Name";
            
            Segment(x => x.Subscriber, 0,
                x => x.Condition = parser => parser.Where(p => p.EntityIdentifierCode.IsEqualTo("IL")));
            Segment(x => x.Address, 1);
            Segment(x => x.GeographicInformation, 2);
            Segment(x => x.SecondaryIdentification, 3,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("SY")));
        }
    }
}