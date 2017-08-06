namespace Machete
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;


    /// <summary>
    /// Maintains a collection of connections of the generic type
    /// </summary>
    /// <typeparam name="T">The connectable type</typeparam>
    public class Observable<T>
        where T : class
    {
        readonly Dictionary<long, T> _connections;
        T[] _connected;
        long _nextId;

        protected Observable()
        {
            _connections = new Dictionary<long, T>();
            _connected = new T[0];
        }

        /// <summary>
        /// The number of connections
        /// </summary>
        public int Count => _connected.Length;

        /// <summary>
        /// Connect a connectable type
        /// </summary>
        /// <param name="connection">The connection to add</param>
        /// <returns>The connection handle</returns>
        public ObserverHandle Connect(T connection)
        {
            if (connection == null)
                throw new ArgumentNullException(nameof(connection));

            var id = Interlocked.Increment(ref _nextId);

            lock (_connections)
            {
                _connections.Add(id, connection);
                _connected = _connections.Values.ToArray();
            }

            return new Handle(id, Disconnect);
        }

        /// <summary>
        /// Enumerate the connections invoking the callback for each connection
        /// </summary>
        /// <param name="callback">The callback</param>
        /// <returns>An awaitable Task for the operation</returns>
        public Task ForEachAsync(Func<T, Task> callback)
        {
            if (callback == null)
                throw new ArgumentNullException(nameof(callback));

            T[] connected;
            lock (_connections)
            {
                connected = _connected;
            }

            if (connected.Length == 0)
                return Task.FromResult(0);

            if (connected.Length == 1)
                return callback(connected[0]);

            return Task.WhenAll(connected.Select(callback));
        }

        public bool All(Func<T, bool> callback)
        {
            T[] connected;
            lock (_connections)
            {
                connected = _connected;
            }

            if (connected.Length == 0)
                return true;

            if (connected.Length == 1)
                return callback(connected[0]);

            return connected.All(callback);
        }

        void Disconnect(long id)
        {
            lock (_connections)
            {
                _connections.Remove(id);
                _connected = _connections.Values.ToArray();
            }
        }


        class Handle :
            ObserverHandle
        {
            readonly Action<long> _disconnect;
            readonly long _id;

            public Handle(long id, Action<long> disconnect)
            {
                _id = id;
                _disconnect = disconnect;
            }

            public void Disconnect()
            {
                _disconnect(_id);
            }

            public void Dispose()
            {
                Disconnect();
            }
        }
    }
}