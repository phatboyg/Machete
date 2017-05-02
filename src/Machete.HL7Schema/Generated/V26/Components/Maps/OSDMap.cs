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
            Value(x => x.SequenceResultsFlag, 0);
            Value(x => x.PlacerOrderNumberEntityIdentifier, 1);
            Value(x => x.PlacerOrderNumberNamespaceId, 2);
            Value(x => x.FillerOrderNumberEntityIdentifier, 3);
            Value(x => x.FillerOrderNumberNamespaceId, 4);
            Value(x => x.SequenceConditionValue, 5);
            Value(x => x.MaximumNumberOfRepeats, 6);
            Value(x => x.PlacerOrderNumberUniversalId, 7);
            Value(x => x.PlacerOrderNumberUniversalIdType, 8);
            Value(x => x.FillerOrderNumberUniversalId, 9);
            Value(x => x.FillerOrderNumberUniversalIdType, 10);
        }
    }
}