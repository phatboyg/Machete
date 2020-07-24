namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class T997Map :
        X12LayoutMap<T997, X12Entity>
    {
        public T997Map()
        {
            Id = "997";
            Name = "997 Transaction";
            
            Segment(x => x.FunctionalGroupHeader, 0);
            Segment(x => x.TransactionSetHeader, 1);
            Segment(x => x.FunctionalGroupResponseHeader, 2);
            Layout(x => x.Loop2000, 3);
            Segment(x => x.FunctionalGroupResponseTrailer, 4);
            Segment(x => x.TransactionSetTrailer, 5);
            Segment(x => x.FunctionalGroupTrailer, 6);
        }
    }
}