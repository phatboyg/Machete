// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// OM2 (Segment) - Numeric Observation
    /// </summary>
    public interface OM2 :
        HL7V26Segment
    {
        /// <summary>
        /// OM2-1: Sequence Number - Test/Observation Master File
        /// </summary>
        Value<decimal> SequenceNumberTestObservationMasterFile { get; }

        /// <summary>
        /// OM2-2: Units of Measure
        /// </summary>
        Value<CWE> UnitOfMeasure { get; }

        /// <summary>
        /// OM2-3: Range of Decimal Precision
        /// </summary>
        ValueList<decimal> RangeOfDecimalPrecision { get; }

        /// <summary>
        /// OM2-4: Corresponding SI Units of Measure
        /// </summary>
        Value<CWE> CorrespondingSIUnitsOfMeasure { get; }

        /// <summary>
        /// OM2-5: SI Conversion Factor
        /// </summary>
        Value<TX> SIConversionFactor { get; }

        /// <summary>
        /// OM2-6: Reference (Normal) Range for Ordinal and Continuous Observations
        /// </summary>
        ValueList<RFR> ReferenceNormalRangeForOrdinalAndContinuousObservations { get; }

        /// <summary>
        /// OM2-7: Critical Range for Ordinal and Continuous Observations
        /// </summary>
        ValueList<RFR> CriticalRangeForOrdinalAndContinuousObservations { get; }

        /// <summary>
        /// OM2-8: Absolute Range for Ordinal and Continuous Observations
        /// </summary>
        Value<RFR> AbsoluteRangeForOrdinalAndContinuousObservations { get; }

        /// <summary>
        /// OM2-9: Delta Check Criteria
        /// </summary>
        ValueList<DLT> DeltaCheckCriteria { get; }

        /// <summary>
        /// OM2-10: Minimum Meaningful Increments
        /// </summary>
        Value<decimal> MinimumMeaningfulIncrements { get; }
    }
}