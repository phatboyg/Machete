// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// SPS (Component) - Specimen Source
    /// </summary>
    public interface SPS :
        HL7V26Component
    {
        /// <summary>
        /// SPS-1  Specimen Source Name or Code
        /// </summary>
        /// <returns>The CWE value</returns>
        Value<CWE> SpecimenSourceNameOrCode { get; }

        /// <summary>
        /// SPS-2  Additives
        /// </summary>
        /// <returns>The CWE value</returns>
        Value<CWE> Additives { get; }

        /// <summary>
        /// SPS-3  Specimen Collection Method
        /// </summary>
        /// <returns>The TX value</returns>
        Value<TX> SpecimenCollectionMethod { get; }

        /// <summary>
        /// SPS-4  Body Site
        /// </summary>
        /// <returns>The CWE value</returns>
        Value<CWE> BodySite { get; }

        /// <summary>
        /// SPS-5  Site Modifier
        /// </summary>
        /// <returns>The CWE value</returns>
        Value<CWE> SiteModifier { get; }

        /// <summary>
        /// SPS-6  Collection Method Modifier Code
        /// </summary>
        /// <returns>The CWE value</returns>
        Value<CWE> CollectionMethodModifierCode { get; }

        /// <summary>
        /// SPS-7  Specimen Role
        /// </summary>
        /// <returns>The CWE value</returns>
        Value<CWE> SpecimenRole { get; }
    }
}