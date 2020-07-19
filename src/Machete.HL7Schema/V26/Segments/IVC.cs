// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// IVC (Segment) - Invoice Segment
    /// </summary>
    public interface IVC :
        HL7V26Segment
    {
        /// <summary>
        /// IVC-1: Provider Invoice Number
        /// </summary>
        Value<EI> ProviderInvoiceNumber { get; }

        /// <summary>
        /// IVC-2: Payer Invoice Number
        /// </summary>
        Value<EI> PayerInvoiceNumber { get; }

        /// <summary>
        /// IVC-3: Contract/Agreement Number
        /// </summary>
        Value<EI> ContractAgreementNumber { get; }

        /// <summary>
        /// IVC-4: Invoice Control
        /// </summary>
        Value<string> InvoiceControl { get; }

        /// <summary>
        /// IVC-5: Invoice Reason
        /// </summary>
        Value<string> InvoiceReason { get; }

        /// <summary>
        /// IVC-6: Invoice Type
        /// </summary>
        Value<string> InvoiceType { get; }

        /// <summary>
        /// IVC-7: Invoice Date/Time
        /// </summary>
        Value<DateTimeOffset> InvoiceDateTime { get; }

        /// <summary>
        /// IVC-8: Invoice Amount
        /// </summary>
        Value<CP> InvoiceAmount { get; }

        /// <summary>
        /// IVC-9: Payment Terms
        /// </summary>
        Value<string> PaymentTerms { get; }

        /// <summary>
        /// IVC-10: Provider Organization
        /// </summary>
        Value<XON> ProviderOrganization { get; }

        /// <summary>
        /// IVC-11: Payer Organization
        /// </summary>
        Value<XON> PayerOrganization { get; }

        /// <summary>
        /// IVC-12: Attention
        /// </summary>
        Value<XCN> Attention { get; }

        /// <summary>
        /// IVC-13: Last Invoice Indicator
        /// </summary>
        Value<string> LastInvoiceIndicator { get; }

        /// <summary>
        /// IVC-14: Invoice Booking Period
        /// </summary>
        Value<DateTimeOffset> InvoiceBookingPeriod { get; }

        /// <summary>
        /// IVC-15: Origin
        /// </summary>
        Value<string> Origin { get; }

        /// <summary>
        /// IVC-16: Invoice Fixed Amount
        /// </summary>
        Value<CP> InvoiceFixedAmount { get; }

        /// <summary>
        /// IVC-17: Special Costs
        /// </summary>
        Value<CP> SpecialCosts { get; }

        /// <summary>
        /// IVC-18: Amount for Doctors Treatment
        /// </summary>
        Value<CP> AmountForDoctorsTreatment { get; }

        /// <summary>
        /// IVC-19: Responsible Physician
        /// </summary>
        Value<XCN> ResponsiblePhysician { get; }

        /// <summary>
        /// IVC-20: Cost Center
        /// </summary>
        Value<CX> CostCenter { get; }

        /// <summary>
        /// IVC-21: Invoice Prepaid Amount
        /// </summary>
        Value<CP> InvoicePrepaidAmount { get; }

        /// <summary>
        /// IVC-22: Total Invoice Amount without Prepaid Amount
        /// </summary>
        Value<CP> TotalInvoiceAmountWithoutPrepaidAmount { get; }

        /// <summary>
        /// IVC-23: Total-Amount of VAT
        /// </summary>
        Value<CP> TotalAmountOfVAT { get; }

        /// <summary>
        /// IVC-24: VAT-Rates applied
        /// </summary>
        ValueList<decimal> VATRateApplied { get; }

        /// <summary>
        /// IVC-25: Benefit Group
        /// </summary>
        Value<string> BenefitGroup { get; }

        /// <summary>
        /// IVC-26: Provider Tax ID
        /// </summary>
        Value<string> ProviderTaxId { get; }

        /// <summary>
        /// IVC-27: Payer Tax ID
        /// </summary>
        Value<string> PayerTaxId { get; }

        /// <summary>
        /// IVC-28: Provider Tax status
        /// </summary>
        Value<string> ProviderTaxStatus { get; }

        /// <summary>
        /// IVC-29: Payer Tax status
        /// </summary>
        Value<string> PayerTaxStatus { get; }

        /// <summary>
        /// IVC-30: Sales Tax ID
        /// </summary>
        Value<string> SaleTaxId { get; }
    }
}