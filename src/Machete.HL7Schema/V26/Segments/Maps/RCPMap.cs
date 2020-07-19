// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RCP (SegmentMap) - Response Control Parameter
    /// </summary>
    public class RCPMap :
        HL7V26SegmentMap<RCP>
    {
        public RCPMap()
        {
            Id = "RCP";

            Name = "Response Control Parameter";

            Value(x => x.QueryPriority, 1);
            Entity(x => x.QuantityLimitedRequest, 2);
            Entity(x => x.ResponseModality, 3);
            Value(x => x.ExecutionAndDeliveryTime, 4, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.ModifyIndicator, 5);
            Entity(x => x.SortByField, 6);
            Value(x => x.SegmentGroupInclusion, 7);
        }
    }
}