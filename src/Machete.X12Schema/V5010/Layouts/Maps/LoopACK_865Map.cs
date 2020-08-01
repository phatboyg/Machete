namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopACK_865Map :
        X12LayoutMap<LoopACK_865, X12Entity>
    {
        public LoopACK_865Map()
        {
            Id = "Loop_ACK_865";
            Name = "Loop ACK";
            
            Segment(x => x.LineItemAcknowledgement, 0);
            Segment(x => x.DateOrTimeReference, 1);
        }
    }
}