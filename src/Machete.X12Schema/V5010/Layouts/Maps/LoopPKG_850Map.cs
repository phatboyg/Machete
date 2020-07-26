namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopPKG_850Map :
        X12LayoutMap<LoopPKG_850, X12Entity>
    {
        public LoopPKG_850Map()
        {
            Id = "Loop_PKG_850";
            Name = "Loop PKG";
            
            Segment(x => x.MarkingPackagingOrLoading, 0);
            Segment(x => x.Measurements, 1);
        }
    }
}