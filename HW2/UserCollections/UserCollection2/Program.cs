using System;

namespace UserCollection2
{
    class Program
    {
        static void Main(string[] args)
        {
            // int
            Cars<int> Car1 = new Cars<int>();
            Car1.SetName("SKODA OCTAVIA");
            Car1.SetPrice(18000);
            Car1.Show();
          

            //  string
            Cars<string> Car2 = new Cars<string>();
            Car2.SetName("ROLLS-ROYCE PHANTOM VIII");
            Car2.SetPrice("миллион");
            Car2.Show();
         
        }
    }
}
