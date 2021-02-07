using System;

namespace HomeWork4_2
{
    class Program
    {

        public delegate void MyDelegate();
        public delegate int ValueDelegate(int i);

        static void Main(string[] args)
        {

            MyDelegate myDelegate = Method1;
            myDelegate += Method4;
            myDelegate();

            MyDelegate myDelegate1 = new MyDelegate (Method4);

            myDelegate1.Invoke();

            ValueDelegate valueDelegate = new ValueDelegate(MethodValue);
            valueDelegate(33);




            Console.ReadLine();

        }


        public static int MethodValue (int i)
        {
            Console.WriteLine(i);
            return i;
        }

        public static void Method1()
        {
            Console.WriteLine("Method1");
        }

        public static int Method2()
        {
            Console.WriteLine("Method2");
            return 0;
        }

        public static void Method3(int i)
        {
            Console.WriteLine("Method3");
        }

        public static void Method4()
        {
            Console.WriteLine("Method4");
        }


    }
}
