namespace Machete.X12Schema.V5010.Segments.Maps
{
    using X12;
    using X12.Configuration;


    public class LPMap :
        X12SegmentMap<LP, X12Entity>
    {
        public LPMap()
        {
            Id = "LP";
            Name = "Load Planning";
            
            Value(x => x.EquipmentType, 1, x => x.FixedLength(4));
            Value(x => x.ShipmentIdentificationNumber1, 2, x => x.MinLength(1).MaxLength(30));
            Value(x => x.ShipmentIdentificationNumber2, 3, x => x.MinLength(1).MaxLength(30));
            Value(x => x.VentInstructionCode, 4, x => x.MinLength(1).MaxLength(7));
            Value(x => x.EquipmentNumber, 5, x => x.MinLength(1).MaxLength(15));
            Value(x => x.Number1, 6, x => x.MinLength(1).MaxLength(9));
            Value(x => x.Number2, 7, x => x.MinLength(1).MaxLength(9));
        }
    }
}