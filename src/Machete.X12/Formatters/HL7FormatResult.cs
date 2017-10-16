namespace Machete.X12.Formatters
{
    using Machete.Formatters;


    public class HL7FormatResult<TSchema> :
        FormatResult<TSchema>
        where TSchema : X12Entity
    {
    }
}