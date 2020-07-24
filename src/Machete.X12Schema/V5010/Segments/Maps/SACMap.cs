namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class SACMap :
        X12SegmentMap<SAC, X12Entity>
    {
        public SACMap()
        {
            Id = "SAC";
            Name = "Service, Promotion, Allowance, or Charge Information";
            
            Value(x => x.AllowanceOrChargeIndicator, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.ServicePromotionAllowanceOrChargeCode, 2, x => x.FixedLength(4));
            Value(x => x.AgencyQualifierCode, 3, x => x.FixedLength(2));
            Value(x => x.AgencyServicePromotionAllowanceOrChargeCode, 4, x => x.MinLength(1).MaxLength(10));
            Value(x => x.Amount, 5, x => x.MinLength(1).MaxLength(15));
            Value(x => x.AllowanceOrChargePercentQualifier, 6, x => x.FixedLength(2));
            Value(x => x.PercentDecimalFormat, 7, x => x.MinLength(1).MaxLength(6));
            Value(x => x.Rate, 8, x => x.MinLength(1).MaxLength(9));
            Value(x => x.UnitOrBasisForMeasurementCode, 9, x => x.FixedLength(2));
            Value(x => x.Quantity1, 10, x => x.MinLength(1).MaxLength(15));
            Value(x => x.Quantity2, 11, x => x.MinLength(1).MaxLength(15));
            Value(x => x.AllowanceOrChargeMethodOfHandlingCode, 12, x => x.FixedLength(2));
            Value(x => x.ReferenceIdentification, 12, x => x.MinLength(1).MaxLength(50));
            Value(x => x.OptionNumber, 13, x => x.MinLength(1).MaxLength(20));
            Value(x => x.Description, 14, x => x.MinLength(1).MaxLength(80));
            Value(x => x.LanguageCode, 15, x => x.MinLength(2).MaxLength(3));
        }
    }
}