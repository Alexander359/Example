using System;

namespace HomeWork4
{
    class Delegate1
    {

        delegate void DelegateN1();


        public static MyType D1(int x, int y)
        {
            MyType item1 = new MyType();
            item1.a = x;
            item1.b = y;
            Console.WriteLine(item1.a * item1.b);

            return item1;
            
        }


    }
}
