namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class POCMap :
        X12SegmentMap<POC, X12Entity>
    {
        public POCMap()
        {
            Id = "POC";
            Name = "Line Item Change";
            
            Value(x => x.AssignedIdentification, 1, x => x.MinLength(1).MaxLength(20));
            Value(x => x.ChangeOrResponseTypeCode, 2, x => x.FixedLength(2));
            Value(x => x.Quantity, 3, x => x.MinLength(1).MaxLength(15));
            Value(x => x.QuantityLeftToReceive, 4, x => x.MinLength(1).MaxLength(9));
            Entity(x => x.CompositeUnitOfMeasure, 5);
            Value(x => x.UnitPrice, 6, x => x.MinLength(1).MaxLength(17));
            Value(x => x.BasisOfUnitPriceCode, 7, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceIdQualifier1, 8, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId1, 9, x => x.MinLength(1).MaxLength(48));
            Value(x => x.ProductOrServiceIdQualifier2, 10, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId2, 11, x => x.MinLength(1).MaxLength(48));
            Value(x => x.ProductOrServiceIdQualifier3, 12, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId3, 13, x => x.MinLength(1).MaxLength(48));
            Value(x => x.ProductOrServiceIdQualifier4, 14, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId4, 15, x => x.MinLength(1).MaxLength(48));
            Value(x => x.ProductOrServiceIdQualifier5, 16, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId5, 17, x => x.MinLength(1).MaxLength(48));
            Value(x => x.ProductOrServiceIdQualifier6, 18, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId6, 19, x => x.MinLength(1).MaxLength(48));
            Value(x => x.ProductOrServiceIdQualifier7, 20, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId7, 21, x => x.MinLength(1).MaxLength(48));
            Value(x => x.ProductOrServiceIdQualifier8, 22, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId8, 23, x => x.MinLength(1).MaxLength(48));
            Value(x => x.ProductOrServiceIdQualifier9, 24, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId9, 25, x => x.MinLength(1).MaxLength(48));
            Value(x => x.ProductOrServiceIdQualifier10, 26, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId10, 27, x => x.MinLength(1).MaxLength(48));
        }
    }
}