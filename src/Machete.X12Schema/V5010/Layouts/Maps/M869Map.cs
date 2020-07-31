namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class M869Map :
        X12LayoutMap<M869, X12Entity>
    {
        public M869Map()
        {
            Id = "M869";
            Name = "869 Order Status Inquiry";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transaction, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}