// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OSD (ComponentMap) - Order Sequence Definition
    /// </summary>
    public class OSDMap :
        HL7ComponentMap<OSD>
    {
        public OSDMap()
        {
            Value(x => x.SequenceResultsFlag, 1);
            Value(x => x.PlacerOrderNumberEntityIdentifier, 2);
            Value(x => x.PlacerOrderNumberNamespaceId, 3);
            Value(x => x.FillerOrderNumberEntityIdentifier, 4);
            Value(x => x.FillerOrderNumberNamespaceId, 5);
            Value(x => x.SequenceConditionValue, 6);
            Value(x => x.MaximumNumberOfRepeats, 7);
            Value(x => x.PlacerOrderNumberUniversalId, 8);
            Value(x => x.PlacerOrderNumberUniversalIdType, 9);
            Value(x => x.FillerOrderNumberUniversalId, 10);
            Value(x => x.FillerOrderNumberUniversalIdType, 11);
        }
    }
}