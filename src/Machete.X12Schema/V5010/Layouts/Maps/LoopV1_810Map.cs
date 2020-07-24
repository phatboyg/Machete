namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopV1_810Map :
        X12LayoutMap<LoopV1_810, X12Entity>
    {
        public LoopV1_810Map()
        {
            Id = "Loop_V1_810";
            Name = "Loop V1";
            
            Segment(x => x.VesselIdentification, 0);
            Segment(x => x.PortOrTerminal, 1);
            Segment(x => x.MessageText, 2);
        }
    }
}