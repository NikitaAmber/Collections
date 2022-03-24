using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class DynamicArrayOperations<T>: IEnumerable, IEnumerator
    {
        public T[] array = new T[8];
        int index = -1;
        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if (index == array.Length - 1)
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

        public object Current
        {
            get
            {
                return array[index];
            }
        }

        public void DoubleSize(ref T[] array)
        {
            Array.Resize(ref array, array.Length * 2);
        }

        public void Add(ref T[] array,T value)
        {
            var cell = 0;
            while (array[cell]!=null)
            {
                if (cell == array.Length)
                {
                    DoubleSize(ref array);
                }
                cell++;
            }
            array[cell] = value;
        }

        public bool Remove(ref T[] array, int cell)
        {
            try
            {
                if (cell > array.Length - 1 || cell < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                array[cell] = default(T);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Insert(ref T[] array, int cell, T value)
        {
            try
            {
                if (cell > array.Length - 1||cell<0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                array[cell] = value;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
