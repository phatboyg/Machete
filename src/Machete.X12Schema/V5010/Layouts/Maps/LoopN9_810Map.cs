namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopN9_810Map :
        X12LayoutMap<LoopN9_810, X12Entity>
    {
        public LoopN9_810Map()
        {
            Id = "Loop_N9_810";
            Name = "Loop N9";
            
            Segment(x => x.ExtendedReferenceInformation, 0);
            Segment(x => x.MessageText, 1);
        }
    }
}