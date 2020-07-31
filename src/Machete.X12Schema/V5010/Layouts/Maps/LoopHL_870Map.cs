namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopHL_870Map :
        X12LayoutMap<LoopHL_870, X12Entity>
    {
        public LoopHL_870Map()
        {
            Id = "Loop_HL_870";
            Name = "Loop HL";
            
            Segment(x => x.HierarchicalLevel, 0);
            Segment(x => x.PurchaseOrderReference, 1);
            Layout(x => x.LoopISR, 2);
            Segment(x => x.AdministrativeCommunicationsContact, 3);
            Segment(x => x.DateOrTimeReference, 4);
            Segment(x => x.ContactSummary, 5);
            Layout(x => x.LoopREF, 6);
            Layout(x => x.LoopN1, 7);
            Layout(x => x.LoopLM, 8);
            Layout(x => x.LoopPO1, 9);
        }
    }
}