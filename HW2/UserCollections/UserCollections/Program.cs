using System;

namespace UserCollections
{
    class Program
    {
        static void Main(string[] args)
        {

            MyList mi = new MyList();

            mi.AddItem(101);
            mi.AddItem(102);
            mi.AddItem(103);
            mi.AddItem(104);
            mi.AddItem(105);
            mi.AddItem(106);
            mi.AddItem(107);
            mi.AddItem(108);
            mi.AddItem(109);
            mi.AddItem(110);


            foreach (int i in mi)
                Console.Write(i + "\t");

            mi.RemoveItem();
            foreach (int i in mi)
                Console.Write(i + "\t");



            Console.ReadLine();

        }
    }
}
