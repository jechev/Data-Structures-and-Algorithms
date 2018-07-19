using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class ReversetList<T>: IEnumerable<T>
    {
        private const int Initial_Capacity = 2;

        private T[] items;

        public ReversetList(int capacity = Initial_Capacity)
        {
            this.items = new T[capacity];
            this.Count = 0;
            this.Capacity = capacity;
        }

        public int Count { get; set; }

        public int Capacity { get; set; }

        public T this[int index] {
            get
            {
                if(index < 0  || index >= this.Count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return this.items[this.Count - 1 - index];
            }
            set
            {
                if (index < 0 || index >= this.Count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.items[this.Count - 1 - index] = value;
            }
        }


        public void Add(T item)
        {
            if(this.Count >= this.Capacity)
            {
                Array.Resize(ref this.items, this.Capacity * 2);
                this.Capacity *= 2;
            }

            this.items[this.Count] = item;
            this.Count++;

        }

        public T RemoveAt(int index)
        {
            T element = this[index];
            this.ShiftLeft(this.Count - 1 -index);
            this.Count--;

            return element;
        }

        private void ShiftLeft(int index)
        {
            for (int i = index; i < this.Count - 1; i++)
            {
                this.items[i] = this.items[i + 1];
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.Count; i++)
            {
                yield return this[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

