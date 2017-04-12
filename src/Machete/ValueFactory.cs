namespace Machete
{
    /// <summary>
    /// Returns a value parsed from the slice
    /// </summary>
    /// <param name="slice">The slice</param>
    /// <typeparam name="T">The value type</typeparam>
    public delegate Value<T> ValueFactory<out T>(TextSlice slice);
}