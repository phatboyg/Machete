namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopCLD_856Map :
        X12LayoutMap<LoopCLD_856, X12Entity>
    {
        public LoopCLD_856Map()
        {
            Id = "Loop_CLD_856";
            Name = "Loop CLD";
            
            Segment(x => x.LoadDetail, 0);
            Segment(x => x.ReferenceIdentification, 1);
            Segment(x => x.DateOrTimeOrPeriod, 2);
        }
    }
}