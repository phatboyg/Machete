﻿namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2420D_837DMap :
        X12LayoutMap<L2420D_837D, X12Entity>
    {
        public L2420D_837DMap()
        {
            Id = "2420D";
            Name = "Service Facility Location Name";
            
            Segment(x => x.FacilityLocation, 0);
            Segment(x => x.Address, 1, x => x.IsRequired());
            Segment(x => x.GeographicInformation, 2, x => x.IsRequired());
            Segment(x => x.SecondaryIdentification, 3,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("1G") ||
                                                               p.ReferenceIdentificationQualifier.IsEqualTo("G2") ||
                                                               p.ReferenceIdentificationQualifier.IsEqualTo("LU")));
        }
    }
}