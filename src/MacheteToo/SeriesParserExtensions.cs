namespace MacheteToo;

using Parsers;


public static class SeriesParserExtensions
{
    public static IParser<TInput, ReadOnlyMemory<T>> Take<TInput, T>(this IParser<TInput, T> parser, int count)
    {
        if (parser == null)
            throw new ArgumentNullException(nameof(parser));
        if (count < 0)
            throw new ArgumentOutOfRangeException(nameof(count), "Count must be >= 0");

        return new TakeParser<TInput, T>(parser, count);
    }

    /// <summary>
    /// Returns a series of parsed elements as an array.
    /// </summary>
    /// <param name="parser"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"></exception>
    public static IMemoryParser<T> ZeroOrMore<T>(this IMemoryParser<T> parser)
    {
        if (parser == null)
            throw new ArgumentNullException(nameof(parser));

        return new SeriesMemoryParser<T>(parser, false);
    }
}