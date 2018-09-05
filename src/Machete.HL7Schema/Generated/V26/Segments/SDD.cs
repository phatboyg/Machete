// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// SDD (Segment) - Sterilization Device Data
    /// </summary>
    public interface SDD :
        HL7V26Segment
    {
        /// <summary>
        /// SDD-1: Lot Number
        /// </summary>
        Value<EI> LotNumber { get; }

        /// <summary>
        /// SDD-2: Device Number
        /// </summary>
        Value<EI> DeviceNumber { get; }

        /// <summary>
        /// SDD-3: Device Name
        /// </summary>
        Value<string> DeviceName { get; }

        /// <summary>
        /// SDD-4: Device Data State
        /// </summary>
        Value<string> DeviceDataState { get; }

        /// <summary>
        /// SDD-5: Load Status
        /// </summary>
        Value<string> LoadStatus { get; }

        /// <summary>
        /// SDD-6: Control Code
        /// </summary>
        Value<decimal> ControlCode { get; }

        /// <summary>
        /// SDD-7: Operator Name
        /// </summary>
        Value<string> OperatorName { get; }
    }
}