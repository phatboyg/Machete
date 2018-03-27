namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;

    
    public class CTPMap :
        X12SegmentMap<CTP, X12Entity>
    {
        public CTPMap()
        {
            Id = "CTP";
            Name = "Pricing Information";
            
            Value(x => x.DrugUnitPrice, 3, x => x.MinLength(1).MaxLength(17).IsRequired());
            Value(x => x.Quantity, 4, x => x.MinLength(1).MaxLength(15).IsRequired());
            Value(x => x.UnitForMeasurementCode, 5, x => x.FixedLength(1).IsRequired());
        }
    }
}