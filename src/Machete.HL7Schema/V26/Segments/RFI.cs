// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// RFI (Segment) - Request for Information
    /// </summary>
    public interface RFI :
        HL7V26Segment
    {
        /// <summary>
        /// RFI-1: Request Date
        /// </summary>
        Value<DateTimeOffset> RequestDate { get; }

        /// <summary>
        /// RFI-2: Response Due Date
        /// </summary>
        Value<DateTimeOffset> ResponseDueDate { get; }

        /// <summary>
        /// RFI-3: Patient Consent
        /// </summary>
        Value<string> PatientConsent { get; }

        /// <summary>
        /// RFI-4: Date Additional Information was submitted
        /// </summary>
        Value<DateTimeOffset> DateAdditionalInformationWasSubmitted { get; }
    }
}