namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class M870Map :
        X12LayoutMap<M870, X12Entity>
    {
        public M870Map()
        {
            Id = "M870";
            Name = "870 Order Status Report";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transaction, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}