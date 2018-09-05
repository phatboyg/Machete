// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// VND (Segment) - Purchasing Vendor
    /// </summary>
    public interface VND :
        HL7V26Segment
    {
        /// <summary>
        /// VND-1: Set Id - VND
        /// </summary>
        Value<int> SetId { get; }

        /// <summary>
        /// VND-2: Vendor Identifier
        /// </summary>
        Value<EI> VendorIdentifier { get; }

        /// <summary>
        /// VND-3: Vendor Name
        /// </summary>
        Value<string> VendorName { get; }

        /// <summary>
        /// VND-4: Vendor Catalog Number
        /// </summary>
        Value<EI> VendorCatalogNumber { get; }

        /// <summary>
        /// VND-5: Primary Vendor Indicator
        /// </summary>
        Value<CNE> PrimaryVendorIndicator { get; }
    }
}