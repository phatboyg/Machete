// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// QPD (Segment) - Query Parameter Definition
    /// </summary>
    public interface QPD :
        HL7V26Segment
    {
        /// <summary>
        /// QPD-1: Message Query Name
        /// </summary>
        Value<CWE> MessageQueryName { get; }

        /// <summary>
        /// QPD-2: Query Tag
        /// </summary>
        Value<string> QueryTag { get; }

        /// <summary>
        /// QPD-3: User Parameters (in successive fields)
        /// </summary>
        Value<string> UserParametersInSuccessivefields { get; }
    }
}