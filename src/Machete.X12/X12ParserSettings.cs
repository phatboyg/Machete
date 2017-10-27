namespace Machete.X12
{
    public interface X12ParserSettings :
        X12Settings
    {
        ITextParser ElementParser { get; }
        ITextParser SubElementParser { get; }
        ITextParser RepetitionParser { get; }
        ITextParser SegmentParser { get; }
        ITextParser TextParser { get; }
    }
}