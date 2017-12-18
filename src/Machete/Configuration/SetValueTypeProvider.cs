namespace Machete
{
    public delegate T SetValueTypeProvider<TInput, TSchema, out T>(TranslateContext<TInput, TSchema> context)
        where TSchema : Entity
        where T : struct;


    public delegate T SetValueTypeProvider<TSchema, out T>(TranslateContext<TSchema> context)
        where TSchema : Entity
        where T : struct;
}