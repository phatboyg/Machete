namespace Machete.X12.Configuration
{
    public abstract class X12ComponentTranslation<TResult, TInput, TSchema> :
        X12EntityTranslation<TResult, TInput, TSchema>
        where TSchema : X12Entity
        where TInput : TSchema, X12Component
        where TResult : TSchema, X12Component
    {
    }
}