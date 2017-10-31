namespace Machete.Values.Formatters
{
    using System;
    using Machete.Formatters;


    public class DateTimeOffsetValueFormatter :
        IValueFormatter<DateTimeOffset>
    {
        public void Format(FormatValueContext<DateTimeOffset> context)
        {
            if (!context.Value.HasValue)
                return;

            var value = context.Value.Value;

            if (value.Millisecond == 0)
                context.Append(value.ToString("yyyyMMddHHmmsszzz", context.CurrentCulture));
            else
                context.Append(value.ToString("yyyyMMddHHmmss.ffffffzzz", context.CurrentCulture));
        }
    }
}