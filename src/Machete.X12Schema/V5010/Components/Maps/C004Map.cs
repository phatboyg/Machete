namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class C004Map :
        X12ComponentMap<C004, X12Entity>
    {
        public C004Map()
        {
            Value(x => x.DiagnosisCodePointer1, 0, x => x.MinLength(1).MaxLength(2).IsRequired());
            Value(x => x.DiagnosisCodePointer2, 1, x => x.MinLength(1).MaxLength(2));
            Value(x => x.DiagnosisCodePointer3, 2, x => x.MinLength(1).MaxLength(2));
            Value(x => x.DiagnosisCodePointer4, 3, x => x.MinLength(1).MaxLength(2));
        }
    }
}