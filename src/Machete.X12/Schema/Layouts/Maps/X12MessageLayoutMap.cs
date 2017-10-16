namespace Machete.X12.Schema.Layouts.Maps
{
    using Configuration;


    public class X12MessageLayoutMap :
        X12LayoutMap<X12MessageLayout, X12Entity>
    {
        public X12MessageLayoutMap()
        {
            Segment(x => x.ISA, 0, x => x.IsRequired());
            Segment(x => x.GS, 1, x => x.IsRequired());
            Segment(x => x.TransactionSetHeader, 2, x => x.IsRequired());
        }
    }
}