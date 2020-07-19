namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class ToothSurfaceMap :
        X12ComponentMap<ToothSurface, X12Entity>
    {
        public ToothSurfaceMap()
        {
            Value(x => x.ToothSurfaceCode1, 0, x => x.MinLength(1).MaxLength(2).IsRequired());
            Value(x => x.ToothSurfaceCode2, 1, x => x.MinLength(1).MaxLength(2));
            Value(x => x.ToothSurfaceCode3, 2, x => x.MinLength(1).MaxLength(2));
            Value(x => x.ToothSurfaceCode4, 3, x => x.MinLength(1).MaxLength(2));
            Value(x => x.ToothSurfaceCode5, 4, x => x.MinLength(1).MaxLength(2));
        }
    }
}