namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class T861Map :
        X12LayoutMap<T861, X12Entity>
    {
        public T861Map()
        {
            Id = "T861";
            Name = "861 Receiving Advice/Acceptance Certificate";
            
            Segment(x => x.FunctionalGroupHeader, 0);
            Segment(x => x.TransactionSetHeader, 1);
            Segment(x => x.BeginningReceivingAdviceOrAcceptanceCertificate, 2);
            Segment(x => x.Currency, 3);
            Segment(x => x.ReferenceInformation, 4);
            Segment(x => x.AdministrativeCommunicationsContact, 5);
            Segment(x => x.DateOrTimeReference, 6);
            Segment(x => x.PurchaseOrderReference, 7);
            Segment(x => x.CarrierDetailsQuantityAndWeight, 8);
            Segment(x => x.CarrierDetailsRoutingSequenceOrTransitTime, 9);
            Segment(x => x.CarrierDetailsEquipment, 10);
            Segment(x => x.CarrierDetailsSpecialHandlingOrHazardousMaterial, 11);
            Segment(x => x.Measurements, 12);
            Layout(x => x.LoopN1, 13);
            Layout(x => x.LoopLM, 14);
            Layout(x => x.LoopFA1, 15);
            Layout(x => x.LoopRCD, 16);
            Segment(x => x.TransactionTotals, 17);
            Segment(x => x.TransactionSetTrailer, 18);
            Segment(x => x.FunctionalGroupTrailer, 19);
        }
    }
}