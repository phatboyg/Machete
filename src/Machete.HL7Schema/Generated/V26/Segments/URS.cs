// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// URS (Segment) - Unsolicited Selection
    /// </summary>
    public interface URS :
        HL7V26Segment
    {
        /// <summary>
        /// URS-1: R/U Where Subject Definition
        /// </summary>
        ValueList<string> RUWhereSubjectDefinition { get; }

        /// <summary>
        /// URS-2: R/U When Data Start Date/Time
        /// </summary>
        Value<DateTimeOffset> RUWhenDataStartDateTime { get; }

        /// <summary>
        /// URS-3: R/U When Data End Date/Time
        /// </summary>
        Value<DateTimeOffset> RUWhenDataEndDateTime { get; }

        /// <summary>
        /// URS-4: R/U What User Qualifier
        /// </summary>
        ValueList<string> RUWhatUserQualifier { get; }

        /// <summary>
        /// URS-5: R/U Other Results Subject Definition
        /// </summary>
        ValueList<string> RUOtherResultsSubjectDefinition { get; }

        /// <summary>
        /// URS-6: R/U Which Date/Time Qualifier
        /// </summary>
        ValueList<string> RUWhichDateTimeQualifier { get; }

        /// <summary>
        /// URS-7: R/U Which Date/Time Status Qualifier
        /// </summary>
        ValueList<string> RUWhichDateTimeStatusQualifier { get; }

        /// <summary>
        /// URS-8: R/U Date/Time Selection Qualifier
        /// </summary>
        ValueList<string> RUDateTimeSelectionQualifier { get; }

        /// <summary>
        /// URS-9: R/U Quantity/Timing Qualifier
        /// </summary>
        Value<TQ> RUQuantityTimingQualifier { get; }
    }
}