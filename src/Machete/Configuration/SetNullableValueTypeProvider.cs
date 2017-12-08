namespace Machete
{
    public delegate T? SetNullableValueTypeProvider<TInput, TSchema, T>(TranslateContext<TInput, TSchema> context)
        where TSchema : Entity
        where T : struct;
}