// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PSS (SegmentMap) - Product/Service Section
    /// </summary>
    public class PSSMap :
        HL7V26SegmentMap<PSS>
    {
        public PSSMap()
        {
            Id = "PSS";

            Name = "Product/Service Section";

            Entity(x => x.ProviderProductServiceSectionNumber, 1, x => x.IsRequired());
            Entity(x => x.PayerProductServiceSectionNumber, 2);
            Value(x => x.ProductServiceSectionSequenceNumber, 3, x => x.IsRequired());
            Entity(x => x.BilledAmount, 4, x => x.IsRequired());
            Value(x => x.SectionDescriptionOrHeading, 5, x => x.IsRequired());
        }
    }
}