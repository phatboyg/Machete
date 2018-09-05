// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// PDA (Segment) - Patient Death and Autopsy
    /// </summary>
    public interface PDA :
        HL7V26Segment
    {
        /// <summary>
        /// PDA-1: Death Cause Code
        /// </summary>
        ValueList<CWE> DeathCauseCode { get; }

        /// <summary>
        /// PDA-2: Death Location
        /// </summary>
        Value<PL> DeathLocation { get; }

        /// <summary>
        /// PDA-3: Death Certified Indicator
        /// </summary>
        Value<string> DeathCertifiedIndicator { get; }

        /// <summary>
        /// PDA-4: Death Certificate Signed Date/Time
        /// </summary>
        Value<DateTimeOffset> DeathCertificateSignedDateTime { get; }

        /// <summary>
        /// PDA-5: Death Certified By
        /// </summary>
        Value<XCN> DeathCertifiedBy { get; }

        /// <summary>
        /// PDA-6: Autopsy Indicator
        /// </summary>
        Value<string> AutopsyIndicator { get; }

        /// <summary>
        /// PDA-7: Autopsy Start and End Date/Time
        /// </summary>
        Value<DR> AutopsyStartAndEndDateTime { get; }

        /// <summary>
        /// PDA-8: Autopsy Performed By
        /// </summary>
        Value<XCN> AutopsyPerformedBy { get; }

        /// <summary>
        /// PDA-9: Coroner Indicator
        /// </summary>
        Value<string> CoronerIndicator { get; }
    }
}