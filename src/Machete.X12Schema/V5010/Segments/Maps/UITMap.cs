namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class UITMap :
        X12SegmentMap<UIT, X12Entity>
    {
        public UITMap()
        {
            Id = "UIT";
            Name = "Unit Detail";
            
            Entity(x => x.CompositeUnitOfMeasure, 1, x => x.IsRequired());
            Value(x => x.UnitPrice, 2, x => x.MinLength(1).MaxLength(17));
            Value(x => x.BasisOfUnitPriceCode, 3, x => x.FixedLength(2));
        }
    }
}