namespace Machete.X12Schema.V5010
{
    using Machete.X12;
    public interface SVD : X12Segment
    {
        Value<string> PayerIdentifier { get; }

        Value<decimal> ServiceLinePaidAmount { get; }

        Value<string> CompositeMedicalProcedureIdentifier { get; }

        Value<string> ServiceLineRevenueCode { get; }

        Value<decimal> AdjustmentQuantity { get; }

        Value<int> LineNumber { get; }
    }
}