namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class T850Map :
        X12LayoutMap<T850, X12Entity>
    {
        public T850Map()
        {
            Id = "T850";
            Name = "850 Purchase Order";
            
            Segment(x => x.FunctionalGroupHeader, 0);
            Segment(x => x.TransactionSetHeader, 1);
            Segment(x => x.BeginningPurchaseOrder, 2);
            Segment(x => x.Currency, 3);
            Segment(x => x.ReferenceInformation, 4);
            Segment(x => x.AdministrativeCommunicationsContact, 5);
            Segment(x => x.TaxReference, 6);
            Segment(x => x.FreeOnBoardRelatedInstructions, 7);
            Segment(x => x.PricingInformation, 8);
            Segment(x => x.PeriodAmount, 9);
            Segment(x => x.SalesRequirements, 10);
            Segment(x => x.Commodity, 11);
            Segment(x => x.TermsOfSale, 12);
            Segment(x => x.DiscountDetail, 13);
            Segment(x => x.InstallmentInformation, 14);
            Segment(x => x.DateOrTimeReference, 15);
            Segment(x => x.ItemIdentification, 16);
            Segment(x => x.ServiceCharacteristicIdentification, 17);
            Segment(x => x.ProductOrItemDescription, 18);
            Segment(x => x.Measurements, 19);
            Segment(x => x.Paperwork, 20);
            Segment(x => x.MarkingPackagingOrLoading, 21);
            Segment(x => x.CarrierDetailsQuantityAndWeight, 22);
            Segment(x => x.CarrierDetailsRoutingSequenceOrTransitTime, 23);
            Segment(x => x.CarrierDetailsEquipment, 24);
            Segment(x => x.CarrierDetailsSpecialHandlingOrHazardousMaterial, 25);
            Segment(x => x.MarksAndNumbersInformation, 26);
            Segment(x => x.PercentAmounts, 27);
            Segment(x => x.RestrictionsOrConditions, 28);
            Segment(x => x.TaxInformation, 29);
            Layout(x => x.LoopLDT, 30);
            Layout(x => x.LoopAMT, 31);
            Layout(x => x.LoopN9, 32);
            Layout(x => x.LoopN1, 33);
            Layout(x => x.LoopLM, 34);
            Layout(x => x.LoopSPI, 35);
            Layout(x => x.LoopADV, 36);
            Layout(x => x.LoopPO1, 37);
            Layout(x => x.LoopCTT, 38);
            Segment(x => x.TransactionSetTrailer, 39);
            Segment(x => x.FunctionalGroupTrailer, 40);
        }
    }
}