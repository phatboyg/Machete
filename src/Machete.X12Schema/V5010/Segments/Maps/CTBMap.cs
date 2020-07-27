namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class CTBMap :
        X12SegmentMap<CTB, X12Entity>
    {
        public CTBMap()
        {
            Id = "CTB";
            Name = "Restrictions/Conditions";
            
            Value(x => x.RestrictionsOrConditionsQualifier, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.Description, 2, x => x.MinLength(1).MaxLength(80));
            Value(x => x.QuantityQualifier, 3, x => x.FixedLength(2));
            Value(x => x.Quantity, 4, x => x.MinLength(1).MaxLength(15));
            Value(x => x.AmountQualifier, 5, x => x.MinLength(1).MaxLength(3));
            Value(x => x.Amount, 6, x => x.MinLength(1).MaxLength(15));
            Entity(x => x.CompositeUnitOfMeasure, 7);
        }
    }
}