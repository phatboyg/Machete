namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2000D_277ACKMap :
        X12LayoutMap<L2000D_277ACK, X12Entity>
    {
        public L2000D_277ACKMap()
        {
            Id = "2000D";
            Name = "Patient Level";
            
            Segment(x => x.PatientLevel, 0);
            Layout(x => x.PatientName, 1);
            Layout(x => x.ProviderOfServiceInformationTraceIdentifier, 2);
        }
    }
}