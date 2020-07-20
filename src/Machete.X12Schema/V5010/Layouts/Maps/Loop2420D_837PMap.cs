namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2420D_837PMap :
        X12LayoutMap<Loop2420D_837P, X12Entity>
    {
        public Loop2420D_837PMap()
        {
            Id = "2420D";
            Name = "Supervising Provider Name";
            
            Segment(x => x.SupervisingProvider, 0,
                x => x.Condition = parser => parser.Where(p => p.EntityIdentifierCode.IsEqualTo("DQ")));
            Segment(x => x.SecondaryIdentification, 1);
        }
    }
}