// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// VND (SegmentMap) - Purchasing Vendor
    /// </summary>
    public class VNDMap :
        HL7V26SegmentMap<VND>
    {
        public VNDMap()
        {
            Id = "VND";

            Name = "Purchasing Vendor";

            Value(x => x.SetId, 1, x => x.IsRequired());
            Entity(x => x.VendorIdentifier, 2, x => x.IsRequired());
            Value(x => x.VendorName, 3);
            Entity(x => x.VendorCatalogNumber, 4);
            Entity(x => x.PrimaryVendorIndicator, 5);
        }
    }
}