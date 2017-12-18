namespace Machete
{
    public delegate Value<T> SetValueProvider<TInput, TSchema, T>(TranslateValueContext<T, TInput, TSchema> context)
        where TSchema : Entity;
    
    /// <summary>
    /// Returns a value for an entity property
    /// </summary>
    /// <param name="context"></param>
    /// <typeparam name="TSchema"></typeparam>
    /// <typeparam name="T"></typeparam>
    public delegate Value<T> SetValueProvider<TSchema, out T>(TranslateContext<TSchema> context)
        where TSchema : Entity;


    public delegate T SetValueProvider<out T>(TextSlice slice);
}