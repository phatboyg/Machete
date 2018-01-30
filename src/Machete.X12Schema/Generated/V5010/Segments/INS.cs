namespace Machete.X12Schema.V5010
{
    using X12;
    
    
    public interface INS :
        X12Segment
    {
        Value<string> ConditionOrResponseCode1 { get; }

        Value<string> IndividualRelationshipCode { get; }

        Value<string> MaintenanceTypeCode { get; }

        Value<string> MaintenanceReasonCode { get; }

        Value<string> StudentStatusCode { get; }

        Value<string> ConditionOrResponseCode2 { get; }

        Value<int> Number { get; }
    }
}