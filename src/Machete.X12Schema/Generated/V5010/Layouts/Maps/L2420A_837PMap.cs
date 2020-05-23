﻿namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2420A_837PMap :
        X12LayoutMap<L2420A_837P, X12Entity>
    {
        public L2420A_837PMap()
        {
            Id = "2420A";
            Name = "Rendering Provider Name";
            
            Segment(x => x.Provider, 0,
                x => x.Condition = parser => parser.Where(p => p.EntityIdentifierCode.IsEqualTo("82")));
            Segment(x => x.SpecialtyInformation, 1);
            Segment(x => x.SecondaryIdentification, 2);
        }
    }
}