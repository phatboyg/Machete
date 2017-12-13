namespace Machete.HL7.Values.Formatters
{
    using System;
    using Machete.Formatters;


    public class LongDateTimeOffsetValueFormatter :
        IValueFormatter<DateTimeOffset>
    {
        public void Format(FormatValueContext<DateTimeOffset> context)
        {
            if (!context.Value.HasValue)
                return;

            var value = context.Value.Value;

            if (value.Millisecond == 0)
                context.Append(value.ToString("yyyyMMddHHmmss", context.CurrentCulture));
            else
                context.Append(value.ToString("yyyyMMddHHmmssfff", context.CurrentCulture));
        }
    }
}