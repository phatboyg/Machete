// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PMT (SegmentMap) - Payment Information
    /// </summary>
    public class PMTMap :
        HL7SegmentMap<PMT>
    {
        public PMTMap()
        {
            Id = "PMT";

            Name = "Payment Information";

            Entity(x => x.PaymentRemittanceAdviceNumber, 1, x => {x.Required = true;});
            Value(x => x.PaymentRemittanceEffectiveDateTime, 2, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;x.Required = true;});
            Value(x => x.PaymentRemittanceExpirationDateTime, 3, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;x.Required = true;});
            Entity(x => x.PaymentMethod, 4, x => {x.Required = true;});
            Value(x => x.PaymentRemittanceDateTime, 5, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;x.Required = true;});
            Entity(x => x.PaymentRemittanceAmount, 6, x => {x.Required = true;});
            Entity(x => x.CheckNumber, 7);
            Entity(x => x.PayeeBankIdentification, 8);
            Value(x => x.PayeeTransitNumber, 9);
            Entity(x => x.PayeeBankAccountId, 10);
            Entity(x => x.PaymentOrganization, 11, x => {x.Required = true;});
            Value(x => x.ESRCodeLine, 12);
        }
    }
}