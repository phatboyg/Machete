﻿namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2310B_837PMap :
        X12LayoutMap<L2310B_837P, X12Entity>
    {
        public L2310B_837PMap()
        {
            Id = "2310B";
            Name = "Rendering Provider Name";
            
            Segment(x => x.RenderingProvider, 0,
                x => x.Condition = parser => parser.Where(p => p.EntityIdentifierCode.IsEqualTo("82")));
            Segment(x => x.SpecialtyInformation, 1);
            Segment(x => x.SecondaryIdentification, 2);
        }
    }
}