namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopPO1_850Map :
        X12LayoutMap<LoopPO1_850, X12Entity>
    {
        public LoopPO1_850Map()
        {
            Id = "Loop_PO1_850";
            Name = "Loop PO1";
            
            Segment(x => x.BaselineItemData, 0);
            Segment(x => x.ItemIdentification, 1);
            Segment(x => x.ServiceCharacteristicIdentification, 2);
            Segment(x => x.Currency, 3);
            Segment(x => x.ContractInformation, 4);
            Segment(x => x.AdditionalItemDetail, 5);
            Layout(x => x.LoopCTP, 6);
            Segment(x => x.PeriodAmount, 7);
            Segment(x => x.Measurements, 8);
            Layout(x => x.LoopPID, 9);
            Segment(x => x.Paperwork, 10);
            Segment(x => x.ItemPhysicalDetails, 11);
            Segment(x => x.ReferenceIdentification, 12);
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
            Segment(x => x.AdditionalItemData, 23);
            Segment(x => x.DateOrTimeReference, 24);
            Segment(x => x.Commodity, 25);
            Segment(x => x.CarrierDetailsQuantityAndWeight, 26);
            Segment(x => x.CarrierDetailsRoutingSequenceOrTransitTime, 27);
            Segment(x => x.CarrierDetailsEquipment, 28);
            Segment(x => x.CarrierDetailsSpecialHandlingOrHazardousMaterial, 29);
            Segment(x => x.PercentAmounts, 30);
            Segment(x => x.MarksAndNumbersInformation, 31);
            Segment(x => x.Text, 32);
            Segment(x => x.SpecificationIdentifier, 33);
            Segment(x => x.TaxInformation, 34);
            Segment(x => x.RestrictionsOrConditions, 35);
            Layout(x => x.LoopQTY, 36);
            Layout(x => x.LoopSCH, 37);
            Layout(x => x.LoopPKG, 38);
            Segment(x => x.LoopHeader, 39);
            Layout(x => x.LoopLDT, 40);
            Layout(x => x.LoopN9, 41);
            Layout(x => x.LoopN1, 42);
            Layout(x => x.LoopSLN, 43);
            Layout(x => x.LoopAMT, 44);
            Layout(x => x.LoopLM, 45);
        }
    }
}