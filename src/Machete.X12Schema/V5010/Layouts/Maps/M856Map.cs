namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class M856Map :
        X12LayoutMap<M856, X12Entity>
    {
        public M856Map()
        {
            Id = "M856";
            Name = "856 Ship Notice/Manifest";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transaction, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}