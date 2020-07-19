// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// SCP (Segment) - Sterilizer Configuration Segment
    /// </summary>
    public interface SCP :
        HL7V26Segment
    {
        /// <summary>
        /// SCP-1: Number Of Decontamination/Sterilization Devices
        /// </summary>
        Value<decimal> NumberOfDecontaminationSterilizationDevices { get; }

        /// <summary>
        /// SCP-2: Labor Calculation Type
        /// </summary>
        Value<CWE> LaborCalculationType { get; }

        /// <summary>
        /// SCP-3: Date Format
        /// </summary>
        Value<CWE> DateFormat { get; }

        /// <summary>
        /// SCP-4: Device Number
        /// </summary>
        Value<EI> DeviceNumber { get; }

        /// <summary>
        /// SCP-5: Device Name
        /// </summary>
        Value<string> DeviceName { get; }

        /// <summary>
        /// SCP-6: Device Model Name
        /// </summary>
        Value<string> DeviceModelName { get; }

        /// <summary>
        /// SCP-7: Device Type
        /// </summary>
        Value<CWE> DeviceType { get; }

        /// <summary>
        /// SCP-8: Lot Control
        /// </summary>
        Value<CWE> LotControl { get; }
    }
}