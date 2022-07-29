/*
 *
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 *
*/

using System;
using System.Collections;
using System.Collections.Generic;

namespace Lucene.Net.Support
{
    /// <summary>
    /// A C# emulation of the <a href="http://download.oracle.com/javase/1,5.0/docs/api/java/util/HashMap.html">Java Hashmap</a>
    /// <para>
    /// A <see cref="Dictionary{TKey, TValue}" /> is a close equivalent to the Java
    /// Hashmap.  One difference java implementation of the class is that
    /// the Hashmap supports both null keys and values, where the C# Dictionary
    /// only supports null values not keys.  Also, <c>V Get(TKey)</c>
    /// method in Java returns null if the key doesn't exist, instead of throwing
    /// an exception.  This implementation doesn't throw an exception when a key 
    /// doesn't exist, it will return null.  This class is slower than using a 
    /// <see cref="Dictionary{TKey, TValue}"/>, because of extra checks that have to be
    /// done on each access, to check for null.
    /// </para>
    /// <para>
    /// <b>NOTE:</b> This class works best with nullable types.  default(T) is returned
    /// when a key doesn't exist in the collection (this being similar to how Java returns
    /// null).  Therefore, if the expected behavior of the java code is to execute code
    /// based on if the key exists, when the key is an integer type, it will return 0 instead of null.
    /// </para>
    /// <remaks>
    /// Consider also implementing IDictionary, IEnumerable, and ICollection
    /// like <see cref="Dictionary{TKey, TValue}" /> does, so HashMap can be
    /// used in substituted in place for the same interfaces it implements.
    /// </remaks>
    /// </summary>
    /// <typeparam name="TKey">The type of keys in the dictionary</typeparam>
    /// <typeparam name="TValue">The type of values in the dictionary</typeparam>
    [Serializable]
    public class HashMap<TKey, TValue> : IDictionary<TKey, TValue>
    {
        internal IEqualityComparer<TKey> _comparer;
        internal Dictionary<TKey, TValue> _dict;

        // Indicates if a null key has been assigned, used for iteration
        private bool _hasNullValue;
        // stores the value for the null key
        private TValue _nullValue;
        // Indicates the type of key is a non-nullable valuetype
        private bool _isValueType;

        public HashMap()
            : this(0)
        { }

        public HashMap(IEqualityComparer<TKey> comparer)
            : this(0, comparer)
        {
            
        }

        public HashMap(int initialCapacity)
            : this(initialCapacity, EqualityComparer<TKey>.Default)
        {
            
        }

        public HashMap(int initialCapacity, IEqualityComparer<TKey> comparer)
        {
            _comparer = comparer;
            _dict = new Dictionary<TKey, TValue>(initialCapacity, _comparer);
            _hasNullValue = false;

            if (typeof(TKey).IsValueType)
            {
                _isValueType = Nullable.GetUnderlyingType(typeof(TKey)) == null;
            }
        }

        public HashMap(IEnumerable<KeyValuePair<TKey, TValue>> other)
            : this(0)
        {
            foreach (var kvp in other)
            {
                Add(kvp.Key, kvp.Value);
            }
        }

        public bool ContainsValue(TValue value)
        {
            if (!_isValueType && _hasNullValue && _nullValue.Equals(value))
                return true;

            return _dict.ContainsValue(value);
        }

        #region Implementation of IEnumerable

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            if (!_isValueType && _hasNullValue)
            {
                yield return new KeyValuePair<TKey, TValue>(default(TKey), _nullValue);
            }
            foreach (var kvp in _dict)
            {
                yield return kvp;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion

        #region Implementation of ICollection<KeyValuePair<TKey,TValue>>

        void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> item)
        {
            Add(item.Key, item.Value);
        }

        public void Clear()
        {
            _hasNullValue = false;
            _nullValue = default(TValue);
            _dict.Clear();
        }

        bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> item)
        {
            if (!_isValueType && _comparer.Equals(item.Key, default(TKey)))
            {
                return _hasNullValue && EqualityComparer<TValue>.Default.Equals(item.Value, _nullValue);
            }

            return ((ICollection<KeyValuePair<TKey, TValue>>)_dict).Contains(item);
        }

        void ICollection<KeyValuePair<TKey, TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        {
            ((ICollection<KeyValuePair<TKey, TValue>>) _dict).CopyTo(array, arrayIndex);
            if(!_isValueType && _hasNullValue)
            {
                array[array.Length - 1] = new KeyValuePair<TKey, TValue>(default(TKey), _nullValue);
            }
        }

        public bool Remove(KeyValuePair<TKey, TValue> item)
        {
            if (!_isValueType && _comparer.Equals(item.Key, default(TKey)))
            {
                if (!_hasNullValue)
                    return false;

                _hasNullValue = false;
                _nullValue = default(TValue);
                return true;
            }

            return ((ICollection<KeyValuePair<TKey, TValue>>)_dict).Remove(item);
        }

        public int Count
        {
            get { return _dict.Count + (_hasNullValue ? 1 : 0); }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        #endregion

        #region Implementation of IDictionary<TKey,TValue>

        public bool ContainsKey(TKey key)
        {
            if (!_isValueType && _comparer.Equals(key, default(TKey)))
            {
                if (_hasNullValue)
                {
                    return true;
                }
                return false;
            }

            return _dict.ContainsKey(key);
        }

        public virtual void Add(TKey key, TValue value)
        {
            if (!_isValueType && _comparer.Equals(key, default(TKey)))
            {
                _hasNullValue = true;
                _nullValue = value;
            }
            else
            {
                _dict[key] = value;
            }
        }

        public bool Remove(TKey key)
        {
            if (!_isValueType && _comparer.Equals(key, default(TKey)))
            {
                _hasNullValue = false;
                _nullValue = default(TValue);
                return true;
            }
            else
            {
                return _dict.Remove(key);
            }
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            if (!_isValueType && _comparer.Equals(key, default(TKey)))
            {
                if (_hasNullValue)
                {
                    value = _nullValue;
                    return true;
                }

                value = default(TValue);
                return false;
            }
            else
            {
                return _dict.TryGetValue(key, out value);
            }
        }

        public TValue this[TKey key]
        {
            get
            {
                if (!_isValueType && _comparer.Equals(key, default(TKey)))
                {
                    if (!_hasNullValue)
                    {
                        return default(TValue);
                    }
                    return _nullValue;
                }
                return _dict.ContainsKey(key) ? _dict[key] : default(TValue);
            }
            set { Add(key, value); }
        }

        public ICollection<TKey> Keys
        {
            get
            {
                if (!_hasNullValue) return _dict.Keys;

                // Using a List<T> to generate an ICollection<TKey>
                // would incur a costly copy of the dict's KeyCollection
                // use out own wrapper instead
                return new NullKeyCollection(_dict);
            }
        }

        public ICollection<TValue> Values
        {
            get
            {
                if (!_hasNullValue) return _dict.Values;

                // Using a List<T> to generate an ICollection<TValue>
                // would incur a costly copy of the dict's ValueCollection
                // use out own wrapper instead
                return new NullValueCollection(_dict, _nullValue);
            }
        }

        #endregion

        #region NullValueCollection

        /// <summary>
        /// Wraps a dictionary and adds the value
        /// represented by the null key
        /// </summary>
        class NullValueCollection : ICollection<TValue>
        {
            private readonly TValue _nullValue;
            private readonly Dictionary<TKey, TValue> _internalDict;

            public NullValueCollection(Dictionary<TKey, TValue> dict, TValue nullValue)
            {
                _internalDict = dict;
                _nullValue = nullValue;
            }

            #region Implementation of IEnumerable

            public IEnumerator<TValue> GetEnumerator()
            {
                yield return _nullValue;

                foreach (var val in _internalDict.Values)
                {
                    yield return val;
                }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }

            #endregion

            #region Implementation of ICollection<TValue>

            public void CopyTo(TValue[] array, int arrayIndex)
            {
                throw new NotImplementedException("Implement as needed");
            }

            public int Count
            {
                get { return _internalDict.Count + 1; }
            }

            public bool IsReadOnly
            {
                get { return true; }
            }

            #region Explicit Interface Methods

            void ICollection<TValue>.Add(TValue item)
            {
                throw new NotSupportedException();
            }

            void ICollection<TValue>.Clear()
            {
                throw new NotSupportedException();
            }

            bool ICollection<TValue>.Contains(TValue item)
            {
                throw new NotSupportedException();
            }

            bool ICollection<TValue>.Remove(TValue item)
            {
                throw new NotSupportedException("Collection is read only!");
            }
            #endregion

            #endregion
        }

        #endregion

        #region NullKeyCollection
        /// <summary>
        /// Wraps a dictionary's collection, adding in a
        /// null key.
        /// </summary>
        class NullKeyCollection : ICollection<TKey>
        {
            private readonly Dictionary<TKey, TValue> _internalDict;

            public NullKeyCollection(Dictionary<TKey, TValue> dict)
            {
                _internalDict = dict;
            }

            public IEnumerator<TKey> GetEnumerator()
            {
                yield return default(TKey);
                foreach (var key in _internalDict.Keys)
                {
                    yield return key;
                }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }

            public void CopyTo(TKey[] array, int arrayIndex)
            {
                throw new NotImplementedException("Implement this as needed");
            }

            public int Count
            {
                get { return _internalDict.Count + 1; }
            }

            public bool IsReadOnly
            {
                get { return true; }
            }

            #region Explicit Interface Definitions
            bool ICollection<TKey>.Contains(TKey item)
            {
                throw new NotSupportedException();
            }

            void ICollection<TKey>.Add(TKey item)
            {
                throw new NotSupportedException();
            }

            void ICollection<TKey>.Clear()
            {
                throw new NotSupportedException();
            }

            bool ICollection<TKey>.Remove(TKey item)
            {
                throw new NotSupportedException();
            }
            #endregion
        }
        #endregion
    }
}
