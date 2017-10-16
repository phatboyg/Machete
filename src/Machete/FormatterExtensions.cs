namespace Machete
{
    using System.IO;
    using System.Text;
    using System.Threading.Tasks;
    using Formatters;


    public static class FormatterExtensions
    {
        public static async Task<StringFormatResult<TSchema>> FormatToStringAsync<TSchema>(this IFormatter<TSchema> formatter, EntityResult<TSchema> input)
            where TSchema : Entity
        {
            using (var memoryStream = new MemoryStream())
            {
                var formatted = await formatter.FormatAsync(memoryStream, input);

                var text = Encoding.UTF8.GetString(memoryStream.ToArray());

                return new FormattedStringFormatResult<TSchema>(formatted, text);
            }
        }
    }
}