namespace Machete.X12Schema.V5010.Layouts.Maps
{
    using X12;
    using X12.Configuration;


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