namespace Machete.X12
{
    public interface X12ParserSettings :
        X12Settings
    {
        TextParser ElementParser { get; }
        TextParser SubElementParser { get; }
        TextParser RepetitionParser { get; }
        TextParser SegmentParser { get; }
        TextParser TextParser { get; }
    }
}