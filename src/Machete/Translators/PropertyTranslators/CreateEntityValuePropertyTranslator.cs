namespace Machete.Translators.PropertyTranslators
{
    using System;
    using System.Reflection;
    using System.Text;
    using System.Threading.Tasks;
    using Internals.Reflection;
    using Values;


    public class CreateEntityValuePropertyTranslator<TResult, TEntity, TInput, TSchema> :
        IPropertyTranslator<TResult, TInput, TSchema>
        where TSchema : Entity
        where TInput : TSchema
        where TResult : TSchema
        where TEntity : TSchema
    {
        readonly IEntityCreator<TSchema> _entityCreator;
        readonly WriteProperty<TResult, Value<TEntity>> _property;
        readonly string _propertyName;

        public CreateEntityValuePropertyTranslator(Type implementationType, PropertyInfo entityPropertyInfo, IEntityCreator<TSchema> entityCreator)
        {
            _entityCreator = entityCreator;
            _propertyName = entityPropertyInfo.Name;
            _property = new WriteProperty<TResult, Value<TEntity>>(implementationType, _propertyName);
        }

        public async Task Apply(TResult entity, TranslateContext<TInput, TSchema> context)
        {
            var result = await _entityCreator.Translate(context).ConfigureAwait(false);
            if (result.HasResult && result.TryGetEntity(0, out TEntity resultEntity))
                _property.Set(entity, new ConstantValue<TEntity>(resultEntity));
            else
            {
                _property.Set(entity, Value.Missing<TEntity>());
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(_propertyName);
            sb.Append(": (translate");

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