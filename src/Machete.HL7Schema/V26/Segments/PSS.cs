// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// PSS (Segment) - Product/Service Section
    /// </summary>
    public interface PSS :
        HL7V26Segment
    {
        /// <summary>
        /// PSS-1: Provider Product/Service Section Number
        /// </summary>
        Value<EI> ProviderProductServiceSectionNumber { get; }

        /// <summary>
        /// PSS-2: Payer Product/Service Section Number
        /// </summary>
        Value<EI> PayerProductServiceSectionNumber { get; }

        /// <summary>
        /// PSS-3: Product/Service Section Sequence Number
        /// </summary>
        Value<int> ProductServiceSectionSequenceNumber { get; }

        /// <summary>
        /// PSS-4: Billed Amount
        /// </summary>
        Value<CP> BilledAmount { get; }

        /// <summary>
        /// PSS-5: Section Description or Heading
        /// </summary>
        Value<string> SectionDescriptionOrHeading { get; }
    }
}