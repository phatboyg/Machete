namespace Machete.X12Schema.V5010
{
    using X12;


    public interface IEA :
        X12Segment
    {
        Value<int> FunctionalGroupCount { get; }
        
        Value<int> ControlNumber { get; }
    }
}