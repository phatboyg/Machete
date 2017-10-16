namespace Machete.X12.Formatters
{
    public class CurrentX12FormatContext :
        X12FormatContext
    {
        public CurrentX12FormatContext(X12Settings settings)
        {
            Settings = settings;
        }

        public CurrentX12FormatContext(FormatLevel level)
        {
            Level = level;
            Settings = new X12FormatterSettings();
        }

        public CurrentX12FormatContext(X12FormatContext source, FormatLevel level)
        {
            Level = level;
            Settings = source.Settings;
        }

        public FormatLevel Level { get; }

        public X12Settings Settings { get; }
    }
}