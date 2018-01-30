namespace Machete.X12Schema.V5010
{
    using X12;
    
    
    public interface CR5 :
        X12Segment
    {
        Value<string> CertificationTypeCode { get; }

        Value<decimal> TreatmentPeriodCount { get; }

        Value<decimal> ArterialBloodGasQuantity { get; }

        Value<decimal> OxygenSaturationQuantity { get; }

        Value<string> OxygenTestConditionCode { get; }

        Value<string> OxygenTestFindingsCode { get; }

        Value<string> OxygenTestFindingsCode2 { get; }

        Value<string> OxygenTestFindingsCode3 { get; }
    }
}