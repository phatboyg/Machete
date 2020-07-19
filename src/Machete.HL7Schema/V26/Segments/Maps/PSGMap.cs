// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PSG (SegmentMap) - Product/Service Group
    /// </summary>
    public class PSGMap :
        HL7V26SegmentMap<PSG>
    {
        public PSGMap()
        {
            Id = "PSG";

            Name = "Product/Service Group";

            Entity(x => x.ProviderProductServiceGroupNumber, 1, x => x.IsRequired());
            Entity(x => x.PayerProductServiceGroupNumber, 2);
            Value(x => x.ProductServiceGroupSequenceNumber, 3, x => x.IsRequired());
            Value(x => x.AdjudicateAsGroup, 4, x => x.IsRequired());
            Entity(x => x.ProductServiceGroupBilledAmount, 5, x => x.IsRequired());
            Value(x => x.ProductServiceGroupDescription, 6, x => x.IsRequired());
        }
    }
}