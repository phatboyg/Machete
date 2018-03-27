namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2100A_277ACKMap :
        X12LayoutMap<L2100A_277ACK, X12Entity>
    {
        public L2100A_277ACKMap()
        {
            Id = "2100A";
            Name = "Information Source Name";
            
            Segment(x => x.InformationSourceName, 0, x => x.IsRequired());
        }
    }
}