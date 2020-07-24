namespace Machete.X12Schema.V5010
{
    using X12;
    using X12.Configuration;


    public class LoopAIN_820Map :
        X12LayoutMap<LoopAIN_820, X12Entity>
    {
        public LoopAIN_820Map()
        {
            Id = "Loop_AIN_820";
            Name = "Loop AIN";
            
            Segment(x => x.Income, 0);
            Segment(x => x.Quantity, 1);
            Segment(x => x.DateOrTimePeriod, 2);
        }
    }
}