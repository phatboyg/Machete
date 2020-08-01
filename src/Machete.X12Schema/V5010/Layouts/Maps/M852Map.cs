namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class M852Map :
        X12LayoutMap<M852, X12Entity>
    {
        public M852Map()
        {
            Id = "M852";
            Name = "852 Product Activity Data";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transaction, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}