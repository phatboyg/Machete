namespace Machete.X12.Configuration.TranslatorConfiguration.Visitors
{
    using Machete.TranslatorConfiguration.Visitors;


    public interface IX12TranslateBuilderPropertyVisitor<in TSchema> :
        ITranslateBuilderPropertyVisitor<TSchema>
        where TSchema : X12Entity
    {
    }
}