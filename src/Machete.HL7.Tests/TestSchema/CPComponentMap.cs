namespace Machete.HL7.Tests.TestSchema
{
    public class CPComponentMap :
        HL7ComponentMap<CPComponent, HL7Component>
    {
        public CPComponentMap()
        {
            Entity(x => x.Price, 0);
            Value(x => x.PriceType, 1);
            Value(x => x.FromValue, 2);
            Value(x => x.ToValue, 3);
            Entity(x => x.RangeUnits, 4);
            Value(x => x.RangeType, 5);
        }
    }
}