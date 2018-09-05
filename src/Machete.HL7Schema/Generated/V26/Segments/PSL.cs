// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// PSL (Segment) - Product/Service Line Item
    /// </summary>
    public interface PSL :
        HL7V26Segment
    {
        /// <summary>
        /// PSL-1: Provider Product/Service Line Item Number
        /// </summary>
        Value<EI> ProviderProductServiceLineItemNumber { get; }

        /// <summary>
        /// PSL-2: Payer Product/Service Line Item Number
        /// </summary>
        Value<EI> PayerProductServiceLineItemNumber { get; }

        /// <summary>
        /// PSL-3: Product/Service Line Item Sequence Number
        /// </summary>
        Value<int> ProductServiceLineItemSequenceNumber { get; }

        /// <summary>
        /// PSL-4: Provider Tracking ID
        /// </summary>
        Value<EI> ProviderTrackingId { get; }

        /// <summary>
        /// PSL-5: Payer Tracking ID
        /// </summary>
        Value<EI> PayerTrackingId { get; }

        /// <summary>
        /// PSL-6: Product/Service Line Item Status
        /// </summary>
        Value<CWE> ProductServiceLineItemStatus { get; }

        /// <summary>
        /// PSL-7: Product/Service Code
        /// </summary>
        Value<CWE> ProductServiceCode { get; }

        /// <summary>
        /// PSL-8: Product/Service Code Modifier
        /// </summary>
        Value<CWE> ProductServiceCodeModifier { get; }

        /// <summary>
        /// PSL-9: Product/Service Code Description
        /// </summary>
        Value<string> ProductServiceCodeDescription { get; }

        /// <summary>
        /// PSL-10: Product/Service Effective Date
        /// </summary>
        Value<DateTimeOffset> ProductServiceEffectiveDate { get; }

        /// <summary>
        /// PSL-11: Product/Service Expiration Date
        /// </summary>
        Value<DateTimeOffset> ProductServiceExpirationDate { get; }

        /// <summary>
        /// PSL-12: Product/Service Quantity
        /// </summary>
        Value<CQ> ProductServiceQuantity { get; }

        /// <summary>
        /// PSL-13: Product/Service Unit Cost
        /// </summary>
        Value<CP> ProductServiceUnitCost { get; }

        /// <summary>
        /// PSL-14: Number of Items per Unit
        /// </summary>
        Value<decimal> NumberOfItemsPerUnit { get; }

        /// <summary>
        /// PSL-15: Product/Service Gross Amount
        /// </summary>
        Value<CP> ProductServiceGrossAmount { get; }

        /// <summary>
        /// PSL-16: Product/Service Billed Amount
        /// </summary>
        Value<CP> ProductServiceBilledAmount { get; }

        /// <summary>
        /// PSL-17: Product/Service Clarification Code Type
        /// </summary>
        Value<string> ProductServiceClarificationCodeType { get; }

        /// <summary>
        /// PSL-18: Product/Service Clarification Code Value
        /// </summary>
        Value<string> ProductServiceClarificationCodeValue { get; }

        /// <summary>
        /// PSL-19: Health Document Reference Identifier
        /// </summary>
        Value<EI> HealthDocumentReferenceIdentifier { get; }

        /// <summary>
        /// PSL-20: Processing Consideration Code
        /// </summary>
        Value<string> ProcessingConsiderationCode { get; }

        /// <summary>
        /// PSL-21: Restricted Disclosure Indicator
        /// </summary>
        Value<string> RestrictedDisclosureIndicator { get; }

        /// <summary>
        /// PSL-22: Related Product/Service Code Indicator
        /// </summary>
        Value<CWE> RelatedProductServiceCodeIndicator { get; }

        /// <summary>
        /// PSL-23: Product/Service Amount for Physician
        /// </summary>
        Value<CP> ProductServiceAmountForPhysician { get; }

        /// <summary>
        /// PSL-24: Product/Service Cost Factor
        /// </summary>
        Value<decimal> ProductServiceCostFactor { get; }

        /// <summary>
        /// PSL-25: Cost Center
        /// </summary>
        Value<CX> CostCenter { get; }

        /// <summary>
        /// PSL-26: Billing Period
        /// </summary>
        Value<DR> BillingPeriod { get; }

        /// <summary>
        /// PSL-27: Days without Billing
        /// </summary>
        Value<decimal> DayWithoutBilling { get; }

        /// <summary>
        /// PSL-28: Session-No
        /// </summary>
        Value<decimal> SessionNo { get; }

        /// <summary>
        /// PSL-29: Executing Physician ID
        /// </summary>
        Value<XCN> ExecutingPhysicianId { get; }

        /// <summary>
        /// PSL-30: Responsible Physician ID
        /// </summary>
        Value<XCN> ResponsiblePhysicianId { get; }

        /// <summary>
        /// PSL-31: Role Executing Physician
        /// </summary>
        Value<CWE> RoleExecutingPhysician { get; }

        /// <summary>
        /// PSL-32: Medical Role Executing Physician
        /// </summary>
        Value<CWE> MedicalRoleExecutingPhysician { get; }

        /// <summary>
        /// PSL-33: Side of body
        /// </summary>
        Value<CWE> SideOfBody { get; }

        /// <summary>
        /// PSL-34: Number of TP's PP
        /// </summary>
        Value<decimal> NumberOfTPSPP { get; }

        /// <summary>
        /// PSL-35: TP-Value PP
        /// </summary>
        Value<CP> TPValuePP { get; }

        /// <summary>
        /// PSL-36: Internal Scaling Factor PP
        /// </summary>
        Value<decimal> InternalScalingFactorPP { get; }

        /// <summary>
        /// PSL-37: External Scaling Factor PP
        /// </summary>
        Value<decimal> ExternalScalingFactorPP { get; }

        /// <summary>
        /// PSL-38: Amount PP
        /// </summary>
        Value<CP> AmountPP { get; }

        /// <summary>
        /// PSL-39: Number of TP's Technical Part
        /// </summary>
        Value<decimal> NumberOfTPSTechnicalPart { get; }

        /// <summary>
        /// PSL-40: TP-Value Technical Part
        /// </summary>
        Value<CP> TPValueTechnicalPart { get; }

        /// <summary>
        /// PSL-41: Internal Scaling Factor Technical Part
        /// </summary>
        Value<decimal> InternalScalingFactorTechnicalPart { get; }

        /// <summary>
        /// PSL-42: External Scaling Factor Technical Part
        /// </summary>
        Value<decimal> ExternalScalingFactorTechnicalPart { get; }

        /// <summary>
        /// PSL-43: Amount Technical Part
        /// </summary>
        Value<CP> AmountTechnicalPart { get; }

        /// <summary>
        /// PSL-44: Total Amount Professional Part + Technical Part
        /// </summary>
        Value<CP> TotalAmountProfessionalPartTechnicalPart { get; }

        /// <summary>
        /// PSL-45: VAT-Rate
        /// </summary>
        Value<decimal> VATRate { get; }

        /// <summary>
        /// PSL-46: Main-Service
        /// </summary>
        Value<string> MainService { get; }

        /// <summary>
        /// PSL-47: Validation
        /// </summary>
        Value<string> Validation { get; }

        /// <summary>
        /// PSL-48: Comment
        /// </summary>
        Value<string> Comment { get; }
    }
}