namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class CDDMap :
        X12SegmentMap<CDD, X12Entity>
    {
        public CDDMap()
        {
            Id = "CDD";
            Name = "Credit/Debit Adjustment Detail";
            
            Value(x => x.AdjustmentReasonCode, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.CreditOrDebitFlagCode, 2, x => x.FixedLength(1).IsRequired());
            Value(x => x.AssignedIdentification, 3, x => x.MinLength(1).MaxLength(20));
            Value(x => x.Amount, 4, x => x.MinLength(1).MaxLength(15));
            Value(x => x.YesNoConditionOrResponseCode, 5, x => x.FixedLength(1));
            Value(x => x.PriceBracketIdentifier, 6, x => x.MinLength(1).MaxLength(3));
            Value(x => x.CreditOrDebitQuantity, 7, x => x.MinLength(1).MaxLength(10));
            Value(x => x.UnitOrBasisOfMeasurement, 8, x => x.FixedLength(2));
            Value(x => x.UnitPriceDifference, 9, x => x.MinLength(1).MaxLength(15));
            Value(x => x.PriceIdentifierCode1, 10, x => x.FixedLength(3));
            Value(x => x.UnitPrice1, 11, x => x.MinLength(1).MaxLength(17));
            Value(x => x.PriceIdentifierCode2, 12, x => x.FixedLength(3));
            Value(x => x.UnitPrice2, 13, x => x.MinLength(1).MaxLength(17));
        }
    }
}