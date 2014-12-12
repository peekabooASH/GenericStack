using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsApp
{
    public class GenericStack<T>
    {

        public int i = 0;
        public T[] items;
        public GenericStack(int size)
        {
            items = new T[size + 1];
        }
        public void Push(T item)
        {
            this.items[i++] = item;

        }

        public T Pop()
        {
            T a = items[--i];
            return (a);
        }
    }
}
