// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// TCC (Segment) - Test Code Configuration
    /// </summary>
    public interface TCC :
        HL7V26Segment
    {
        /// <summary>
        /// TCC-1: Universal Service Identifier
        /// </summary>
        Value<CWE> UniversalServiceIdentifier { get; }

        /// <summary>
        /// TCC-2: Equipment Test Application Identifier
        /// </summary>
        Value<EI> EquipmentTestApplicationIdentifier { get; }

        /// <summary>
        /// TCC-3: Specimen Source
        /// </summary>
        Value<SPS> SpecimenSource { get; }

        /// <summary>
        /// TCC-4: Auto-Dilution Factor Default
        /// </summary>
        Value<SN> AutoDilutionFactorDefault { get; }

        /// <summary>
        /// TCC-5: Rerun Dilution Factor Default
        /// </summary>
        Value<SN> RerunDilutionFactorDefault { get; }

        /// <summary>
        /// TCC-6: Pre-Dilution Factor Default
        /// </summary>
        Value<SN> PreDilutionFactorDefault { get; }

        /// <summary>
        /// TCC-7: Endogenous Content of Pre-Dilution Diluent
        /// </summary>
        Value<SN> EndogenouContentOfPreDilutionDiluent { get; }

        /// <summary>
        /// TCC-8: Inventory Limits Warning Level
        /// </summary>
        Value<decimal> InventoryLimitsWarningLevel { get; }

        /// <summary>
        /// TCC-9: Automatic Rerun Allowed
        /// </summary>
        Value<string> AutomaticRerunAllowed { get; }

        /// <summary>
        /// TCC-10: Automatic Repeat Allowed
        /// </summary>
        Value<string> AutomaticRepeatAllowed { get; }

        /// <summary>
        /// TCC-11: Automatic Reflex Allowed
        /// </summary>
        Value<string> AutomaticReflexAllowed { get; }

        /// <summary>
        /// TCC-12: Equipment Dynamic Range
        /// </summary>
        Value<SN> EquipmentDynamicRange { get; }

        /// <summary>
        /// TCC-13: Units
        /// </summary>
        Value<CWE> Units { get; }

        /// <summary>
        /// TCC-14: Processing Type
        /// </summary>
        Value<CWE> ProcessingType { get; }
    }
}