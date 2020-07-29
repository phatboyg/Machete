namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopACK_855Map :
        X12LayoutMap<LoopACK_855, X12Entity>
    {
        public LoopACK_855Map()
        {
            Id = "Loop_ACK_855";
            Name = "Loop ACK";
            
            Segment(x => x.LineItemAcknowledgement, 0);
            Segment(x => x.DateOrTimeReference, 1);
        }
    }
}