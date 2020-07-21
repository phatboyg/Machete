namespace Machete.X12Schema.V5010.Layouts.Maps
{
    using X12;
    using X12.Configuration;


    public class T270Map :
        X12LayoutMap<T270, X12Entity>
    {
        public T270Map()
        {
            Id = "270";
            Name = "270 Transaction";
            
            Segment(x => x.FunctionalGroupHeader, 0);
            Segment(x => x.TransactionSetHeader, 1, x => x.IsRequired());
            Segment(x => x.BeginningOfHierarchicalTransaction, 2, x => x.IsRequired());
            Layout(x => x.Loop2000A, 3);
            Layout(x => x.Loop2000B, 4);
            Layout(x => x.Loop2000C, 5);
            Layout(x => x.Loop2000D, 6);
            Segment(x => x.TransactionSetTrailer, 7, x => x.IsRequired());
            Segment(x => x.FunctionalGroupTrailer, 8);
        }
    }
}