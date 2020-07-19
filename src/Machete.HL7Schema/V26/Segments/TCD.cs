// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// TCD (Segment) - Test Code Detail
    /// </summary>
    public interface TCD :
        HL7V26Segment
    {
        /// <summary>
        /// TCD-1: Universal Service Identifier
        /// </summary>
        Value<CWE> UniversalServiceIdentifier { get; }

        /// <summary>
        /// TCD-2: Auto-Dilution Factor
        /// </summary>
        Value<SN> AutoDilutionFactor { get; }

        /// <summary>
        /// TCD-3: Rerun Dilution Factor
        /// </summary>
        Value<SN> RerunDilutionFactor { get; }

        /// <summary>
        /// TCD-4: Pre-Dilution Factor
        /// </summary>
        Value<SN> PreDilutionFactor { get; }

        /// <summary>
        /// TCD-5: Endogenous Content of Pre-Dilution Diluent
        /// </summary>
        Value<SN> EndogenousContentOfPreDilutionDiluent { get; }

        /// <summary>
        /// TCD-6: Automatic Repeat Allowed
        /// </summary>
        Value<string> AutomaticRepeatAllowed { get; }

        /// <summary>
        /// TCD-7: Reflex Allowed
        /// </summary>
        Value<string> ReflexAllowed { get; }

        /// <summary>
        /// TCD-8: Analyte Repeat Status
        /// </summary>
        Value<CWE> AnalyteRepeatStatus { get; }
    }
}