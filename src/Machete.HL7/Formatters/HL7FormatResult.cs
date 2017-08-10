namespace Machete.HL7.Formatters
{
    public class HL7FormatResult<TSchema> :
        FormatResult<TSchema>
        where TSchema : HL7Entity
    {
    }
}