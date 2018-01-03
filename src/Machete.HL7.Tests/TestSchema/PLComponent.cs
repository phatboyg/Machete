namespace Machete.HL7.Tests.TestSchema
{
    public interface PLComponent :
        HL7Component
    {
        Value<string> PointOfCare { get; }
        Value<string> Room { get; }
        Value<string> Bed { get; }
        Value<HDComponent> Facility { get; }
        Value<string> LocationStatus { get; }
        Value<string> PersonLocationType { get; }
        Value<string> Building { get; }
        Value<string> Floor { get; }
        Value<string> LocationDescription { get; }
        Value<EIComponent> ComprehensiveLocationIdentifier { get; }
        Value<HDComponent> AssigningAuthorityForLocation { get; }
    }
}