namespace Machete.X12Schema.V5010
{
    using X12;
    
    
    public interface EQ :
        X12Segment
    {
        Value<string> ServiceTypeCode { get; }

        Value<string> CompositeMedicalProcedureIdentifier { get; }

        Value<string> CoverageLevelCode { get; }

        Value<string> InsuranceTypeCode { get; }
    }
}