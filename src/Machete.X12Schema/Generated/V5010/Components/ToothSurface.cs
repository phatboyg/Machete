namespace Machete.X12Schema.V5010.Components
{
    using X12;


    public interface ToothSurface :
        X12Component
    {
        Value<string> ToothSurfaceCode1 { get; }
        
        Value<string> ToothSurfaceCode2 { get; }
        
        Value<string> ToothSurfaceCode3 { get; }
        
        Value<string> ToothSurfaceCode4 { get; }
        
        Value<string> ToothSurfaceCode5 { get; }
    }
}