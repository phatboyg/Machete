namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;

    
    public class SV5Map :
        X12SegmentMap<SV5, X12Entity>
    {
        public SV5Map()
        {
            Id = "SV5";
            Name = "Durable Medical Equipment Service";
            
            Entity(x => x.ProcedureIdentifier, 1, x => x.IsRequired());
            Value(x => x.UnitForMeasurementCode, 2, x => x.FixedLength(2).IsRequired());
            Value(x => x.LengthOfMedicalNecessity, 3, x => x.MinLength(1).MaxLength(15).IsRequired());
            Value(x => x.DMERentalPrice, 4, x => x.MinLength(1).MaxLength(18));
            Value(x => x.DMEPurchasePrice, 5, x => x.MinLength(1).MaxLength(18));
            Value(x => x.RentalUnitPriceIndicator, 6, x => x.FixedLength(1).IsRequired());
        }
    }
}