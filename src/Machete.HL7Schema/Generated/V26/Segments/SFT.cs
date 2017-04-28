// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;
    using HL7;

    /// <summary>
    /// SFT (Segment) - Software Segment
    /// </summary>
    public interface SFT :
        HL7Segment
    {
        /// <summary>
        /// SFT-1: Software Vendor Organization
        /// </summary>
        Value<XON> SoftwareVendorOrganization { get; }

        /// <summary>
        /// SFT-2: Software Certified Version or Release Number
        /// </summary>
        Value<string> SoftwareCertifiedVersionOrReleaseNumber { get; }

        /// <summary>
        /// SFT-3: Software Product Name
        /// </summary>
        Value<string> SoftwareProductName { get; }

        /// <summary>
        /// SFT-4: Software Binary ID
        /// </summary>
        Value<string> SoftwareBinaryId { get; }

        /// <summary>
        /// SFT-5: Software Product Information
        /// </summary>
        Value<TX> SoftwareProductInformation { get; }

        /// <summary>
        /// SFT-6: Software Install Date
        /// </summary>
        Value<DateTimeOffset> SoftwareInstallDate { get; }
    }
}