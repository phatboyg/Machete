namespace Machete.HL7
{
    public interface HL7Component :
        HL7Entity
    {
        Value<bool> IsEmpty { get; }
        ValueList<string> Fields { get; }
    }
}