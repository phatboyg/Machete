// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// RQ1 (Segment) - Requisition Detail-1
    /// </summary>
    public interface RQ1 :
        HL7V26Segment
    {
        /// <summary>
        /// RQ1-1: Anticipated Price
        /// </summary>
        Value<string> AnticipatedPrice { get; }

        /// <summary>
        /// RQ1-2: Manufacturer Identifier
        /// </summary>
        Value<CWE> ManufacturerIdentifier { get; }

        /// <summary>
        /// RQ1-3: Manufacturer's Catalog
        /// </summary>
        Value<string> ManufacturerSCatalog { get; }

        /// <summary>
        /// RQ1-4: Vendor ID
        /// </summary>
        Value<CWE> VendorId { get; }

        /// <summary>
        /// RQ1-5: Vendor Catalog
        /// </summary>
        Value<string> VendorCatalog { get; }

        /// <summary>
        /// RQ1-6: Taxable
        /// </summary>
        Value<string> Taxable { get; }

        /// <summary>
        /// RQ1-7: Substitute Allowed
        /// </summary>
        Value<string> SubstituteAllowed { get; }
    }
}