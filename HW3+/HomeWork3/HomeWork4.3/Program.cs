using System;

namespace HomeWork4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat { 
            Name = "Кот"
            };
            cat.WakeUpEvent += Cat_WakeUpEvent;
            Dog dog = new Dog { 
            Name ="Собака"
            };
            Mouse mouse = new Mouse
            {
                Name = "Мышь"
            };
            Human human = new Human
            {
                Name = "Человек"
            };
            dog.WakeUpEvent += Cat_WakeUpEvent;
            mouse.WakeUpEvent += Cat_WakeUpEvent;
            human.WakeUpEvent += Cat_WakeUpEvent;
            dog.TakeTime(DateTime.Parse("01.02.2021 8:15:21"));
            dog.TakeTime(DateTime.Parse("01.02.2021 23:15:21"));
            cat.TakeTime(DateTime.Parse("01.02.2021 8:15:21"));
            cat.TakeTime(DateTime.Parse("01.02.2021 22:18:41"));
            mouse.TakeTime(DateTime.Parse("01.02.2021 9:15:21"));
            mouse.TakeTime(DateTime.Parse("01.02.2021 22:18:41"));
            human.TakeTime(DateTime.Parse("01.02.2021 10:15:21"));
            human.TakeTime(DateTime.Parse("01.02.2021 22:18:41"));
        }

        private static void Cat_WakeUpEvent(object sender, EventArgs e)
        {
            if (sender is Cat)        
            Console.WriteLine($"{((Cat)sender).Name} проснулся");

            if (sender is Dog)
                Console.WriteLine($"{((Dog)sender).Name} проснулась");

            if (sender is Mouse)
                Console.WriteLine($"{((Mouse)sender).Name} проснулась");
            if (sender is Human)
                Console.WriteLine($"{((Human)sender).Name} проснулся");





        }


    }
}
