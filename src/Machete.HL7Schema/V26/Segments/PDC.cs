// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// PDC (Segment) - Product Detail Country
    /// </summary>
    public interface PDC :
        HL7V26Segment
    {
        /// <summary>
        /// PDC-1: Manufacturer/Distributor
        /// </summary>
        ValueList<XON> ManufacturerDistributor { get; }

        /// <summary>
        /// PDC-2: Country
        /// </summary>
        Value<CWE> Country { get; }

        /// <summary>
        /// PDC-3: Brand Name
        /// </summary>
        Value<string> BrandName { get; }

        /// <summary>
        /// PDC-4: Device Family Name
        /// </summary>
        Value<string> DeviceFamilyName { get; }

        /// <summary>
        /// PDC-5: Generic Name
        /// </summary>
        Value<CWE> GenericName { get; }

        /// <summary>
        /// PDC-6: Model Identifier
        /// </summary>
        ValueList<string> ModelIdentifier { get; }

        /// <summary>
        /// PDC-7: Catalogue Identifier
        /// </summary>
        Value<string> CatalogueIdentifier { get; }

        /// <summary>
        /// PDC-8: Other Identifier
        /// </summary>
        ValueList<string> OtherIdentifier { get; }

        /// <summary>
        /// PDC-9: Product Code
        /// </summary>
        Value<CWE> ProductCode { get; }

        /// <summary>
        /// PDC-10: Marketing Basis
        /// </summary>
        Value<string> MarketingBasis { get; }

        /// <summary>
        /// PDC-11: Marketing Approval ID
        /// </summary>
        Value<string> MarketingApprovalId { get; }

        /// <summary>
        /// PDC-12: Labeled Shelf Life
        /// </summary>
        Value<CQ> LabeledShelfLife { get; }

        /// <summary>
        /// PDC-13: Expected Shelf Life
        /// </summary>
        Value<CQ> ExpectedShelfLife { get; }

        /// <summary>
        /// PDC-14: Date First Marketed
        /// </summary>
        Value<DateTimeOffset> DateFirstMarketed { get; }

        /// <summary>
        /// PDC-15: Date Last Marketed
        /// </summary>
        Value<DateTimeOffset> DateLastMarketed { get; }
    }
}