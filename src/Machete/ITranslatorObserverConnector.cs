namespace Machete
{
    public interface ITranslatorObserverConnector<TSchema>
        where TSchema : Entity
    {
        ObserverHandle ConnectTranslateObserver(ITranslatorObserver<TSchema> observer);
    }
}