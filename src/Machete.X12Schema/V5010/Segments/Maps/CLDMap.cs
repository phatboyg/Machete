namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class CLDMap :
        X12SegmentMap<CLD, X12Entity>
    {
        public CLDMap()
        {
            Id = "CLD";
            Name = "Load Detail";
            
            Value(x => x.NumberOfLoads, 1, x => x.MinLength(1).MaxLength(5).IsRequired());
            Value(x => x.NumberOfUnitsShipped, 2, x => x.MinLength(1).MaxLength(10).IsRequired());
            Value(x => x.PackagingCode, 3, x => x.MinLength(3).MaxLength(5));
            Value(x => x.Size, 4, x => x.MinLength(1).MaxLength(8));
            Value(x => x.UnitOrBasisForMeasurementCode, 5, x => x.FixedLength(2));
        }
    }
}