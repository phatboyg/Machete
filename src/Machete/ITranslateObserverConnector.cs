namespace Machete
{
    public interface ITranslateObserverConnector<TSchema>
        where TSchema : Entity
    {
        ObserverHandle ConnectTranslateObserver(ITranslateObserver<TSchema> observer);
    }
}