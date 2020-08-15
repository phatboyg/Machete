namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class SLIMap :
        X12SegmentMap<SLI, X12Entity>
    {
        public SLIMap()
        {
            Id = "SLI";
            Name = "Specific Loan Information";
            
            Value( x => x.LoanTypeCode, 1, x=> x.MinLength(1).MaxLength(2).IsRequired());
            Value(x => x.Amount1, 2, x=> x.MinLength(1).MaxLength(18).IsRequired());
            Value(x => x.Amount2, 3, x=> x.MinLength(1).MaxLength(18).IsRequired());
            Value(x => x.InterestRate, 4, x=> x.MinLength(1).MaxLength(6).IsRequired());
            Value(x => x.LoanRateTypeCode, 5, x=> x.FixedLength(1).IsRequired());
            Value(x => x.InterestRate, 6, x=> x.MinLength(2).MaxLength(3).IsRequired());
            Value(x => x.DateTimePeriod1, 7, x=> x.MinLength(1).MaxLength(35).IsRequired());
            Value(x => x.ReferenceIdentification, 8, x=> x.MinLength(1).MaxLength(50));
            Value(x => x.YesNoConditionOrResponseCode1, 9, x=> x.FixedLength(1));
            Value(x => x.DateTimePeriodFormatQualifier1, 10, x=> x.MinLength(2).MaxLength(3));
            Value(x => x.DateTimePeriod1, 11, x=> x.MinLength(1).MaxLength(35));
            Value(x => x.DateTimePeriodFormatQualifier2, 12, x=> x.MinLength(2).MaxLength(3));
            Value(x => x.DateTimePeriod2, 13, x=> x.MinLength(1).MaxLength(35));
            Value(x => x.Amount3, 14, x=> x.MinLength(1).MaxLength(18));
            Value(x => x.Quantity1, 15, x=> x.MinLength(1).MaxLength(15));
            Value(x => x.Quantity2, 16, x=> x.MinLength(1).MaxLength(15));
            Value(x => x.Quantity3, 17, x=> x.MinLength(1).MaxLength(15));
            Value(x => x.YesNoConditionOrResponseCode2, 18, x=> x.FixedLength(1));
            Value(x => x.YesNoConditionOrResponseCode3, 19, x=> x.FixedLength(1));
            Value(x => x.DateTimePeriodFormatQualifier3, 20, x=> x.MinLength(2).MaxLength(3));
            Value(x => x.DateTimePeriod3, 21, x=> x.MinLength(1).MaxLength(35));
            Value(x => x.PaymentMethodTypeCode, 22, x=> x.MinLength(1).MaxLength(2));
            
        }
    }
}