namespace Machete
{
    using System;


    public delegate T? SetNullableValueTypeProvider<TInput, TSchema, T>(TranslateContext<TInput, TSchema> context)
        where TSchema : Entity
        where T : struct;


    public delegate T? SetNullableValueTypeProvider<TSchema, T>(TranslateContext<TSchema> context)
        where TSchema : Entity
        where T : struct;


    public delegate T? SetNullableValueTypeProvider<T>(ReadOnlySpan<char> span)
        where T : struct;
}