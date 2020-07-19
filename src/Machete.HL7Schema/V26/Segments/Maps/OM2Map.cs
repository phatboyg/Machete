// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OM2 (SegmentMap) - Numeric Observation
    /// </summary>
    public class OM2Map :
        HL7V26SegmentMap<OM2>
    {
        public OM2Map()
        {
            Id = "OM2";

            Name = "Numeric Observation";

            Value(x => x.SequenceNumberTestObservationMasterFile, 1);
            Entity(x => x.UnitOfMeasure, 2);
            Value(x => x.RangeOfDecimalPrecision, 3);
            Entity(x => x.CorrespondingSIUnitsOfMeasure, 4);
            Value(x => x.SIConversionFactor, 5);
            Entity(x => x.ReferenceNormalRangeForOrdinalAndContinuousObservations, 6);
            Entity(x => x.CriticalRangeForOrdinalAndContinuousObservations, 7);
            Entity(x => x.AbsoluteRangeForOrdinalAndContinuousObservations, 8);
            Entity(x => x.DeltaCheckCriteria, 9);
            Value(x => x.MinimumMeaningfulIncrements, 10);
        }
    }
}