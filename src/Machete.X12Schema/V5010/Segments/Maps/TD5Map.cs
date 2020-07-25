namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class TD5Map :
        X12SegmentMap<TD5, X12Entity>
    {
        public TD5Map()
        {
            Id = "TD5";
            Name = "Carrier Details (Routing Sequence/Transit Time)";
            
            Value(x => x.RoutingSequenceCode, 1, x => x.MinLength(1).MaxLength(2));
            Value(x => x.IdentificationCodeQualifier, 2, x => x.MinLength(1).MaxLength(2));
            Value(x => x.IdentificationCode, 3, x => x.MinLength(2).MaxLength(80));
            Value(x => x.TransportationMethodOrTypeCode, 4, x => x.MinLength(2).MaxLength(2));
            Value(x => x.Routing, 5, x => x.MinLength(1).MaxLength(35));
            Value(x => x.ShipmentOrOrderStatusCode, 6, x => x.FixedLength(2));
            Value(x => x.LocationQualifier, 7, x => x.MinLength(1).MaxLength(2));
            Value(x => x.LocationIdentifier, 8, x => x.MinLength(1).MaxLength(30));
            Value(x => x.TransitDirectionCode, 9, x => x.FixedLength(2));
            Value(x => x.TransitTimeDirectionQualifier, 10, x => x.FixedLength(2));
            Value(x => x.TransitTime, 11, x => x.MinLength(1).MaxLength(4));
            Value(x => x.ServiceLevelCode1, 12, x => x.FixedLength(2));
            Value(x => x.ServiceLevelCode2, 13, x => x.FixedLength(2));
            Value(x => x.ServiceLevelCode3, 14, x => x.FixedLength(2));
            Value(x => x.CountryCode, 15, x => x.MinLength(2).MaxLength(3));
        }
    }
}