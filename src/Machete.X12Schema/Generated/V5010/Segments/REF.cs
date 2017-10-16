namespace Machete.X12Schema.V5010
{
    using Machete.X12;
    public interface REF : X12Segment
    {
        Value<string> Qualifier { get; }

        Value<string> Identifier { get; }

        Value<string> Description { get; }
    }
}