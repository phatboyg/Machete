namespace Machete.HL7
{
    public interface HL7Template<TSchema> :
        Template<TSchema>
        where TSchema : HL7Entity
    {
    }
}