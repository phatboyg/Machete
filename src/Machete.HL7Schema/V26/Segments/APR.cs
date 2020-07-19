// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// APR (Segment) - Appointment Preferences
    /// </summary>
    public interface APR :
        HL7V26Segment
    {
        /// <summary>
        /// APR-1: Time Selection Criteria
        /// </summary>
        ValueList<SCV> TimeSelectionCriteria { get; }

        /// <summary>
        /// APR-2: Resource Selection Criteria
        /// </summary>
        ValueList<SCV> ResourceSelectionCriteria { get; }

        /// <summary>
        /// APR-3: Location Selection Criteria
        /// </summary>
        ValueList<SCV> LocationSelectionCriteria { get; }

        /// <summary>
        /// APR-4: Slot Spacing Criteria
        /// </summary>
        Value<decimal> SlotSpacingCriteria { get; }

        /// <summary>
        /// APR-5: Filler Override Criteria
        /// </summary>
        ValueList<SCV> FillerOverrideCriteria { get; }
    }
}