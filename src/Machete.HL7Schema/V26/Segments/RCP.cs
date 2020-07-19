// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// RCP (Segment) - Response Control Parameter
    /// </summary>
    public interface RCP :
        HL7V26Segment
    {
        /// <summary>
        /// RCP-1: Query Priority
        /// </summary>
        Value<string> QueryPriority { get; }

        /// <summary>
        /// RCP-2: Quantity Limited Request
        /// </summary>
        Value<CQ> QuantityLimitedRequest { get; }

        /// <summary>
        /// RCP-3: Response Modality
        /// </summary>
        Value<CNE> ResponseModality { get; }

        /// <summary>
        /// RCP-4: Execution and Delivery Time
        /// </summary>
        Value<DateTimeOffset> ExecutionAndDeliveryTime { get; }

        /// <summary>
        /// RCP-5: Modify Indicator
        /// </summary>
        Value<string> ModifyIndicator { get; }

        /// <summary>
        /// RCP-6: Sort-by Field
        /// </summary>
        ValueList<SRT> SortByField { get; }

        /// <summary>
        /// RCP-7: Segment group inclusion
        /// </summary>
        ValueList<string> SegmentGroupInclusion { get; }
    }
}