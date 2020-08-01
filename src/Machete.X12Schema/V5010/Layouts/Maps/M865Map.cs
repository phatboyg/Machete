namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class M865Map :
        X12LayoutMap<M865, X12Entity>
    {
        public M865Map()
        {
            Id = "M865";
            Name = "865 Purchase Order Change Acknowledgement/Request - Seller Initiated";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transaction, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}