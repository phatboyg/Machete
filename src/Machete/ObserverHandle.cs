namespace Machete
{
    public interface ObserverHandle
    {
        /// <summary>
        /// Disconnects the observer from the subject
        /// </summary>
        void Disconnect();
    }
}