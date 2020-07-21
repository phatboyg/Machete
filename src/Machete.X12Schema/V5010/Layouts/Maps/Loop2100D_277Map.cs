namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2100D_277Map :
        X12LayoutMap<Loop2100D_277, X12Entity>
    {
        public Loop2100D_277Map()
        {
            Id = "Loop_2100D_277";
            Name = "Patient Name";
            
            Segment(x => x.Patient, 0);
        }
    }
}