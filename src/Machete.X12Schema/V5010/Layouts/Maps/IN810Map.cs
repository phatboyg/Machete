namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class IN810Map :
        X12LayoutMap<IN810, X12Entity>
    {
        public IN810Map()
        {
            Id = "IN810";
            Name = "810 Invoice";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transaction, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}