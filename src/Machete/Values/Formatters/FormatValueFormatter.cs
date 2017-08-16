namespace Machete.Values.Formatters
{
    using System;


    public class FormatValueFormatter<TValue> :
        IValueFormatter<TValue>
        where TValue : IFormattable
    {
        public FormatValueFormatter(string format)
        {
            Format = format ?? "G";
        }

        public string Format { get; }

        void IValueFormatter<TValue>.Format(FormatValueContext<TValue> context)
        {
            if (context.Value.HasValue)
            {
                var text = context.Value.Value.ToString(Format, context.CurrentCulture);

                context.Append(text);
            }
        }
    }
}