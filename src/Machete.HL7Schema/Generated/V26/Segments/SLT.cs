// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// SLT (Segment) - Sterilization Lot
    /// </summary>
    public interface SLT :
        HL7V26Segment
    {
        /// <summary>
        /// SLT-1: Device Number
        /// </summary>
        Value<EI> DeviceNumber { get; }

        /// <summary>
        /// SLT-2: Device Name
        /// </summary>
        Value<string> DeviceName { get; }

        /// <summary>
        /// SLT-3: Lot Number
        /// </summary>
        Value<EI> LotNumber { get; }

        /// <summary>
        /// SLT-4: Item Identifier
        /// </summary>
        Value<EI> ItemIdentifier { get; }

        /// <summary>
        /// SLT-5: Bar Code
        /// </summary>
        Value<string> BarCode { get; }
    }
}