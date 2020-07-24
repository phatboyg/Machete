namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class PYDMap :
        X12SegmentMap<PYD, X12Entity>
    {
        public PYDMap()
        {
            Id = "PYD";
            Name = "Payroll Deduction";
            
            Value(x => x.MonetaryAmount, 1, x => x.MinLength(1).MaxLength(18).IsRequired());
            Value(x => x.FrequencyCode, 2, x => x.FixedLength(1));
            Value(x => x.TaxTreatmentCode, 3, x => x.FixedLength(1));
            Value(x => x.DeductionTypeCode, 4, x => x.MinLength(1).MaxLength(4));
            Value(x => x.Description, 5, x => x.MinLength(1).MaxLength(80));
        }
    }
}