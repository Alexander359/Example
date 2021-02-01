using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace UserCollections
{

    class MyList : IEnumerable, IEnumerator
    {
       List<int> numb = new List<int>();
        int index = -1;

        // Реализуем интерфейс IEnumerable
        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public void AddItem(int i)
        {
            numb.Add(i);

        }

        public void RemoveItem()
        {
            int s = numb.Count;
            
            
            while (s != 5)
            {
                numb.Remove(index);
                index++;
                s = s - 1;
            }

            Console.WriteLine("Осталось 5 элементов.");
                       
        }

        // Реализуем интерфейс IEnumerator
        public bool MoveNext()
        {
            if (index == numb.Count - 1)
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
                return numb[index];
            }
        }
    }


}
