// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// PSG (Segment) - Product/Service Group
    /// </summary>
    public interface PSG :
        HL7V26Segment
    {
        /// <summary>
        /// PSG-1: Provider Product/Service Group Number
        /// </summary>
        Value<EI> ProviderProductServiceGroupNumber { get; }

        /// <summary>
        /// PSG-2: Payer Product/Service Group Number
        /// </summary>
        Value<EI> PayerProductServiceGroupNumber { get; }

        /// <summary>
        /// PSG-3: Product/Service Group Sequence Number
        /// </summary>
        Value<int> ProductServiceGroupSequenceNumber { get; }

        /// <summary>
        /// PSG-4: Adjudicate as Group
        /// </summary>
        Value<string> AdjudicateAsGroup { get; }

        /// <summary>
        /// PSG-5: Product/Service Group Billed Amount
        /// </summary>
        Value<CP> ProductServiceGroupBilledAmount { get; }

        /// <summary>
        /// PSG-6: Product/Service Group Description
        /// </summary>
        Value<string> ProductServiceGroupDescription { get; }
    }
}