namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopPOC_860Map :
        X12LayoutMap<LoopPOC_860, X12Entity>
    {
        public LoopPOC_860Map()
        {
            Id = "Loop_POC_860";
            Name = "Loop POC";
            
            Segment(x => x.LineItemChange, 0);
            Segment(x => x.ItemIdentification, 1);
            Segment(x => x.ServiceCharacteristicIdentification, 2);
            Segment(x => x.Currency, 3);
            Segment(x => x.ContractInformation, 4);
            Segment(x => x.AdditionalItemInformation, 5);
            Segment(x => x.PricingInformation, 6);
            Segment(x => x.PeriodAmount, 7);
            Segment(x => x.Measurements, 8);
            Layout(x => x.LoopPID, 9);
            Segment(x => x.Paperwork, 10);
            Segment(x => x.MarkingPackagingOrLoading, 11);
            Segment(x => x.ItemPhysicalDetails, 12);
            Segment(x => x.ReferenceInformation, 13);
            Segment(x => x.AdministrativeCommunicationsContact, 14);
            Layout(x => x.LoopSAC, 15);
            Segment(x => x.ConditionsOfSale, 16);
            Segment(x => x.SalesRequirements, 17);
            Segment(x => x.TermsOfSale, 18);
            Segment(x => x.DiscountDetail, 19);
            Segment(x => x.InstallmentInformation, 20);
            Segment(x => x.TaxReference, 21);
            Segment(x => x.FreeOnBoardRelatedInstructions, 22);
            Segment(x => x.DestinationQuantity, 23);
            Segment(x => x.DateOrTimeReference, 24);
            Segment(x => x.CarrierDetailsQuantityAndWeight, 25);
            Segment(x => x.CarrierDetailsRoutingSequenceOrTransitTime, 26);
            Segment(x => x.CarrierDetailsEquipment, 27);
            Segment(x => x.CarrierDetailsSpecialHandlingOrHazardousMaterial, 28);
            Segment(x => x.MarksAndNumbersInformation, 29);
            Segment(x => x.PercentAmounts, 30);
            Segment(x => x.Commodity, 31);
            Segment(x => x.RestrictionsOrConditions, 32);
            Segment(x => x.TaxInformation, 33);
            Segment(x => x.SpecificationIdentifier, 34);
            Segment(x => x.Text, 35);
            Layout(x => x.LoopQTY, 36);
            Layout(x => x.LoopSCH, 37);
            Layout(x => x.LoopN9, 38);
            Segment(x => x.LoopHeader, 39);
            Layout(x => x.LoopSLN, 40);
            Layout(x => x.LoopAMT, 4);
            Layout(x => x.LoopLM, 4);
        }
    }
}