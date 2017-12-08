namespace Machete.X12.Configuration
{
    public abstract class X12EntityTranslation<TResult, TInput, TSchema> :
        EntityTranslation<TResult, TInput, TSchema>
        where TSchema : X12Entity
        where TInput : TSchema
        where TResult : TSchema
    {
    }
}