namespace Machete.X12Schema.V5010
{
    using Machete.X12;
    public interface CR3 : X12Segment
    {
        Value<string> CertificationTypeCode { get; }

        Value<string> UnitMeasurement { get; }

        Value<decimal> DurableMedicalEquipmentDuration { get; }
    }
}