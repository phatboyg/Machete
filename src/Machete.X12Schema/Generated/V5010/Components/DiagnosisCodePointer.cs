namespace Machete.X12Schema.V5010
{
    using X12;


    public interface DiagnosisCodePointer :
        X12Component
    {
        Value<string> DiagnosisCodePointer1 { get; }
        
        Value<string> DiagnosisCodePointer2 { get; }
        
        Value<string> DiagnosisCodePointer3 { get; }
        
        Value<string> DiagnosisCodePointer4 { get; }
    }
}