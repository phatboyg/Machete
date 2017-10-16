namespace Machete.X12.Formatters
{
    public interface X12FormatContext
    {
        FormatLevel Level { get; }

        X12Settings Settings { get; }
    }
}