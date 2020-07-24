namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopV1Map :
        X12LayoutMap<LoopV1, X12Entity>
    {
        public LoopV1Map()
        {
            Id = "Loop_V1";
            Name = "Loop V1";
            
            Segment(x => x.VesselIdentification, 0);
            Segment(x => x.PortOrTerminal, 1);
            Segment(x => x.MessageText, 2);
        }
    }
}