namespace Machete.Values.Formatters
{
    using System;
    using Machete.Formatters;


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
            if (!context.Value.HasValue)
                return;
            
            var text = context.Value.Value.ToString(Format, context.CurrentCulture);

            context.Append(text);
        }
    }
}