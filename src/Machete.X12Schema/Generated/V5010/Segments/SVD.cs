namespace Machete.X12Schema.V5010
{
    using X12;
    
    
    public interface SVD :
        X12Segment
    {
        Value<string> IdentificationCode { get; }

        Value<decimal> ServiceLinePaidAmount { get; }

        Value<ProcedureIdentifier> ProcedureIdentifier { get; }

        Value<string> ProductIdentifier { get; }

        Value<decimal> Quantity { get; }

        Value<int> AssignedNumber { get; }
    }
}