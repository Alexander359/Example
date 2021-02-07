using System;

namespace HomeWork4
{
    class Delegate2
    {
        delegate MyType DelegateN2();

        public static MyType D2(int x, int y)
        {
            MyType item2 = new MyType();
            item2.a = x;
            item2.b = y;
            Console.WriteLine(item2.a + item2.b);
            
            return item2;

        }


 

    }
}
