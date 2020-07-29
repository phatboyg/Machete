namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class FA999Map :
        X12LayoutMap<FA999, X12Entity>
    {
        public FA999Map()
        {
            Id = "FA999";
            Name = "999 Acknowledgement";
            
            Segment(x => x.InterchangeControlHeader, 0, x => x.IsRequired());
            Layout(x => x.Transactions, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}