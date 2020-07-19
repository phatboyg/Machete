// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PSL (SegmentMap) - Product/Service Line Item
    /// </summary>
    public class PSLMap :
        HL7V26SegmentMap<PSL>
    {
        public PSLMap()
        {
            Id = "PSL";

            Name = "Product/Service Line Item";

            Entity(x => x.ProviderProductServiceLineItemNumber, 1, x => x.IsRequired());
            Entity(x => x.PayerProductServiceLineItemNumber, 2);
            Value(x => x.ProductServiceLineItemSequenceNumber, 3, x => x.IsRequired());
            Entity(x => x.ProviderTrackingId, 4);
            Entity(x => x.PayerTrackingId, 5);
            Entity(x => x.ProductServiceLineItemStatus, 6, x => x.IsRequired());
            Entity(x => x.ProductServiceCode, 7, x => x.IsRequired());
            Entity(x => x.ProductServiceCodeModifier, 8);
            Value(x => x.ProductServiceCodeDescription, 9);
            Value(x => x.ProductServiceEffectiveDate, 10, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.ProductServiceExpirationDate, 11, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Entity(x => x.ProductServiceQuantity, 12);
            Entity(x => x.ProductServiceUnitCost, 13);
            Value(x => x.NumberOfItemsPerUnit, 14);
            Entity(x => x.ProductServiceGrossAmount, 15);
            Entity(x => x.ProductServiceBilledAmount, 16);
            Value(x => x.ProductServiceClarificationCodeType, 17);
            Value(x => x.ProductServiceClarificationCodeValue, 18);
            Entity(x => x.HealthDocumentReferenceIdentifier, 19);
            Value(x => x.ProcessingConsiderationCode, 20);
            Value(x => x.RestrictedDisclosureIndicator, 21, x => x.IsRequired());
            Entity(x => x.RelatedProductServiceCodeIndicator, 22);
            Entity(x => x.ProductServiceAmountForPhysician, 23);
            Value(x => x.ProductServiceCostFactor, 24);
            Entity(x => x.CostCenter, 25);
            Entity(x => x.BillingPeriod, 26);
            Value(x => x.DayWithoutBilling, 27);
            Value(x => x.SessionNo, 28);
            Entity(x => x.ExecutingPhysicianId, 29);
            Entity(x => x.ResponsiblePhysicianId, 30);
            Entity(x => x.RoleExecutingPhysician, 31);
            Entity(x => x.MedicalRoleExecutingPhysician, 32);
            Entity(x => x.SideOfBody, 33);
            Value(x => x.NumberOfTPSPP, 34);
            Entity(x => x.TPValuePP, 35);
            Value(x => x.InternalScalingFactorPP, 36);
            Value(x => x.ExternalScalingFactorPP, 37);
            Entity(x => x.AmountPP, 38);
            Value(x => x.NumberOfTPSTechnicalPart, 39);
            Entity(x => x.TPValueTechnicalPart, 40);
            Value(x => x.InternalScalingFactorTechnicalPart, 41);
            Value(x => x.ExternalScalingFactorTechnicalPart, 42);
            Entity(x => x.AmountTechnicalPart, 43);
            Entity(x => x.TotalAmountProfessionalPartTechnicalPart, 44);
            Value(x => x.VATRate, 45);
            Value(x => x.MainService, 46);
            Value(x => x.Validation, 47);
            Value(x => x.Comment, 48);
        }
    }
}