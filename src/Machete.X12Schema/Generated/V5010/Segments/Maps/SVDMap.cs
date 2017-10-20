namespace Machete.X12Schema.V5010.Segments.Maps
{
    using Machete.X12;
    using Machete.X12.Configuration;

    public class SVDMap : X12SegmentMap<SVD, X12Entity>
    {
        public SVDMap()
        {
            Id = "SVD";
            Name = "Service Line Adjudication";
            Value(x => x.PayerIdentifier, 1, x => x.MinLength(2).MaxLength(80).IsRequired());
            Value(x => x.ServiceLinePaidAmount, 2, x => x.MinLength(1).MaxLength(18).IsRequired());
            Value(x => x.CompositeMedicalProcedureIdentifier, 3, x => x.MinLength(1).IsRequired());
            Value(x => x.ServiceLineRevenueCode, 4, x => x.MinLength(1).MaxLength(48).IsRequired());
            Value(x => x.AdjustmentQuantity, 5, x => x.MinLength(1).MaxLength(15).IsRequired());
            Value(x => x.LineNumber, 6, x => x.MinLength(1).MaxLength(6));
        }
    }
}