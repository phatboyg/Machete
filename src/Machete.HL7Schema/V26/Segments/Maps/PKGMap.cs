// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PKG (SegmentMap) - Item Packaging
    /// </summary>
    public class PKGMap :
        HL7V26SegmentMap<PKG>
    {
        public PKGMap()
        {
            Id = "PKG";

            Name = "Item Packaging";

            Value(x => x.SetId, 1, x => x.IsRequired());
            Entity(x => x.PackagingUnits, 2);
            Entity(x => x.DefaultOrderUnitOfMeasureIndicator, 3);
            Value(x => x.PackageQuantity, 4);
            Entity(x => x.Price, 5);
            Entity(x => x.FutureItemPrice, 6);
            Value(x => x.FutureItemPriceEffectiveDate, 7, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
        }
    }
}