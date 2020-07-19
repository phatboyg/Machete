// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// IVC (SegmentMap) - Invoice Segment
    /// </summary>
    public class IVCMap :
        HL7V26SegmentMap<IVC>
    {
        public IVCMap()
        {
            Id = "IVC";

            Name = "Invoice Segment";

            Entity(x => x.ProviderInvoiceNumber, 1, x => x.IsRequired());
            Entity(x => x.PayerInvoiceNumber, 2);
            Entity(x => x.ContractAgreementNumber, 3);
            Value(x => x.InvoiceControl, 4, x => x.IsRequired());
            Value(x => x.InvoiceReason, 5, x => x.IsRequired());
            Value(x => x.InvoiceType, 6, x => x.IsRequired());
            Value(x => x.InvoiceDateTime, 7, x =>
            {
                x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;
                x.IsRequired();
            });
            Entity(x => x.InvoiceAmount, 8, x => x.IsRequired());
            Value(x => x.PaymentTerms, 9);
            Entity(x => x.ProviderOrganization, 10, x => x.IsRequired());
            Entity(x => x.PayerOrganization, 11, x => x.IsRequired());
            Entity(x => x.Attention, 12);
            Value(x => x.LastInvoiceIndicator, 13);
            Value(x => x.InvoiceBookingPeriod, 14, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.Origin, 15);
            Entity(x => x.InvoiceFixedAmount, 16);
            Entity(x => x.SpecialCosts, 17);
            Entity(x => x.AmountForDoctorsTreatment, 18);
            Entity(x => x.ResponsiblePhysician, 19);
            Entity(x => x.CostCenter, 20);
            Entity(x => x.InvoicePrepaidAmount, 21);
            Entity(x => x.TotalInvoiceAmountWithoutPrepaidAmount, 22);
            Entity(x => x.TotalAmountOfVAT, 23);
            Value(x => x.VATRateApplied, 24);
            Value(x => x.BenefitGroup, 25, x => {x.Required = true;});
            Value(x => x.ProviderTaxId, 26);
            Value(x => x.PayerTaxId, 27);
            Value(x => x.ProviderTaxStatus, 28);
            Value(x => x.PayerTaxStatus, 29);
            Value(x => x.SaleTaxId, 30);
        }
    }
}