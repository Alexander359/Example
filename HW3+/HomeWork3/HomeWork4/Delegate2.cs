using System;

namespace HomeWork4
{
    class Delegate2
    {
        delegate void DelegateN2();

        public static MyType D2(int x, int y)
        {
            MyType item = new MyType();
            item.a = x;
            item.b = y;
            Console.WriteLine(item.a + item.b);
            
            return item;

        }


 

    }
}
