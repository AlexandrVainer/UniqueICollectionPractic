using NPOI.SS.Formula.Functions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueICollectionPractic
{
    public class UniqueICollection<T> : ICollection<T>
    {
        public UniqueICollection() { }

        private List<T> list = new List<T>();
        public int Count => list.Count;

        public bool IsReadOnly { get { return false; } }

        public void Add(T item)
        {

            if (!Contains(item))
            {
                list.Add(item);
            }
            else
            {
                //Console.WriteLine("A box with {0}x{1}x{2} dimensions was already added to the collection.",
                //    list.Height.ToString(), list.Length.ToString(), list.Width.ToString());
                Console.WriteLine("Invalid");
            }
        }

        public void Clear()
        {
            list.Clear();
        }

        public bool Contains(T item)
        {
            return list.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            if (array == null)
                throw new ArgumentNullException("The array cannot be null.");
            if (arrayIndex < 0)
                throw new ArgumentOutOfRangeException("The starting array index cannot be negative.");
            if (Count > array.Length - arrayIndex + 1)
                throw new ArgumentException("The destination array has fewer elements than the collection.");

            for (int i = 0; i < list.Count; i++)
            {
                array[i + arrayIndex] = list[i];
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach(T item in list)
                yield return item;
        }

        public bool Remove(T item)
        {
            return list.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

