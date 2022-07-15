namespace Machete
{
    using System;


    public delegate T SetValueTypeProvider<TInput, TSchema, out T>(TranslateContext<TInput, TSchema> context)
        where TSchema : Entity
        where T : struct;


    public delegate T SetValueTypeProvider<TSchema, out T>(TranslateContext<TSchema> context)
        where TSchema : Entity
        where T : struct;


    public delegate T SetValueTypeProvider<out T>(ReadOnlySpan<char> slice)
        where T : struct;
}