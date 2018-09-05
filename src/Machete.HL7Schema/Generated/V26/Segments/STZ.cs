// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// STZ (Segment) - Sterilization Parameter
    /// </summary>
    public interface STZ :
        HL7V26Segment
    {
        /// <summary>
        /// STZ-1: Sterilization Type
        /// </summary>
        Value<CWE> SterilizationType { get; }

        /// <summary>
        /// STZ-2: Sterilization Cycle
        /// </summary>
        Value<CWE> SterilizationCycle { get; }

        /// <summary>
        /// STZ-3: Maintenance Cycle
        /// </summary>
        Value<CWE> MaintenanceCycle { get; }

        /// <summary>
        /// STZ-4: Maintenance Type
        /// </summary>
        Value<CWE> MaintenanceType { get; }
    }
}