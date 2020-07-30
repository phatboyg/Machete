namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopLIN_846Map :
        X12LayoutMap<LoopLIN_846, X12Entity>
    {
        public LoopLIN_846Map()
        {
            Id = "Loop_LIN_846";
            Name = "Loop LIN";  
            
            Segment(x => x.ItemIdentification, 0);
            Segment(x => x.ItemDescription, 1);
            Segment(x => x.Measurements, 2);
            Segment(x => x.MarkingPackagingLoading, 3);
            Segment(x => x.DateTimeReference, 4);
            Segment(x => x.PricingInformation, 5);
            Segment(x => x.Currency, 6);
            Segment(x => x.ServiceAllowanceOrChargeInformation, 7);
            Segment(x => x.ReferenceInformation, 8);
            Segment(x => x.AdministrativeCommunicationsContact, 9);
            Segment(x => x.DestinationQuantity, 10);
            Segment(x => x.MarksAndNumbersInformation, 11);
            Segment(x => x.UnitDetail, 12);
            Segment(x => x.ContractSummary, 13);
            Segment(x => x.DemandDetail, 14);
            Segment(x => x.MaintenanceType, 15);
            Segment(x => x.PercentAmounts, 16);
            Segment(x => x.LeadTime, 17);
            Layout(x => x.LoopLM, 18);
            Layout(x => x.LoopSLN, 19);
            Layout(x => x.LoopQty, 20);
            Layout(x => x.LoopN1, 21);
        }
    }
}