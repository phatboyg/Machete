namespace Machete
{
    public delegate Value<T> SetValueProvider<TInput, TSchema, out T>(TranslateContext<TInput, TSchema> context)
        where TSchema : Entity;
}