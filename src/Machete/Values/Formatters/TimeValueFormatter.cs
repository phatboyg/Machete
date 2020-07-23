namespace Machete.Values.Formatters
{
    using System;
    using Machete.Formatters;


    public class TimeValueFormatter :
        IValueFormatter<TimeSpan>
    {
        public void Format(FormatValueContext<TimeSpan> context)
        {
            if (!context.Value.HasValue)
                return;

            var value = context.Value.Value;

            if (value.Seconds == 0)
                context.Append(value.ToString("hhmm", context.CurrentCulture));
            else
                context.Append(value.ToString("hhmmss", context.CurrentCulture));
        }
    }
}