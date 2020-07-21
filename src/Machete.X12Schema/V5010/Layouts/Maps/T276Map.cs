namespace Machete.X12Schema.V5010.Layouts.Maps
{
    using X12;
    using X12.Configuration;


    public class T276Map :
        X12LayoutMap<T276, X12Entity>
    {
        public T276Map()
        {
            Id = "276T";
            Name = "276 Transaction";
            
            Segment(x => x.FunctionalGroupHeader, 0);
            Segment(x => x.TransactionSetHeader, 1, x => x.IsRequired());
            Segment(x => x.BeginningOfHierarchicalTransaction, 2, x => x.IsRequired());
            Layout(x => x.Loop2000A, 3);
            Layout(x => x.Loop2000B, 4);
            Layout(x => x.Loop2000C, 5);
            Layout(x => x.Loop2000D, 6);
            Layout(x => x.Loop2000E, 7);
            Segment(x => x.TransactionSetTrailer, 8, x => x.IsRequired());
            Segment(x => x.FunctionalGroupTrailer, 9);
        }
    }
}