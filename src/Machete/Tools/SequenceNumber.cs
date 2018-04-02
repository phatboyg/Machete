namespace Machete.Tools
{
    using System;
    using System.Collections.Generic;


    /// <summary>
    /// Used to generate sequence numbers, which can be nested by type
    /// </summary>
    public class SequenceNumber
    {
        readonly int _seed;

        readonly object _syncLock;
        int _number;
        Dictionary<Type, SequenceNumber> _sequenceNumbers;

        public SequenceNumber(int seed = 0)
        {
            _seed = seed;
            _number = seed;

            _syncLock = new object();
        }

        /// <summary>
        /// Return the next sequence number
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public SequenceNumber Of<T>()
        {
            lock (_syncLock)
            {
                if (_sequenceNumbers == null)
                    _sequenceNumbers = new Dictionary<Type, SequenceNumber>();

                if (_sequenceNumbers.TryGetValue(typeof(T), out var number))
                    return number;
                
                number = new SequenceNumber(_seed);

                _sequenceNumbers.Add(typeof(T), number);

                return number;
            }
        }

        public int Current => _number;

        public int Next()
        {
            lock (_syncLock)
            {
                _sequenceNumbers?.Clear();

                return ++_number;
            }
        }
    }
}