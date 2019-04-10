using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class DynamicArray<T> : IEnumerable, IEnumerator where T: new()
    {
        private int index = -1;
        private T[] array;
        public int Length { get; private set; }
        public int Capacity
        {
            get
            {
                return array.Length;
            }
        }

        public DynamicArray(IEnumerable<T> collection)
        {
            Length = collection.Count();
            array = new T[Length];
            int i = 0;
            foreach (var item in collection)
            {
                array[i] = item;
                i++;
            }
        }

        public DynamicArray()
        {
            array = new T[8];
        }

        public DynamicArray(int n)
        {
            if (n > 0)
            {
                array = new T[n];
            }
            else
            {
                throw new Exception("Incorrect array length!");
            }
        }

        public DynamicArray(T[] array)
        {
            this.array = array;
            Length = array.Length;
        }

        public void Add(T item)
        {
            Insert(Length, item);
        }

        public void AddRange(T[] addingArray)
        {
            var count = addingArray.Length;

            if(Capacity < Length + count)
            {
                Array.Resize(ref array, Length + count);
            }

            foreach (var item in addingArray)
            {
                array[Length++] = item;
            }
        }

        public bool Remove(T item)
        {
            int index = Array.IndexOf(array, item);
            if (index != -1)
            {
                Length--;
                Array.Copy(array, index + 1, array, index, Length - index);
                return true;
            }
            return false;
        }

        public void Insert(int index, T item)
        {
            if (index >= 0 && index <= Length)
            {
                if (Length == Capacity)
                {
                    Array.Resize(ref array, Capacity * 2);
                }
                Array.Copy(array, index, array, index + 1, Length - index);
                array[index] = item;
                Length++;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Index out of array range");
            }
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public object Current
        {
            get
            {
                return array[index];
            }
        }

        public bool MoveNext()
        {
            if (index == Length - 1)
            {
                Reset();
                return false;
            }
            index++;
            return true;
        }

        public void Reset()
        {
            index = -1;
        }

        public T this[int index]
        {
            get
            {
                if(index >=0 && index <= Length)
                {
                    return array[index];
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Index out of array range");
                }
            }

            set
            {
                if (index >= 0 && index <= Length)
                {
                    array[index] = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Index out of array range");
                }
            }
        }
    }
}
