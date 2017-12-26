namespace Machete.Translators.PropertyTranslators
{
    using System;
    using System.Reflection;
    using System.Text;
    using System.Threading.Tasks;


    public class CreateEntityValuePropertyTranslator<TResult, TEntity, TInput, TSchema> :
        PropertyTranslator<TResult, Value<TEntity>>,
        IInputPropertyTranslator<TResult, TInput, TSchema>
        where TSchema : Entity
        where TInput : TSchema
        where TResult : TSchema
        where TEntity : TSchema
    {
        readonly IEntityCreator<TSchema> _entityCreator;
        readonly EntityValueConverter<TEntity, TSchema> _converter;

        public CreateEntityValuePropertyTranslator(PropertyInfo propertyInfo, IEntityCreator<TSchema> entityCreator)
            : base(propertyInfo)
        {
            _entityCreator = entityCreator;
            _converter = new EntityValueConverter<TEntity, TSchema>();
        }

        public async Task Apply(TResult entity, TranslateContext<TInput, TSchema> context)
        {
            var result = await _entityCreator.Translate(context).ConfigureAwait(false);

            Property.Set(entity, _converter.Convert(result));
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(PropertyName);
            sb.Append(": (create");

            sb.AppendLine(") {");

            var strings = _entityCreator.ToString().Split(new[] {'\n'}, StringSplitOptions.RemoveEmptyEntries);
            foreach (var s in strings)
            {
                sb.Append("  ");
                sb.AppendLine(s.Trim('\n', '\r'));
            }

            sb.AppendLine("}");

            return sb.ToString();
        }
    }


    public class CreateEntityValuePropertyTranslator<TResult, TEntity, TSchema> :
        PropertyTranslator<TResult, Value<TEntity>>,
        IPropertyTranslator<TResult, TSchema>
        where TSchema : Entity
        where TResult : TSchema
        where TEntity : TSchema
    {
        readonly IEntityCreator<TSchema> _entityCreator;
        readonly EntityValueConverter<TEntity, TSchema> _converter;

        public CreateEntityValuePropertyTranslator(PropertyInfo propertyInfo, IEntityCreator<TSchema> entityCreator)
            : base(propertyInfo)
        {
            _entityCreator = entityCreator;
            _converter = new EntityValueConverter<TEntity, TSchema>();
        }

        public async Task Apply(TResult entity, TranslateContext<TSchema> context)
        {
            var result = await _entityCreator.Translate(context).ConfigureAwait(false);

            Property.Set(entity, _converter.Convert(result));
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(PropertyName);
            sb.Append(": (create");

            sb.AppendLine(") {");

            var strings = _entityCreator.ToString().Split(new[] {'\n'}, StringSplitOptions.RemoveEmptyEntries);
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