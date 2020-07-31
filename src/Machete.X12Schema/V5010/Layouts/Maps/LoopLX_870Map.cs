namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopLX_870Map :
        X12LayoutMap<LoopLX_870, X12Entity>
    {
        public LoopLX_870Map()
        {
            Id = "Loop_LX_870";
            Name = "Loop LX";
            
            Segment(x => x.TransactionSetLineNumber, 0);
            Segment(x => x.ReferenceInformation, 1);
            Segment(x => x.PartyIdentification, 2);
            Segment(x => x.DateOrTimeReference, 3);
            Layout(x => x.LoopLM, 4);
        }
    }
}