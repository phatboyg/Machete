// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// DB1 (Segment) - Disability
    /// </summary>
    public interface DB1 :
        HL7V26Segment
    {
        /// <summary>
        /// DB1-1: Set ID - DB1
        /// </summary>
        Value<int> SetId { get; }

        /// <summary>
        /// DB1-2: Disabled Person Code
        /// </summary>
        Value<string> DisabledPersonCode { get; }

        /// <summary>
        /// DB1-3: Disabled Person Identifier
        /// </summary>
        ValueList<CX> DisabledPersonIdentifier { get; }

        /// <summary>
        /// DB1-4: Disability Indicator
        /// </summary>
        Value<string> DisabilityIndicator { get; }

        /// <summary>
        /// DB1-5: Disability Start Date
        /// </summary>
        Value<DateTimeOffset> DisabilityStartDate { get; }

        /// <summary>
        /// DB1-6: Disability End Date
        /// </summary>
        Value<DateTimeOffset> DisabilityEndDate { get; }

        /// <summary>
        /// DB1-7: Disability Return to Work Date
        /// </summary>
        Value<DateTimeOffset> DisabilityReturnToWorkDate { get; }

        /// <summary>
        /// DB1-8: Disability Unable to Work Date
        /// </summary>
        Value<DateTimeOffset> DisabilityUnableToWorkDate { get; }
    }
}