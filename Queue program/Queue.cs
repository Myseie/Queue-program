using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_program
{

    public class Queue <T>
    {
        private List<T> elements = new List<T>();
        public void Enqueue(T item)
        {
            elements.Add(item);

            Console.WriteLine($"{item} har lagts till i kön");

        }

        public T Dequeue()
        {
            if(IsEmpty())
            {
                throw new InvalidOperationException("Kön är tom");

            }

            T value = elements[0];
            elements.RemoveAt(0);
            Console.WriteLine($"{value} har tagits bort från kön");
            return value;

        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Kön är tom");
            }

            return elements[0];
            
        }

        public bool IsEmpty()
        {

            return elements.Count == 0;
        }
    }
}
