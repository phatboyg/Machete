namespace Machete.X12
{
    public interface X12Settings
    {
        char ElementSeparator { get; }
        char SubElementSeparator { get; }
        char RepetitionSeparator { get; }
        char SegmentSeparator { get; }
    }
}