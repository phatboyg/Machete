namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class SLNMap :
        X12SegmentMap<SLN, X12Entity>
    {
        public SLNMap()
        {
            Id = "SLN";
            Name = "Subline Item Detail";
            
            Value(x => x.AssignedIdentification1, 1, x => x.MinLength(1).MaxLength(20).IsRequired());
            Value(x => x.AssignedIdentification2, 2, x => x.MinLength(1).MaxLength(20));
            Value(x => x.RelationshipCode1, 3, x => x.FixedLength(1).IsRequired());
            Value(x => x.Quantity, 4, x => x.MinLength(1).MaxLength(15));
            Entity(x => x.CompositeUnitOfMeasure, 5);
            Value(x => x.UnitPrice, 6, x => x.MinLength(1).MaxLength(17));
            Value(x => x.BasisOfUnitPriceCode, 7, x => x.FixedLength(2));
            Value(x => x.RelationshipCode2, 8, x => x.FixedLength(1));
            Value(x => x.ProductOrServiceIdQualifier1, 9, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId1, 10, x => x.MinLength(1).MaxLength(48));
            Value(x => x.ProductOrServiceIdQualifier2, 11, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId2, 12, x => x.MinLength(1).MaxLength(48));
            Value(x => x.ProductOrServiceIdQualifier3, 13, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId3, 14, x => x.MinLength(1).MaxLength(48));
            Value(x => x.ProductOrServiceIdQualifier4, 15, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId4, 16, x => x.MinLength(1).MaxLength(48));
            Value(x => x.ProductOrServiceIdQualifier5, 17, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId5, 18, x => x.MinLength(1).MaxLength(48));
            Value(x => x.ProductOrServiceIdQualifier6, 19, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId6, 20, x => x.MinLength(1).MaxLength(48));
            Value(x => x.ProductOrServiceIdQualifier7, 21, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId7, 22, x => x.MinLength(1).MaxLength(48));
            Value(x => x.ProductOrServiceIdQualifier8, 23, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId8, 24, x => x.MinLength(1).MaxLength(48));
            Value(x => x.ProductOrServiceIdQualifier9, 25, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId9, 26, x => x.MinLength(1).MaxLength(48));
            Value(x => x.ProductOrServiceIdQualifier10, 27, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId10, 28, x => x.MinLength(1).MaxLength(48));
        }
    }
}