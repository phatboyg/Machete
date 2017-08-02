namespace Machete.Translators.TranslateContexts
{
    using System;


    public class TranslateResultEntityResult<TResult, TSchema> :
        EntityResult<TSchema>
        where TResult : TSchema
        where TSchema : Entity
    {
        readonly TResult _result;
        readonly Type _resultType;

        public TranslateResultEntityResult(TResult result, ISchema<TSchema> schema)
        {
            _result = result;
            Schema = schema;

            _resultType = typeof(TResult);
        }

        public TranslateResultEntityResult(TResult result, Type resultType, ISchema<TSchema> schema)
        {
            _result = result;
            Schema = schema;

            _resultType = resultType;
        }

        public bool TryGetEntity<T>(int index, out T entity)
            where T : TSchema
        {
            if (typeof(T).IsAssignableFrom(_resultType))
            {
                object obj = _result;
                entity = (T) obj;
                return true;
            }

            entity = default(T);
            return false;
        }

        public ISchema<TSchema> Schema { get; }
    }
}