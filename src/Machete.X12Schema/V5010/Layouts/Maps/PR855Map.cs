namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class PR855Map :
        X12LayoutMap<PR855, X12Entity>
    {
        public PR855Map()
        {
            Id = "PR855";
            Name = "855 Purchase Order Acknowledgement";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transaction, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}