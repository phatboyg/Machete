namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2100D_277ACKMap :
        X12LayoutMap<Loop2100D_277ACK, X12Entity>
    {
        public Loop2100D_277ACKMap()
        {
            Id = "Loop_2100D_277_ACK";
            Name = "Patient Name";
            
            Segment(x => x.Patient, 0);
        }
    }
}