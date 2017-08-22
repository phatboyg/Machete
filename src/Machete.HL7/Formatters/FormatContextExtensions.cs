namespace Machete.HL7.Formatters
{
    using System;


    public static class FormatContextExtensions
    {
        public static HL7FormatContext AddSettings(this FormatContext context, HL7Settings settings)
        {
            return context.GetOrAddContext(() => new CurrentHL7FormatContext(settings));
        }

        public static HL7FormatContext SetLevel(this FormatContext context, FormatLevel level)
        {
            return context.AddOrUpdateContext(() => new CurrentHL7FormatContext(level), existing => new CurrentHL7FormatContext(existing, level));
        }

        public static HL7FormatContext SetLevel(this FormatContext context, Func<FormatLevel, FormatLevel> levelSelector)
        {
            return context.AddOrUpdateContext(() => new CurrentHL7FormatContext(levelSelector(FormatLevel.Default)),
                existing => new CurrentHL7FormatContext(existing, levelSelector(existing.Level)));
        }
    }
}