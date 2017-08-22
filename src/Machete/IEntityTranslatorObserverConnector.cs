namespace Machete
{
    public interface IEntityTranslatorObserverConnector<out TEntity, TSchema>
        where TSchema : Entity
        where TEntity : TSchema
    {
        ObserverHandle ConnectEntityTranslateObserver(IEntityTranslatorObserver<TEntity, TSchema> observer);
    }
}