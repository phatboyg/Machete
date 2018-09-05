// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// URD (Segment) - Results/update Definition
    /// </summary>
    public interface URD :
        HL7V26Segment
    {
        /// <summary>
        /// URD-1: R/U Date/Time
        /// </summary>
        Value<DateTimeOffset> RUDateTime { get; }

        /// <summary>
        /// URD-2: Report Priority
        /// </summary>
        Value<string> ReportPriority { get; }

        /// <summary>
        /// URD-3: R/U Who Subject Definition
        /// </summary>
        ValueList<XCN> RUWhoSubjectDefinition { get; }

        /// <summary>
        /// URD-4: R/U What Subject Definition
        /// </summary>
        ValueList<CWE> RUWhatSubjectDefinition { get; }

        /// <summary>
        /// URD-5: R/U What Department Code
        /// </summary>
        ValueList<CWE> RUWhatDepartmentCode { get; }

        /// <summary>
        /// URD-6: R/U Display/Print Locations
        /// </summary>
        ValueList<string> RUDisplayPrintLocations { get; }

        /// <summary>
        /// URD-7: R/U Results Level
        /// </summary>
        Value<string> RUResultLevel { get; }
    }
}