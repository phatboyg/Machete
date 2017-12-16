namespace Machete.Translators.PropertyTranslators
{
    using System;
    using System.Reflection;
    using System.Text;
    using System.Threading.Tasks;
    using Internals.Reflection;
    using Values;


    public class TranslateEntityValueListPropertyTranslator<TResult, TEntity, TInput, TSchema> :
        IPropertyTranslator<TResult, TInput, TSchema>
        where TSchema : Entity
        where TInput : TSchema
        where TResult : TSchema
        where TEntity : TSchema
    {
        readonly IEntityTranslator<TEntity, TSchema> _entityTranslator;
        readonly WriteProperty<TResult, ValueList<TEntity>> _property;
        readonly ReadOnlyProperty<TInput, ValueList<TEntity>> _inputProperty;
        readonly string _propertyName;

        public TranslateEntityValueListPropertyTranslator(Type implementationType, PropertyInfo entityPropertyInfo, PropertyInfo inputPropertyInfo,
            IEntityTranslator<TEntity, TSchema> entityTranslator)
        {
            _entityTranslator = entityTranslator;
            _propertyName = entityPropertyInfo.Name;
            _property = new WriteProperty<TResult, ValueList<TEntity>>(implementationType, _propertyName);
            _inputProperty = new ReadOnlyProperty<TInput, ValueList<TEntity>>(inputPropertyInfo);
        }

        public async Task Apply(TResult entity, TranslateContext<TInput, TSchema> context)
        {
            var inputValue = _inputProperty.Get(context.Input) ?? ValueList.Empty<TEntity>();

            ListValueList<TEntity> results = new ListValueList<TEntity>();

            for (int index = 0; inputValue.TryGetValue(index, out var input); index++)
            {
                TranslateContext<TEntity, TSchema> inputContext = context.CreateContext(input.Value, index);

                var result = await _entityTranslator.Translate(inputContext).ConfigureAwait(false);
                if (result.HasResult)
                {
                    while (result.TryGetEntity(0, out TEntity resultEntity))
                    {
                        results.Add(resultEntity);
                    }
                }
            }

            _property.Set(entity, results);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(_propertyName);
            sb.Append(": (translate");

            if (_propertyName != _inputProperty.Property.Name)
                sb.AppendFormat(", source: {0}", _inputProperty.Property.Name);

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