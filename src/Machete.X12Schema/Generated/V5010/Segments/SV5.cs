namespace Machete.X12Schema.V5010
{
    using Machete.X12;
    public interface SV5 : X12Segment
    {
        Value<string> ProcedureIdentifier { get; }

        Value<string> LengthOfMedicalNecessityQualifier { get; }

        // TODO qualifier 2
        Value<decimal> LengthOfMedicalNecessity { get; }

        Value<decimal> DmeRentalPrice { get; }

        Value<decimal> DmePurchasePrice { get; }

        Value<string> RentalUnitPriceIndicator { get; }
    }
}