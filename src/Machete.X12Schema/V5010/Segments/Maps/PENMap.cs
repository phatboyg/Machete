namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class PENMap :
        X12SegmentMap<PEN, X12Entity>
    {
        public PENMap()
        {
            Id = "PEN";
            Name = "Pension Information";
            
            Value(x => x.TransactionTypeCode, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.MonetaryAmount, 2, x => x.MinLength(1).MaxLength(18));
            Value(x => x.ContributionCode, 3, x => x.FixedLength(2));
            Value(x => x.Percent, 4, x => x.MinLength(1).MaxLength(10));
            Value(x => x.SpecialProcessingType, 5, x => x.MinLength(1).MaxLength(6));
            Value(x => x.ReferenceIdentification, 6, x => x.MinLength(1).MaxLength(30));
            Value(x => x.Number, 7, x => x.MinLength(1).MaxLength(9));
            Value(x => x.LoanTypeCode, 8, x => x.MinLength(1).MaxLength(2));
            Value(x => x.MaintenanceTypeCode, 9, x => x.FixedLength(3));
        }
    }
}