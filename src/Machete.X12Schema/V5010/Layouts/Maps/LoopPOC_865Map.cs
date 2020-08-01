namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopPOC_865Map :
        X12LayoutMap<LoopPOC_865, X12Entity>
    {
        public LoopPOC_865Map()
        {
            Id = "Loop_POC_865";
            Name = "Loop POC";
            
            Segment(x => x.LineItemChange, 0);
            Segment(x => x.ItemIdentification, 1);
            Segment(x => x.ServiceCharacteristicIdentification, 2);
            Segment(x => x.Currency, 3);
            Segment(x => x.AdditionalItemInformation, 4);
            Segment(x => x.PricingInformation, 5);
            Segment(x => x.PeriodAmount, 6);
            Segment(x => x.Measurements, 7);
            Layout(x => x.LoopPID, 8);
            Segment(x => x.Paperwork, 9);
            Segment(x => x.MarkingPackagingOrLoading, 10);
            Segment(x => x.ItemPhysicalDetails, 11);
            Segment(x => x.ReferenceInformation, 12);
            Segment(x => x.AdministrativeCommunicationsContact, 13);
            Layout(x => x.LoopSAC, 14);
            Segment(x => x.ConditionsOfSale, 15);
            Segment(x => x.SalesRequirements, 16);
            Segment(x => x.TermsOfSale, 17);
            Segment(x => x.DiscountDetail, 18);
            Segment(x => x.InstallmentInformation, 19);
            Segment(x => x.TaxReference, 20);
            Segment(x => x.FreeOnBoardRelatedInstructions, 21);
            Segment(x => x.DestinationQuantity, 22);
            Segment(x => x.DateOrTimeReference, 23);
            Segment(x => x.CarrierDetailsQuantityAndWeight, 24);
            Segment(x => x.CarrierDetailsRoutingSequenceOrTransitTime, 25);
            Segment(x => x.CarrierDetailsEquipment, 26);
            Segment(x => x.CarrierDetailsSpecialHandlingOrHazardousMaterial, 27);
            Segment(x => x.TaxInformation, 28);
            Segment(x => x.PercentAmounts, 29);
            Layout(x => x.LoopACK, 30);
            Segment(x => x.MarksAndNumbersInformation, 31);
            Segment(x => x.SpecificationIdentifier, 32);
            Segment(x => x.Text, 33);
            Segment(x => x.RestrictionsOrConditions, 34);
            Layout(x => x.LoopLM, 35);
            Layout(x => x.LoopAMT, 36);
            Layout(x => x.LoopQTY, 37);
            Layout(x => x.LoopSCH, 38);
            Layout(x => x.LoopLDT, 39);
            Layout(x => x.LoopN9, 40);
            Layout(x => x.LoopN1, 41);
            Layout(x => x.LoopSLN, 42);
            Layout(x => x.LoopPD, 43);
        }
    }
}