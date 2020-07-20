namespace Machete.X12Schema.V5010
{
    using X12;


    public interface TOO :
        X12Segment
    {
        Value<string> CodeListQualifierCode { get; }
        
        Value<string> ToothCode { get; }
        
        Value<C005> ToothSurface { get; }
    }
}