namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;

    
    public class CR3Map :
        X12SegmentMap<CR3, X12Entity>
    {
        public CR3Map()
        {
            Id = "CR3";
            Name = "Durable Medical Equipment Certification";
            
            Value(x => x.CertificationTypeCode, 1, x => x.FixedLength(1).IsRequired());
            Value(x => x.UnitMeasurementCode, 2, x => x.FixedLength(2).IsRequired());
            Value(x => x.DurableMedicalEquipmentDuration, 3, x => x.MinLength(1).MaxLength(15).IsRequired());
        }
    }
}