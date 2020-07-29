namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class PY829Map :
        X12LayoutMap<PY829, X12Entity>
    {
        public PY829Map()
        {
            Id = "PY829";
            Name = "828 Debit Authorization";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transaction, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}