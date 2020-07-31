namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class C997Map :
        X12LayoutMap<C997, X12Entity>
    {
        public C997Map()
        {
            Id = "C997";
            Name = "997 Functional Acknowledgement";
            
            Segment(x => x.InterchangeControlHeader, 0, x => x.IsRequired());
            Layout(x => x.Transactions, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}