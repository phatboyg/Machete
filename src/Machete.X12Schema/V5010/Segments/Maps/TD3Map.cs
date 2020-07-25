namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class TD3Map :
        X12SegmentMap<TD3, X12Entity>
    {
        public TD3Map()
        {
            Id = "TD3";
            Name = "Carrier Details (Equipment)";
            
            Value(x => x.EquipmentDescriptionCode, 1, x => x.FixedLength(2));
            Value(x => x.EquipmentInitial, 2, x => x.MinLength(1).MaxLength(4));
            Value(x => x.EquipmentNumber, 3, x => x.MinLength(1).MaxLength(10));
            Value(x => x.WeightQualifier, 4, x => x.MinLength(1).MaxLength(2));
            Value(x => x.Weight, 5, x => x.MinLength(1).MaxLength(10));
            Value(x => x.UnitOrBasisForMeasurementCode, 6, x => x.FixedLength(2));
            Value(x => x.OwnershipCode, 7, x => x.FixedLength(1));
            Value(x => x.SealStatusCode, 8, x => x.FixedLength(2));
            Value(x => x.SealNumber, 9, x => x.MinLength(2).MaxLength(15));
            Value(x => x.EquipmentType, 10, x => x.FixedLength(4));
        }
    }
}