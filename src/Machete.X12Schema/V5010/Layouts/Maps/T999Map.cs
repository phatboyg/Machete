namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class T999Map :
        X12LayoutMap<T999, X12Entity>
    {
        public T999Map()
        {
            Id = "999";
            Name = "999 Transaction";
            
            Segment(x => x.FunctionalGroupHeader, 0, x => x.IsRequired());
            Segment(x => x.TransactionSetHeader, 1);
            Segment(x => x.FunctionalGroupResponseHeader, 2);
            Layout(x => x.Loop2000, 3);
            Segment(x => x.FunctionalGroupResponseTrailer, 4, x => x.IsRequired());
            Segment(x => x.TransactionSetTrailer, 5, x => x.IsRequired());
            Segment(x => x.FunctionalGroupTrailer, 6);
        }
    }
}