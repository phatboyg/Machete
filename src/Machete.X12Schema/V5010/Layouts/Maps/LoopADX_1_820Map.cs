namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopADX_1_820Map :
        X12LayoutMap<LoopADX_1_820, X12Entity>
    {
        public LoopADX_1_820Map()
        {
            Id = "Loop_ADX_1_820";
            Name = "Loop ADX";
            
            Segment(x => x.Adjustment, 0);
            Segment(x => x.NoteOrSpecialInstruction, 1);
            Segment(x => x.AdministrativeCommunicationsContact, 2);
            Segment(x => x.DateOrTimeReference, 3);
            Layout(x => x.LoopREF, 4);
            Layout(x => x.LoopIT1, 5);
        }
    }
}