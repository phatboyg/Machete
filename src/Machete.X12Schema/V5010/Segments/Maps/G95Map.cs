namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class G95Map :
        X12SegmentMap<G95, X12Entity>
    {
        public G95Map()
        {
            Id = "G95";
            Name = "Performance Requirements";
            
            Value(x => x.PromotionConditionQualifier, 1, x => x.FixedLength(2));
            Value(x => x.PromotionConditionCode, 2, x => x.FixedLength(2).IsRequired());
            Value(x => x.AssignedNumber, 3, x => x.MinLength(1).MaxLength(6));
            Value(x => x.Quantity, 4, x => x.MinLength(1).MaxLength(15));
            Value(x => x.UnitOrBasisForMeasurement, 5, x => x.FixedLength(2));
            Value(x => x.Description, 6, x => x.MinLength(1).MaxLength(80));
            Value(x => x.Number, 7, x => x.MinLength(1).MaxLength(9));
        }
    }
}