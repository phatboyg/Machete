namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2330A_837PMap :
        X12LayoutMap<Loop2330A_837P, X12Entity>
    {
        public Loop2330A_837PMap()
        {
            Id = "Loop_2330A_837P";
            Name = "Other Subscriber Name";
            
            Segment(x => x.OtherSubscriber, 0,
                x => x.Condition = parser => parser.Where(p => p.EntityIdentifierCode.IsEqualTo("IL")));
            Segment(x => x.Address, 1);
            Segment(x => x.GeographicInformation, 2);
            Segment(x => x.SecondaryIdentification, 3,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("SY")));
        }
    }
}