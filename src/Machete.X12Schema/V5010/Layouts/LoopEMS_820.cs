namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopEMS_820 :
        X12Layout
    {
        SegmentList<EMS> EmploymentPosition { get; }
        
        SegmentList<ATN> Attendance { get; }
        
        SegmentList<AIN> Income { get; }
        
        SegmentList<PYD> PayrollDeduction{ get; }
    }
}