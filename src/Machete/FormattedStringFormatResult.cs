namespace Machete
{
    public class FormattedStringFormatResult<TSchema> :
        StringFormatResult<TSchema>
        where TSchema : Entity
    {
        readonly FormatResult<TSchema> _formatResult;

        public FormattedStringFormatResult(FormatResult<TSchema> formatResult, string text)
        {
            _formatResult = formatResult;
            Text = text;
        }

        public string Text { get; }
    }
}