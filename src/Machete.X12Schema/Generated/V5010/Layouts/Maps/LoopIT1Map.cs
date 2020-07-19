namespace Machete.X12Schema.V5010.Layouts.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopIT1Map :
        X12LayoutMap<LoopIT1, X12Entity>
    {
        public LoopIT1Map()
        {
            Id = "Loop_IT1";
            Name = "Loop IT1";
            
            Segment(x => x.BaselineItemData, 0);
            Segment(x => x.ConditionsIndicator, 1);
            Segment(x => x.QuantityInformation, 2);
            Segment(x => x.Currency, 3);
            Segment(x => x.AdditionalItemData, 4);
            Segment(x => x.TaxInformation, 5);
            Segment(x => x.PricingInformation, 6);
            Segment(x => x.PeriodAmount, 7);
            Segment(x => x.Measurements, 8);
            Layout(x => x.LoopPID, 9);
            Segment(x => x.Paperwork, 10);
            Segment(x => x.MarkingPackagingOrLoadingRequirements, 11);
            Segment(x => x.ItemPhysicalDetails, 12);
            Segment(x => x.TermsOfSale, 13);
            Segment(x => x.ReferenceInformation, 14);
            Segment(x => x.YesNoQuestion, 15);
            Segment(x => x.AdministrativeCommunicationsContact, 16);
            Segment(x => x.DestinationQuantity, 17);
            Segment(x => x.DateTimeReference, 18);
            Segment(x => x.CarrierDetails, 19);
            Segment(x => x.TariffReference, 20);
            Segment(x => x.RequestedServiceSchedule, 21);
            Layout(x => x.LoopSAC, 22);
            Layout(x => x.LoopSLN, 23);
            Layout(x => x.LoopN1, 24);
            Layout(x => x.LoopLM, 25);
            Layout(x => x.LoopV1, 26);
            Layout(x => x.LoopFA1, 27);
        }
    }
}