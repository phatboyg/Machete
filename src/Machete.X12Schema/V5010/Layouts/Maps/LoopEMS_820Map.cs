namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopEMS_820Map :
        X12LayoutMap<LoopEMS_820, X12Entity>
    {
        public LoopEMS_820Map()
        {
            Id = "Loop_EMS_820";
            Name = "Loop EMS";
            
            Segment(x => x.EmploymentPosition, 0);
            Segment(x => x.Attendance, 1);
            Segment(x => x.Income, 2);
            Segment(x => x.PayrollDeduction, 3);
        }
    }
}