namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopMAN_846Map :
        X12LayoutMap<LoopMAN_846, X12Entity>
    {
        public LoopMAN_846Map()
        {
            Id = "Loop_MAN_846";
            Name = "Loop MAN";
            
            Segment(x => x.MarksAndNumberInformation, 0);

            Segment(x => x.Measurements, 1);
        }
    }
}