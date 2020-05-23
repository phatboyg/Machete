﻿namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2310E_837IMap :
        X12LayoutMap<L2310E_837I, X12Entity>
    {
        public L2310E_837IMap()
        {
            Id = "2310E";
            Name = "Service Facility Location Name";
            
            Segment(x => x.FacilityLocation, 0,
                x => x.Condition = parser => parser.Where(p => p.EntityIdentifierCode.IsEqualTo("77")));
            Segment(x => x.Address, 1, x => x.IsRequired());
            Segment(x => x.GeographicInformation, 2, x => x.IsRequired());
            Segment(x => x.SecondaryIdentification, 3,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("0B")
                    || p.ReferenceIdentificationQualifier.IsEqualTo("1G")
                    || p.ReferenceIdentificationQualifier.IsEqualTo("G2")
                    || p.ReferenceIdentificationQualifier.IsEqualTo("LU")));
        }
    }
}