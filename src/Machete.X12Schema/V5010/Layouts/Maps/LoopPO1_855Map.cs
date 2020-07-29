namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopPO1_855Map :
        X12LayoutMap<LoopPO1_855, X12Entity>
    {
        public LoopPO1_855Map()
        {
            Id = "Loop_PO1_855";
            Name = "Loop PO1";
            
            Segment(x => x.BaselineItemData, 0);
            Segment(x => x.ItemIdentification, 1);
            Segment(x => x.ServiceCharacteristicIdentification, 2);
            Segment(x => x.Currency, 3);
            Segment(x => x.AdditionalItemDetail, 4);
            Segment(x => x.PricingInformation, 5);
            Segment(x => x.PeriodAmount, 6);
            Segment(x => x.Measurements, 7);
            Layout(x => x.LoopPID, 8);
            Segment(x => x.Paperwork, 9);
            Segment(x => x.ItemPhysicalDetails, 10);
            Segment(x => x.ReferenceIdentification, 11);
            Segment(x => x.AdministrativeCommunicationsContact, 12);
            Layout(x => x.LoopSAC, 13);
            Segment(x => x.ConditionsOfSale, 14);
            Segment(x => x.SalesRequirements, 15);
            Segment(x => x.TermsOfSale, 16);
            Segment(x => x.DiscountDetail, 17);
            Segment(x => x.InstallmentInformation, 18);
            Segment(x => x.TaxReference, 19);
            Segment(x => x.FreeOnBoardRelatedInstructions, 20);
            Segment(x => x.DestinationQuantity, 21);
            Segment(x => x.DateOrTimeReference, 22);
            Segment(x => x.CarrierDetailsQuantityAndWeight, 23);
            Segment(x => x.CarrierDetailsRoutingSequenceOrTransitTime, 24);
            Segment(x => x.CarrierDetailsEquipment, 25);
            Segment(x => x.CarrierDetailsSpecialHandlingOrHazardousMaterial, 26);
            Layout(x => x.LoopACK, 27);
            Segment(x => x.MarksAndNumbersInformation, 28);
            Segment(x => x.MonetaryAmountInformation, 29);
            Segment(x => x.RestrictionsOrConditions, 30);
            Segment(x => x.TaxInformation, 31);
            Layout(x => x.LoopQTY, 32);
            Layout(x => x.LoopPKG, 33);
            Layout(x => x.LoopSCH, 34);
            Layout(x => x.LoopN9, 35);
            Layout(x => x.LoopN1, 36);
            Layout(x => x.LoopSLN, 37);
        }
    }
}