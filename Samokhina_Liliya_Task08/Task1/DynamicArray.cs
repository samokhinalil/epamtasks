using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class DynamicArray<T> where T: new()
    {
        private T[] array;
        public int Length { get; private set; }
        public int Capacity { get; private set; }

        public DynamicArray()
        {
            Capacity = 8;
            array = new T[Capacity];
        }

        public DynamicArray(int n)
        {
            if (n > 0)
            {
                Capacity = n;
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
            Capacity = array.Length;
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
                Capacity = Length + count;
                Array.Resize(ref array, Capacity);
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
                    Capacity *= 2;
                    Array.Resize(ref array, Capacity);
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
