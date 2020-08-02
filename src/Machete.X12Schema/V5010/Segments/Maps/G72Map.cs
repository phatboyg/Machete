namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class G72Map :
        X12SegmentMap<G72, X12Entity>
    {
        public G72Map()
        {
            Id = "G72";
            Name = "Allowance or Charge";
            
            Value(x => x.AllowanceOrChargeCode, 1, x => x.MinLength(1).MaxLength(3).IsRequired());
            Value(x => x.AllowanceOrChargeMethodOfHandlingCode, 2, x => x.FixedLength(2).IsRequired());
            Value(x => x.AllowanceOrChargeNumber, 3, x => x.MinLength(1).MaxLength(16));
            Value(x => x.ExceptionNumber, 4, x => x.MinLength(1).MaxLength(16));
            Value(x => x.AllowanceOrChargeRate, 5, x => x.MinLength(1).MaxLength(15));
            Value(x => x.AllowanceOrChargeQuantity, 6, x => x.MinLength(1).MaxLength(10));
            Value(x => x.UnitOrBasisOfMeasurementCode, 7, x => x.FixedLength(2));
            Value(x => x.AllowanceOrChargeTotalAmount, 8, x => x.MinLength(1).MaxLength(15));
            Value(x => x.PercentDecimalFormat, 9, x => x.MinLength(1).MaxLength(6));
            Value(x => x.DollarBasisForPercent, 10, x => x.MinLength(1).MaxLength(9));
            Value(x => x.OptionNumber, 11, x => x.MinLength(1).MaxLength(20));
        }
    }
}