namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2100_997ACKMap :
        X12LayoutMap<Loop2100_997ACK, X12Entity>
    {
        public Loop2100_997ACKMap()
        {
            Id = "Loop_2100_997_ACK";
            Name = "Error Identification";
            
            Segment(x => x.ErrorIdentification, 0);
            Segment(x => x.DateElementNote, 1);
        }
    }
}