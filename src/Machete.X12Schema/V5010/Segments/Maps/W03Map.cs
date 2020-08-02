namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class W03Map :
        X12SegmentMap<W03, X12Entity>
    {
        public W03Map()
        {
            Id = "W03";
            Name = "Total Shipment Information (Warehouse)";
            
            Value(x => x.NumberOfUnitsShipped, 1, x => x.MinLength(1).MaxLength(10).IsRequired());
            Value(x => x.Weight, 2, x => x.MinLength(1).MaxLength(10));
            Value(x => x.UnitOrBasisOfMeasurementCode1, 3, x => x.FixedLength(2));
            Value(x => x.Volume, 4, x => x.MinLength(1).MaxLength(8));
            Value(x => x.UnitOrBasisOfMeasurementCode2, 5, x => x.FixedLength(2));
            Value(x => x.LadingQuantity, 6, x => x.MinLength(1).MaxLength(7));
            Value(x => x.UnitOrBasisOfMeasurementCode3, 7, x => x.FixedLength(2));
        }
    }
}