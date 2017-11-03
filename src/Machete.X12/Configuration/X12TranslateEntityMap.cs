namespace Machete.X12.Configuration
{
    public abstract class X12TranslateEntityMap<TResult, TInput, TSchema> :
        EntityTranslateMap<TResult, TInput, TSchema>
        where TSchema : X12Entity
        where TInput : TSchema
        where TResult : TSchema
    {
    }
}