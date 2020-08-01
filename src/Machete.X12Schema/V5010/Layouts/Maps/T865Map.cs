namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class T865Map :
        X12LayoutMap<T865, X12Entity>
    {
        public T865Map()
        {
            Id = "T865";
            Name = "865 Purchase Order Change Acknowledgement/Request - Seller Initiated";
            
            Segment(x => x.FunctionalGroupHeader, 0);
            Segment(x => x.TransactionSetHeader, 1);
            Segment(x => x.BeginningPurchaseOrderChange, 2);
            Segment(x => x.Currency, 3);
            Segment(x => x.ReferenceInformation, 4);
            Segment(x => x.AdministrativeCommunicationsContact, 5);
            Segment(x => x.TaxReference, 6);
            Segment(x => x.FreeOnBoardRelatedInstructions, 7);
            Segment(x => x.PricingInformation, 8);
            Segment(x => x.PeriodAmount, 9);
            Segment(x => x.SalesRequirements, 10);
            Layout(x => x.LoopSAC, 11);
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
            Segment(x => x.PercentAmounts, 26);
            Segment(x => x.MarksAndNumbersInformation, 27);
            Segment(x => x.TaxInformation, 28);
            Segment(x => x.RestrictionsOrConditions, 29);
            Segment(x => x.MaintenanceType, 30);
            Layout(x => x.LoopLDT, 31);
            Layout(x => x.LoopN9, 32);
            Layout(x => x.LoopN1, 33);
            Layout(x => x.LoopAMT, 34);
            Layout(x => x.LoopADV, 35);
            Layout(x => x.LoopLM, 36);
            Layout(x => x.LoopPOC, 37);
            Layout(x => x.LoopCTT, 38);
            Segment(x => x.TransactionSetTrailer, 39);
            Segment(x => x.FunctionalGroupTrailer, 40);
        }
    }
}