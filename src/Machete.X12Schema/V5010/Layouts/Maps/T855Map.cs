namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class T855Map :
        X12LayoutMap<T855, X12Entity>
    {
        public T855Map()
        {
            Id = "T855";
            Name = "855 Purchase Order Acknowledgement";
            
            Segment(x => x.FunctionalGroupHeader, 0);
            Segment(x => x.TransactionSetHeader, 1);
            Segment(x => x.BeginningPurchaseOrderAcknowledgement, 2);
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
            Segment(x => x.LeadTime, 16);
            Segment(x => x.ItemIdentification, 17);
            Segment(x => x.ServiceCharacteristicIdentification, 18);
            Segment(x => x.ProductOrItemDescription, 19);
            Segment(x => x.Measurements, 20);
            Segment(x => x.Paperwork, 21);
            Segment(x => x.MarkingPackagingOrLoading, 22);
            Segment(x => x.CarrierDetailsQuantityAndWeight, 23);
            Segment(x => x.CarrierDetailsRoutingSequenceOrTransitTime, 24);
            Segment(x => x.CarrierDetailsEquipment, 25);
            Segment(x => x.CarrierDetailsSpecialHandlingOrHazardousMaterial, 26);
            Segment(x => x.MarksAndNumbersInformation, 27);
            Segment(x => x.TaxInformation, 28);
            Segment(x => x.RestrictionsOrConditions, 29);
            Layout(x => x.LoopN9, 30);
            Layout(x => x.LoopN1, 31);
            Layout(x => x.LoopADV, 32);
            Layout(x => x.LoopPO1, 33);
            Layout(x => x.LoopCTT, 34);
            Segment(x => x.TransactionSetTrailer, 35);
            Segment(x => x.FunctionalGroupTrailer, 36);
        }
    }
}