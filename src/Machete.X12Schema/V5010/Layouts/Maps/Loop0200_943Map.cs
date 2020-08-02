namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop0200_943Map :
        X12LayoutMap<Loop0200_943, X12Entity>
    {
        public Loop0200_943Map()
        {
            Id = "Loop_0200_943";
            Name = "Loop 0200";
            
            Segment(x => x.ItemDetailTotal, 0);
            Segment(x => x.LineItemDetailDescription, 1);
            Segment(x => x.ExtendedReferenceInformation, 2);
            Segment(x => x.LineItemDetailPacking, 3);
        }
    }
}