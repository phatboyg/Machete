namespace Machete
{
    public interface ITranslatorObserverConnector<TSchema>
        where TSchema : Entity
    {
        ObserverHandle ConnectTranslatorObserver(ITranslatorObserver<TSchema> observer);
    }
}