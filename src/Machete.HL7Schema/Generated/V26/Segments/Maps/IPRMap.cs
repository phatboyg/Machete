// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// IPR (SegmentMap) - Invoice Processing Results
    /// </summary>
    public class IPRMap :
        HL7V26SegmentMap<IPR>
    {
        public IPRMap()
        {
            Id = "IPR";

            Name = "Invoice Processing Results";

            Entity(x => x.IPRIdentifier, 1, x => x.IsRequired());
            Entity(x => x.ProviderCrossReferenceIdentifier, 2, x => x.IsRequired());
            Entity(x => x.PayerCrossReferenceIdentifier, 3, x => x.IsRequired());
            Entity(x => x.IPRStatus, 4, x => x.IsRequired());
            Value(x => x.IPRDateTime, 5, x =>
            {
                x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;
                x.IsRequired();
            });
            Entity(x => x.AdjudicatedPaidAmount, 6);
            Value(x => x.ExpectedPaymentDateTime, 7, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.IPRChecksum, 8, x => x.IsRequired());
        }
    }
}