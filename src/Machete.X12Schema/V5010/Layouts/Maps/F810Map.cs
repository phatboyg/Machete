namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class F810Map :
        X12LayoutMap<F810, X12Entity>
    {
        public F810Map()
        {
            Id = "T810";
            Name = "T810";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transaction, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}