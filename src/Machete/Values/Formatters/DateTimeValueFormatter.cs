namespace Machete.Values.Formatters
{
    using System;
    using Machete.Formatters;


    public class DateTimeValueFormatter :
        IValueFormatter<DateTime>
    {
        public void Format(FormatValueContext<DateTime> context)
        {
            if (!context.Value.HasValue)
                return;

            var value = context.Value.Value;

            if (value.TimeOfDay == TimeSpan.Zero)
                context.Append(value.ToString("yyyyMMdd", context.CurrentCulture));
            else if (value.Date == DateTime.MinValue.Date && value.Millisecond == 0)
                context.Append(value.ToString("HHmmss", context.CurrentCulture));
            else if (value.Date == DateTime.MinValue.Date)
                context.Append(value.ToString("HHmmss.ffffff", context.CurrentCulture));
            else if (value.Millisecond == 0)
                context.Append(value.ToString("yyyyMMddHHmmss", context.CurrentCulture));
            else
                context.Append(value.ToString("yyyyMMddHHmmss.ffffff", context.CurrentCulture));
        }
    }
}