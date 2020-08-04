namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class I990Map :
        X12LayoutMap<I990, X12Entity>
    {
        public I990Map()
        {
            Id = "I990";
            Name = "990 Response to a Load Tender";

            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transaction, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}