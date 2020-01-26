using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class MyDictonary<Tkey, TValue> : IEnumerable<object>, IEnumerator<object>
    {
        Tkey[] keys;
        TValue[] values;
        int length;
        int position = -1;

        public int Count { get => length; }

        public string this[int index]
        {
            get
            {
                if (index < length && index > -1)
                {
                    position = index;
                    return keys[index] + "-" + values[index];
                }
                else
                    return "Traing to go outside the array";
            }
        }

        #region Constructors
        public MyDictonary(int capacity)
        {
            this.keys = new Tkey[capacity];
            this.values = new TValue[capacity];
            length = capacity;
        }
        public MyDictonary() : this(0)
        { }
        #endregion

        public void Add(int index, Tkey key, TValue value)
        {
            if (index < length)
            {
                this.keys[index] = key;
                this.values[index] = value;
            }
            else
                Console.WriteLine("Train to go outside the array");
        }
        public void Add(Tkey key, TValue value)
        {
            Tkey[] bufKeys = new Tkey[this.keys.Length + 1];
            TValue[] bufValues = new TValue[this.values.Length + 1];
            this.keys.CopyTo(bufKeys, 0);
            this.values.CopyTo(bufValues, 0);
            bufKeys[this.keys.Length] = key;
            bufValues[this.values.Length] = value;
            this.keys = bufKeys;
            this.values = bufValues;
        }
        void IDisposable.Dispose()
        {
            Reset();
        }

        #region Implementation Enumerator

        public void Reset()
        {
            position = -1;
        }

        public bool MoveNext()
        {
            if (position < length)
            {
                position++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public object Current
        {
            get
            {
                if (position != -1)
                    return keys[position] + "-" + values[position];
                else
                    return null;
            }
        }



        #endregion

        public IEnumerator GetEnumerator()
        {
            return this as IEnumerator;
        }

        IEnumerator<object> IEnumerable<object>.GetEnumerator()
        {
            return this as IEnumerator<object>;
        }
    }
}
