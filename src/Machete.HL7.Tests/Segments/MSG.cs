namespace Machete.HL7.Tests.Segments
{
    public interface MSG :
        HL7Component
    {
        Value<string> MessageCode { get; }
        Value<string> TriggerEvent { get; }
        Value<string> MessageStructure { get; }
    }
}