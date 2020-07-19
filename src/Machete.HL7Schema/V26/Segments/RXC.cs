// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// RXC (Segment) - Pharmacy/Treatment Component Order
    /// </summary>
    public interface RXC :
        HL7V26Segment
    {
        /// <summary>
        /// RXC-1: RX Component Type
        /// </summary>
        Value<string> RXComponentType { get; }

        /// <summary>
        /// RXC-2: Component Code
        /// </summary>
        Value<CWE> ComponentCode { get; }

        /// <summary>
        /// RXC-3: Component Amount
        /// </summary>
        Value<decimal> ComponentAmount { get; }

        /// <summary>
        /// RXC-4: Component Units
        /// </summary>
        Value<CWE> ComponentUnits { get; }

        /// <summary>
        /// RXC-5: Component Strength
        /// </summary>
        Value<decimal> ComponentStrength { get; }

        /// <summary>
        /// RXC-6: Component Strength Units
        /// </summary>
        Value<CWE> ComponentStrengthUnits { get; }

        /// <summary>
        /// RXC-7: Supplementary Code
        /// </summary>
        ValueList<CWE> SupplementaryCode { get; }

        /// <summary>
        /// RXC-8: Component Drug Strength Volume
        /// </summary>
        Value<decimal> ComponentDrugStrengthVolume { get; }

        /// <summary>
        /// RXC-9: Component Drug Strength Volume Units
        /// </summary>
        Value<CWE> ComponentDrugStrengthVolumeUnits { get; }
    }
}