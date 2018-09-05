// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// RMI (Segment) - Risk Management Incident
    /// </summary>
    public interface RMI :
        HL7V26Segment
    {
        /// <summary>
        /// RMI-1: Risk Management Incident Code
        /// </summary>
        Value<CWE> RiskManagementIncidentCode { get; }

        /// <summary>
        /// RMI-2: Date/Time Incident
        /// </summary>
        Value<DateTimeOffset> DateTimeIncident { get; }

        /// <summary>
        /// RMI-3: Incident Type Code
        /// </summary>
        Value<CWE> IncidentTypeCode { get; }
    }
}