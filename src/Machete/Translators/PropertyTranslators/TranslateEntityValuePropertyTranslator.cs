namespace Machete.Translators.PropertyTranslators
{
    using System;
    using System.Reflection;
    using System.Text;
    using System.Threading.Tasks;


    public class TranslateEntityValuePropertyTranslator<TResult, TEntity, TInput, TSchema> :
        InputPropertyTranslator<TResult, Value<TEntity>, TInput>,
        IInputPropertyTranslator<TResult, TInput, TSchema>
        where TSchema : Entity
        where TInput : TSchema
        where TResult : TSchema
        where TEntity : TSchema
    {
        readonly IEntityTranslator<TEntity, TSchema> _entityTranslator;
        readonly EntityValueConverter<TEntity, TSchema> _converter;

        public TranslateEntityValuePropertyTranslator(Type implementationType, PropertyInfo propertyInfo, PropertyInfo inputPropertyInfo,
            IEntityTranslator<TEntity, TSchema> entityTranslator)
            : base(implementationType, propertyInfo, inputPropertyInfo)
        {
            _entityTranslator = entityTranslator;

            _converter = new EntityValueConverter<TEntity, TSchema>();
        }

        public async Task Apply(TResult entity, TranslateContext<TInput, TSchema> context)
        {
            var inputValue = context.HasInput ? InputProperty.Get(context.Input) : Value.Missing<TEntity>();

            TranslateContext<TEntity, TSchema> inputContext = inputValue.HasValue ? context.CreateContext(inputValue.Value) : context.CreateContext<TEntity>();

            var result = await _entityTranslator.Translate(inputContext).ConfigureAwait(false);

            Property.Set(entity, _converter.Convert(result));
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(PropertyName);
            sb.Append(": (translate");

            if (PropertyName != InputPropertyName)
                sb.AppendFormat(", source: {0}", InputPropertyName);

            sb.AppendLine(") {");

            var strings = _entityTranslator.ToString().Split(new[] {'\n'}, StringSplitOptions.RemoveEmptyEntries);
            foreach (var s in strings)
            {
                sb.Append("  ");
                sb.AppendLine(s.Trim('\n', '\r'));
            }

            sb.AppendLine("}");

            return sb.ToString();
        }
    }
}