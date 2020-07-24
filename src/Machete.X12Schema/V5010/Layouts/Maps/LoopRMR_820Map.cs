namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopRMR_820Map :
        X12LayoutMap<LoopRMR_820, X12Entity>
    {
        public LoopRMR_820Map()
        {
            Id = "Loop_RMR_820";
            Name = "Loop RMR";
            
            Segment(x => x.RemittanceAdviceAccountsReceivableOpenItemReference, 0);
            Segment(x => x.NoteOrSpecialInstruction, 1);
            Segment(x => x.AdministrativeCommunicationsContact, 2);
            Segment(x => x.DateOrTimeReference, 3);
            Layout(x => x.LoopIT1, 4);
            Layout(x => x.LoopADX, 5);
        }
    }
}