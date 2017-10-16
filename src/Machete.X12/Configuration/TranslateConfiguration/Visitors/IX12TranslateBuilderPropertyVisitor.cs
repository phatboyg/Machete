namespace Machete.X12.Configuration.TranslateConfiguration.Visitors
{
    using Machete.TranslateConfiguration.Visitors;


    public interface IX12TranslateBuilderPropertyVisitor<in TSchema> :
        ITranslateBuilderPropertyVisitor<TSchema>
        where TSchema : X12Entity
    {
    }
}