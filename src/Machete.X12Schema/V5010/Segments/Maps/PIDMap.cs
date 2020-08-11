namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class PIDMap :
        X12SegmentMap<PID, X12Entity>
    {
        public PIDMap()
        {
            Id = "PID";
            Name = "Product/Item Description";
            
            Value(x => x.ItemDescriptionType, 1, x => x.FixedLength(1).IsRequired());
            Value(x => x.ProductOrProcessCharacteristicCode, 2, x => x.MinLength(2).MaxLength(3));
            Value(x => x.AgencyQualifierCode, 3, x => x.FixedLength(2));
            Value(x => x.ProductDescriptionCode, 4, x => x.MinLength(1).MaxLength(12));
            Value(x => x.Description, 5, x => x.MinLength(1).MaxLength(80));
            Value(x => x.SurfaceLayerOrPositionCode, 6, x => x.FixedLength(2));
            Value(x => x.SourceSubQualifier, 7, x => x.MinLength(1).MaxLength(15));
            Value(x => x.YesNoConditionOrResponseCode, 8, x => x.FixedLength(1));
            Value(x => x.LanguageCode, 9, x => x.MinLength(2).MaxLength(3));
        }
    }
}