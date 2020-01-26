using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class MyList<T> : IEnumerable<T>, IEnumerator<T>
    {
        T[] array;
        int position = -1;

        public MyList()
        {
            this.array = new T[0];
        }

        public void Add(T item)
        {
            T[] bufArray = new T[this.array.Length + 1];
            this.array.CopyTo(bufArray, 0);
            bufArray[this.array.Length] = item;
            this.array = bufArray;
        }

        public int Count
        {
            get { return this.array.Length; }
        }

        public T this[int index]
        {
            get
            {
                if (this.array.Length > index)
                {
                    position = index;
                    return this.array[index];
                }
                return default(T);
            }
            set
            {
                if (index < this.array.Length)
                {
                    position = index;
                    this.array[index] = value;
                }
            }
        }
        public object Current
        {
            get { return (object)this.array[position]; }
        }

        void IDisposable.Dispose()
        { }

        public bool MoveNext()
        {
            if (position < this.array.Length - 1)
            {
                position++;
                return true;
            }
            else
            {
                Reset();
                return false;
            }
        }
        public void Reset()
        {
            position = -1;
        }

        T IEnumerator<T>.Current
        {
            get { return this.array[this.position]; }
        }

        public int Position { get => position; }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return this as IEnumerator<T>;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this as IEnumerator;
        }
    }
}
