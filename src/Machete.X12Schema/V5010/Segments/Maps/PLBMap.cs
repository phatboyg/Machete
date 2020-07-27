namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;

    
    public class PLBMap :
        X12SegmentMap<PLB, X12Entity>
    {
        public PLBMap()
        {
            Id = "PLB";
            Name = "Provider Level Adjustment";
            
            Value(x => x.ReferenceIdentification, 1, x => x.MinLength(1).MaxLength(30).IsRequired());
            Value(x => x.Date, 2, x => x.LongDate().IsRequired());
            Value(x => x.AdjustmentIdentifier1, 3, x => x.FixedLength(1).IsRequired());
            Value(x => x.ProviderAdjustmentAmount1, 4, x => x.FixedLength(1).IsRequired());
            Value(x => x.AdjustmentIdentifier2, 5, x => x.FixedLength(1));
            Value(x => x.ProviderAdjustmentAmount2, 6, x => x.FixedLength(1));
            Value(x => x.AdjustmentIdentifier3, 7, x => x.FixedLength(1));
            Value(x => x.ProviderAdjustmentAmount3, 8, x => x.FixedLength(1));
            Value(x => x.AdjustmentIdentifier4, 9, x => x.FixedLength(1));
            Value(x => x.ProviderAdjustmentAmount4, 10, x => x.FixedLength(1));
            Value(x => x.AdjustmentIdentifier5, 11, x => x.FixedLength(1));
            Value(x => x.ProviderAdjustmentAmount5, 12, x => x.FixedLength(1));
            Value(x => x.AdjustmentIdentifier6, 13, x => x.FixedLength(1));
            Value(x => x.ProviderAdjustmentAmount6, 14, x => x.FixedLength(1));
        }
    }
}