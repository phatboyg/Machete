namespace Machete.X12
{
    public interface X12Component :
        X12Entity
    {
        Value<bool> IsEmpty { get; }
        ValueList<string> Fields { get; }
    }
}