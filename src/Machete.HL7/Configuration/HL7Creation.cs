namespace Machete.HL7
{
    using Machete.TranslatorConfiguration;


    public class HL7Creation<TSchema> :
        TranslateCreation<TSchema>
        where TSchema : HL7Entity
    {
    }
}