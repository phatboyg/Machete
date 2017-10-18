namespace Machete.HL7.Formatters
{
    using Machete.Formatters;


    public class HL7FormatResult<TSchema> :
        FormatResult<TSchema>
        where TSchema : HL7Entity
    {
    }
}