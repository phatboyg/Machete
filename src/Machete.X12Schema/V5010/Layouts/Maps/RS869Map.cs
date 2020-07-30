namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class RS869Map :
        X12LayoutMap<RS869, X12Entity>
    {
        public RS869Map()
        {
            Id = "RS869";
            Name = "869 Order Status Inquiry";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transaction, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}