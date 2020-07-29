namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class SH856Map :
        X12LayoutMap<SH856, X12Entity>
    {
        public SH856Map()
        {
            Id = "SH856";
            Name = "856 Ship Notice/Manifest";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transaction, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}