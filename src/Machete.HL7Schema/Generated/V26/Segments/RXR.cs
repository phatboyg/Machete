// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// RXR (Segment) - Pharmacy/Treatment Route
    /// </summary>
    public interface RXR :
        HL7V26Segment
    {
        /// <summary>
        /// RXR-1: Route
        /// </summary>
        Value<CWE> Route { get; }

        /// <summary>
        /// RXR-2: Administration Site
        /// </summary>
        Value<CWE> AdministrationSite { get; }

        /// <summary>
        /// RXR-3: Administration Device
        /// </summary>
        Value<CWE> AdministrationDevice { get; }

        /// <summary>
        /// RXR-4: Administration Method
        /// </summary>
        Value<CWE> AdministrationMethod { get; }

        /// <summary>
        /// RXR-5: Routing Instruction
        /// </summary>
        Value<CWE> RoutingInstruction { get; }

        /// <summary>
        /// RXR-6: Administration Site Modifier
        /// </summary>
        Value<CWE> AdministrationSiteModifier { get; }
    }
}