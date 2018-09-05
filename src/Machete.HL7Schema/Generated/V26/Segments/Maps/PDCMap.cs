// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PDC (SegmentMap) - Product Detail Country
    /// </summary>
    public class PDCMap :
        HL7V26SegmentMap<PDC>
    {
        public PDCMap()
        {
            Id = "PDC";

            Name = "Product Detail Country";

            Entity(x => x.ManufacturerDistributor, 1, x => x.IsRequired());
            Entity(x => x.Country, 2, x => x.IsRequired());
            Value(x => x.BrandName, 3, x => x.IsRequired());
            Value(x => x.DeviceFamilyName, 4);
            Entity(x => x.GenericName, 5);
            Value(x => x.ModelIdentifier, 6);
            Value(x => x.CatalogueIdentifier, 7);
            Value(x => x.OtherIdentifier, 8);
            Entity(x => x.ProductCode, 9);
            Value(x => x.MarketingBasis, 10);
            Value(x => x.MarketingApprovalId, 11);
            Entity(x => x.LabeledShelfLife, 12);
            Entity(x => x.ExpectedShelfLife, 13);
            Value(x => x.DateFirstMarketed, 14, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.DateLastMarketed, 15, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
        }
    }
}