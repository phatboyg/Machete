namespace Machete
{
    public delegate T SetValueTypeProvider<TInput, TSchema, out T>(TranslateContext<TInput, TSchema> context)
        where TSchema : Entity
        where T : struct;
}