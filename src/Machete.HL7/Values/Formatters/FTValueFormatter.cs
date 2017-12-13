namespace Machete.HL7.Values.Formatters
{
    using Machete.Formatters;


    public class FTValueFormatter :
        IValueFormatter<FT>
    {
        public void Format(FormatValueContext<FT> context)
        {
            if (context.Value.HasValue)
                context.Append(context.Value.Value);
        }
    }
}