namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class AINMap :
        X12SegmentMap<AIN, X12Entity>
    {
        public AINMap()
        {
            Id = "AIN";
            Name = "Income";
            
            Value(x => x.TypeOfIncomeCode, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.FrequencyCode, 2, x => x.FixedLength(1).IsRequired());
            Value(x => x.MonetaryAmount, 3, x => x.MinLength(1).MaxLength(18).IsRequired());
            Value(x => x.Quantity1, 4, x => x.MinLength(1).MaxLength(15));
            Value(x => x.YesNoConditionOrResponseCode, 5, x => x.FixedLength(1));
            Value(x => x.ReferenceIdentification, 6, x => x.MinLength(1).MaxLength(30));
            Value(x => x.AmountQualifierCode, 7, x => x.MinLength(1).MaxLength(3));
            Value(x => x.TaxTreatmentCode, 8, x => x.FixedLength(1));
            Value(x => x.EarningsRateOfPay, 9, x => x.MinLength(1).MaxLength(15));
            Value(x => x.UnitOrBasisOfMeasurement, 10, x => x.FixedLength(2));
            Value(x => x.Quantity2, 11, x => x.MinLength(1).MaxLength(15));
            Value(x => x.IndustryCode, 12, x => x.MinLength(1).MaxLength(30));
        }
    }
}