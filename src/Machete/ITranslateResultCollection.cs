namespace Machete
{
    public interface ITranslateResultCollection<TSchema>
        where TSchema : Entity
    {
        void Add(TranslateResult<TSchema> result);

        /// <summary>
        /// Returns the result from the collection
        /// </summary>
        /// <returns></returns>
        TranslateResult<TSchema> ToResult();
    }
}