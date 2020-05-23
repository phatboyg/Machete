﻿namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2310F_837PMap :
        X12LayoutMap<L2310F_837P, X12Entity>
    {
        public L2310F_837PMap()
        {
            Id = "2310F";
            Name = "Ambulance Drop-Off Location";
            
            Segment(x => x.DropOffLocation, 0,
                x => x.Condition = parser => parser.Where(p => p.EntityIdentifierCode.IsEqualTo("45")));
            Segment(x => x.Address, 1);
            Segment(x => x.GeographicInformation, 2);
        }
    }
}