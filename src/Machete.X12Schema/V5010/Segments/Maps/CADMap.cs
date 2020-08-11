namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class CADMap :
        X12SegmentMap<CAD, X12Entity>
    {
        public CADMap()
        {
            Id = "CAD";
            Name = "Carrier Details";
            
            Value(x => x.TransportationMethodOrTypeCode, 1, x => x.MinLength(1).MaxLength(2).IsRequired());
            Value(x => x.EquipmentInitial, 2, x => x.MinLength(1).MaxLength(4));
            Value(x => x.EquipmentNumber, 3, x => x.MinLength(1).MaxLength(15));
            Value(x => x.StandardCarrierAlphaCode, 4, x => x.MinLength(2).MaxLength(4));
            Value(x => x.Routing, 5, x => x.MinLength(1).MaxLength(35));
            Value(x => x.ShipmentOrOrderStatusCode, 6, x => x.FixedLength(2));
            Value(x => x.ReferenceIdentificationQualifier, 7, x => x.MinLength(2).MaxLength(3));
            Value(x => x.ReferenceIdentification, 8, x => x.MinLength(2).MaxLength(50));
            Value(x => x.ServiceLevelCode, 9, x => x.FixedLength(2));
        }
    }
}