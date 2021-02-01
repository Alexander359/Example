using System;
using System.Collections.Generic;
using System.Text;

namespace UserCollection2
{
    class Cars<T>
    {
        protected string Name;

        // универсальныый член класса, потому что тип T
        protected T Price; // Т может быть любым типом

        // конструктор
        public Cars()
        {

        }

        public void SetName(string name)
        {
            Name = name;
        }

        // метод с универсальным параметром T
        public void SetPrice(T price) // Т может быть любым типом
        {
            Price = price;
        }


        public void Show()
        {
            Console.WriteLine("Автомобиль = " + Name + " Цена = " + Price + " $");
        }
    }
}
