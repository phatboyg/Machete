namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2310D_837PMap :
        X12LayoutMap<L2310D_837P, X12Entity>
    {
        public L2310D_837PMap()
        {
            Id = "2310D";
            Name = "Supervising Provider Name";
            
            Segment(x => x.Name, 0,
                x => x.Condition = parser => parser.Where(p => p.EntityIdentifierCode.IsEqualTo("DQ")));
            Segment(x => x.SecondaryIdentification, 1);
        }
    }
}