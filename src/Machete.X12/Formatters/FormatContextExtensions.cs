namespace Machete.X12.Formatters
{
    using System;
    using Machete.Formatters;


    public static class FormatContextExtensions
    {
        public static X12FormatContext AddSettings(this FormatContext context, X12Settings settings)
        {
            return context.GetOrAddContext(() => new CurrentX12FormatContext(settings));
        }

        public static X12FormatContext SetLevel(this FormatContext context, FormatLevel level)
        {
            return context.AddOrUpdateContext(() => new CurrentX12FormatContext(level), existing => new CurrentX12FormatContext(existing, level));
        }

        public static X12FormatContext SetLevel(this FormatContext context, Func<FormatLevel, FormatLevel> levelSelector)
        {
            return context.AddOrUpdateContext(() => new CurrentX12FormatContext(levelSelector(FormatLevel.Default)),
                existing => new CurrentX12FormatContext(existing, levelSelector(existing.Level)));
        }
    }
}