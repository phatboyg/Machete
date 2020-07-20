namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class C030Map :
        X12ComponentMap<C030, X12Entity>
    {
        public C030Map()
        {
            Value(x => x.ElementPositionInSegment, 0, x => x.MinLength(1).MaxLength(2).IsRequired());
            Value(x => x.ComponentDataElementPositionInComposite, 1, x => x.MinLength(1).MaxLength(2));
            Value(x => x.RepeatingDataElementPosition, 2, x => x.MinLength(1).MaxLength(4));
        }
    }
}