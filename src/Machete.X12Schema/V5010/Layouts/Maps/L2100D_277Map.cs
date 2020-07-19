namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2100D_277Map :
        X12LayoutMap<L2100D_277, X12Entity>
    {
        public L2100D_277Map()
        {
            Id = "2100D";
            Name = "Patient Name";
            
            Segment(x => x.PatientName, 0, x => x.IsRequired());
        }
    }
}