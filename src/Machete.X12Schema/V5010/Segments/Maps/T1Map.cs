namespace Machete.X12Schema.V5010
{
    using Segments;
    using X12;
    using X12.Configuration;


    public class T1Map :
        X12SegmentMap<IT1, X12Entity>
    {
        public T1Map()
        {
            Id = "IT1";
            Name = "Baseline Item Data (Invoice)";
            
            Value(x => x.AssignedIdentification, 1, x => x.MinLength(1).MaxLength(20));
            Value(x => x.QuantityInvoiced, 2, x => x.MinLength(1).MaxLength(15));
            Value(x => x.UnitOrBasisForMeasurementCode, 3, x => x.FixedLength(2));
            Value(x => x.UnitPrice, 4, x => x.MinLength(1).MaxLength(17));
            Value(x => x.BasisOfUnitPriceCode, 5, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceIdQualifier1, 6, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId1, 7, x => x.MinLength(1).MaxLength(48));
            Value(x => x.ProductOrServiceIdQualifier2, 8, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId2, 9, x => x.MinLength(1).MaxLength(48));
            Value(x => x.ProductOrServiceIdQualifier3, 10, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId3, 11, x => x.MinLength(1).MaxLength(48));
            Value(x => x.ProductOrServiceIdQualifier4, 12, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId4, 13, x => x.MinLength(1).MaxLength(48));
            Value(x => x.ProductOrServiceIdQualifier5, 14, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId5, 15, x => x.MinLength(1).MaxLength(48));
            Value(x => x.ProductOrServiceIdQualifier6, 16, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId6, 17, x => x.MinLength(1).MaxLength(48));
            Value(x => x.ProductOrServiceIdQualifier7, 18, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId7, 19, x => x.MinLength(1).MaxLength(48));
            Value(x => x.ProductOrServiceIdQualifier8, 20, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId8, 21, x => x.MinLength(1).MaxLength(48));
            Value(x => x.ProductOrServiceIdQualifier9, 22, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId9, 23, x => x.MinLength(1).MaxLength(48));
            Value(x => x.ProductOrServiceIdQualifier10, 24, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId10, 25, x => x.MinLength(1).MaxLength(48));
        }
    }
}