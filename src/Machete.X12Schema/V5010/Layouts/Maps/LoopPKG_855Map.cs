namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopPKG_855Map :
        X12LayoutMap<LoopPKG_855, X12Entity>
    {
        public LoopPKG_855Map()
        {
            Id = "Loop_PKG_855";
            Name = "Loop PKG";
            
            Segment(x => x.MarkingPackagingOrLoading, 0);
            Segment(x => x.Measurements, 1);
        }
    }
}