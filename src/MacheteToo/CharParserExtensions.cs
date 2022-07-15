namespace MacheteToo;

public static class CharParserExtensions
{
    /// <summary>
    /// Parse a single character matching ch
    /// </summary>
    /// <param name="parser">The input parser</param>
    /// <param name="ch">The character to match</param>
    /// <returns>The character parser</returns>
    public static IMemoryParser<char> Char(this IMemoryParser<char> parser, char ch)
    {
        if (parser == null)
            throw new ArgumentNullException(nameof(parser));

        bool IsChar(char c)
        {
            return c == ch;
        }

        return new MemoryParser<char>(parser, IsChar);
    }

    /// <summary>
    /// Parse a single character matching the expression
    /// </summary>
    /// <param name="parser">The input parser</param>
    /// <param name="predicate">The character matching expression</param>
    /// <returns>The character parser</returns>
    public static IMemoryParser<char> Char(this IMemoryParser<char> parser, Func<char, bool> predicate)
    {
        if (parser == null)
            throw new ArgumentNullException(nameof(parser));
        if (predicate == null)
            throw new ArgumentNullException(nameof(predicate));

        return new MemoryParser<char>(parser, predicate);
    }

    /// <summary>
    /// Parse any character that matches one of the specified characters
    /// </summary>
    /// <param name="parser">The input parser</param>
    /// <param name="chars"></param>
    /// <returns>The character parser</returns>
    public static IMemoryParser<char> Char(this IMemoryParser<char> parser, params char[] chars)
    {
        if (parser == null)
            throw new ArgumentNullException(nameof(parser));

        var valid = new HashSet<char>(chars);

        bool IsValid(char c)
        {
            return valid.Contains(c);
        }

        return new MemoryParser<char>(parser, IsValid);
    }

    /// <summary>
    /// Parse any character that matches one of the specified characters
    /// </summary>
    /// <param name="parser">The input parser</param>
    /// <param name="chars"></param>
    /// <returns>The character parser</returns>
    public static IMemoryParser<char> Char(this IMemoryParser<char> parser, IEnumerable<char> chars)
    {
        if (parser == null)
            throw new ArgumentNullException(nameof(parser));

        var valid = new HashSet<char>(chars);

        bool IsValid(char c)
        {
            return valid.Contains(c);
        }

        return new MemoryParser<char>(parser, IsValid);
    }

    /// <summary>
    /// Parse any character that matches one of the specified characters
    /// </summary>
    /// <param name="parser">The input parser</param>
    /// <returns>The character parser</returns>
    public static IMemoryParser<char> Char(this IMemoryParser<char> parser)
    {
        if (parser == null)
            throw new ArgumentNullException(nameof(parser));

        return new MemoryParser<char>(parser, Ok);
    }

    static bool Ok(char c)
    {
        return true;
    }

    public static IMemoryParser<char> Whitespace(this IMemoryParser<char> parser)
    {
        if (parser == null)
            throw new ArgumentNullException(nameof(parser));

        return parser.Char(char.IsWhiteSpace);
    }

    public static IMemoryParser<char> SkipWhitespace(this IMemoryParser<char> parser)
    {
        if (parser == null)
            throw new ArgumentNullException(nameof(parser));

        return parser.Whitespace().ZeroOrMore();
    }
}