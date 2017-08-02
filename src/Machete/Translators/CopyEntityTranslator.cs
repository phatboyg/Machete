namespace Machete.Translators
{
    using System.Threading.Tasks;


    /// <summary>
    /// A simple fast copy of the source to the target
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="TSchema"></typeparam>
    public class CopyEntityTranslator<TEntity, TSchema> :
        ITranslator<TEntity, TSchema>
        where TSchema : Entity
        where TEntity : TSchema
    {
        public Task<EntityResult<TSchema>> Translate(TranslateContext<TEntity, TSchema> context)
        {
            return Task.FromResult(context.Result(context.Input));
        }
    }
}