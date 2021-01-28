using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // коллекция ArrayList
            ArrayList objectList = new ArrayList() { 1, 2, "string", 'c', 2.0f };

            object obj = 45.8;

            objectList.Add(obj);
            objectList.Add("string2");
            objectList.RemoveAt(0); // удаление первого элемента
            foreach (object o in objectList)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine("Общее число элементов коллекции: {0}", objectList.Count);
            Console.WriteLine(Environment.NewLine);

            // коллекция HashTable
            Hashtable ht = new Hashtable();

            ht.Add("ivan", 33);
            ht.Add("kolya", 25);
            ht.Add("sanya", 43);
            ht.Add("dima", 18);

            foreach (DictionaryEntry element in ht)
            {
                Console.WriteLine($"Key:{element.Key}  \tValue:{element.Value}");
            }
            Console.WriteLine(Environment.NewLine);


            // коллекция Queue

            Queue qqu = new Queue();
            qqu.Enqueue("Yellow");
            qqu.Enqueue("Green");
            qqu.Enqueue("Black");
            qqu.Enqueue("White");

            int qqu_c = qqu.Count;

            for (int i=0; i<qqu_c; i++)
            {
                var item = qqu.Dequeue();
                Console.WriteLine(item);
            }
            Console.WriteLine(Environment.NewLine);

            // коллекция Stack

            Stack namestk = new Stack();

            namestk.Push("z1");
            namestk.Push("z2");
            namestk.Push("z3");
            namestk.Push("z4");
            namestk.Push("z5");
            namestk.Push("z6");
            namestk.Push("z7");

            foreach(var item in namestk)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(Environment.NewLine);

            // обобщенная коллекция Dictionary

            Dictionary<string, string> abcDe = new Dictionary<string, string>();

            abcDe.Add("car", "Toyota");
            abcDe.Add("plane", "Boeing");
            abcDe.Add("truck", "MAN");

            foreach (var item in abcDe)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(Environment.NewLine);

            // обобщенная коллекция GenericQueue
            
            Queue<int> numb = new Queue<int>();

            numb.Enqueue(12);
            numb.Enqueue(23);
            numb.Enqueue(34);
            numb.Enqueue(45);
            numb.Enqueue(56);
            numb.Enqueue(67);

            foreach (var item in numb)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(Environment.NewLine);

            // обобщенная коллекция GenericStack

            Stack<string> stk_name = new Stack<string>();

            stk_name.Push("Z11");
            stk_name.Push("Z22");
            stk_name.Push("Z33");
            stk_name.Push("Z44");
            stk_name.Push("Z55");
            stk_name.Push("Z66");
            stk_name.Push("Z77");


            foreach(var item in stk_name)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine(Environment.NewLine);

            HashSet<int> hash1s = new HashSet<int>()
            {
                41,42,43,44
            };

            hash1s.Add(45);

            foreach (var item in hash1s)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(Environment.NewLine);

            // обобщенная коллекция LinkedList

            LinkedList<int> TestList = new LinkedList<int>();


            TestList.AddFirst(15);
            TestList.AddAfter(TestList.Last, 25);
            TestList.AddAfter(TestList.Last, 45);
            TestList.AddBefore(TestList.Last, 35);
            TestList.AddAfter(TestList.Last, 55);
            TestList.AddAfter(TestList.Last, 65);
            TestList.AddAfter(TestList.Last, 75);
            TestList.AddAfter(TestList.Last, 81);
            TestList.AddAfter(TestList.Last, 93);
            TestList.AddAfter(TestList.Last, 101);
            TestList.AddAfter(TestList.Last, 112);
            TestList.AddLast(123);

            foreach (var item in TestList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(Environment.NewLine);
            int List_c = TestList.Count;
            int medium = List_c / 2;

            // Первый способ удалить данные из середины. Но здесь используется значение данных для поиска.

            Console.WriteLine("   Value of next node:     {0}", TestList);
            var node = TestList.First;
            while (node != null)
            {
                var nextNode = node.Next;
                    if (node.Value == 75)
                {
    
                    TestList.Remove(node);
                }
                node = nextNode;
            }

   // Если сюда ввести 75 эфект будет тот же.
            TestList.Remove(medium);

            Console.WriteLine("После удаления элемента" + medium);

            foreach (var item in TestList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(Environment.NewLine);

            // обобщенная коллекция List
            List<string> countries = new List<string>() { "Россия", "США", "Великобритания", "Китай" };
            countries.Add("Франция");
            countries.RemoveAt(1); // удаление второго элемента
            foreach (string s in countries)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine(Environment.NewLine);


            Console.ReadLine();
        }
    }
}