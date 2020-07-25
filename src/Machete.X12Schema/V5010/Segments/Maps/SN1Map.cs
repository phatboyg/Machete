namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class SN1Map :
        X12SegmentMap<SN1, X12Entity>
    {
        public SN1Map()
        {
            Id = "SN1";
            Name = "Item Detail (Shipment)";
            
            Value(x => x.AssignedIdentification, 1, x => x.MinLength(1).MaxLength(20));
            Value(x => x.NumberOfUnitsShipped, 2, x => x.MinLength(1).MaxLength(10));
            Value(x => x.UnitOrBasisForMeasurementCode1, 3, x => x.FixedLength(2));
            Value(x => x.QuantityShippedToDate, 4, x => x.MinLength(1).MaxLength(15));
            Value(x => x.QuantityOrdered, 5, x => x.MinLength(1).MaxLength(15));
            Value(x => x.UnitOrBasisForMeasurementCode2, 6, x => x.FixedLength(2));
            Value(x => x.ReturnableContainerLoadMakeUpCode, 7, x => x.MinLength(1).MaxLength(2));
            Value(x => x.LineItemStatusCode, 8, x => x.FixedLength(2));
        }
    }
}