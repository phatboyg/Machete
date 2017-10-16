namespace Machete.X12Schema.V5010
{
    using Machete.X12;
    public interface SV1 : X12Segment
    {
        Value<string> ProcedureIdentifier { get; }

        Value<decimal> ChargeAmount { get; }

        Value<string> UnitsQualifier { get; }

        // TODO qualifier 3
        Value<decimal> Units { get; }

        Value<string> PlaceOfService { get; }

        Value<string> CompositeDiagCodePointer { get; }

        Value<string> Emergency { get; }

        Value<string> Epsdt { get; }

        Value<string> FamilyPlanning { get; }

        Value<string> CoPayWaiver { get; }
    }
}