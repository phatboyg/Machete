namespace Machete.Translators.PropertyTranslators
{
    using System;
    using System.Reflection;
    using System.Text;
    using System.Threading.Tasks;


    public class TranslateEntityValueListPropertyTranslator<TResult, TEntity, TInput, TSchema> :
        InputPropertyTranslator<TResult, ValueList<TEntity>, TInput>,
        IInputPropertyTranslator<TResult, TInput, TSchema>
        where TSchema : Entity
        where TInput : TSchema
        where TResult : TSchema
        where TEntity : TSchema
    {
        readonly IEntityTranslator<TEntity, TSchema> _entityTranslator;

        public TranslateEntityValueListPropertyTranslator(Type implementationType, PropertyInfo propertyInfo, PropertyInfo inputPropertyInfo,
            IEntityTranslator<TEntity, TSchema> entityTranslator)
            : base(implementationType, propertyInfo, inputPropertyInfo)
        {
            _entityTranslator = entityTranslator;
        }

        public async Task Apply(TResult entity, TranslateContext<TInput, TSchema> context)
        {
            var inputValue = context.HasInput ? InputProperty.Get(context.Input) : ValueList.Empty<TEntity>();

            EntityValueListBuilder<TEntity, TSchema> builder = new EntityValueListBuilder<TEntity, TSchema>();

            for (int index = 0; inputValue.TryGetValue(index, out var input); index++)
            {
                TranslateContext<TEntity, TSchema> inputContext = input.HasValue ? context.CreateContext(input.Value) : context.CreateContext<TEntity>();

                var result = await _entityTranslator.Translate(inputContext).ConfigureAwait(false);

                builder.Add(result);
            }

            Property.Set(entity, builder.ValueList);
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