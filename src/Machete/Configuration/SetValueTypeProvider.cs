namespace Machete
{
    public delegate T? SetValueTypeProvider<TInput, TSchema, T>(TranslateContext<TInput, TSchema> context)
        where TSchema : Entity
        where T : struct;
}