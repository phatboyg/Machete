namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2420H_837PMap :
        X12LayoutMap<L2420H_837P, X12Entity>
    {
        public L2420H_837PMap()
        {
            Id = "2420H";
            Name = "Ambulance Drop Off Location";
                                    
            Segment(x => x.DropOffLocation, 0,
                x => x.Condition = parser => parser.Where(p => p.EntityIdentifierCode.IsEqualTo("45")));
            Segment(x => x.Address, 1, x => x.IsRequired());
            Segment(x => x.GeographicInfo, 2, x => x.IsRequired());
        }
    }
}