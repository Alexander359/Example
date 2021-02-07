using System;

namespace HomeWork4._3
{
    class Dog
    {
        public event EventHandler WakeUpEvent;


        public string Name { get; set; }
        public void TakeTime(DateTime now)
        {
            if (now.Hour >= 9)
            {
                WakeUpEvent?.Invoke(this, null);
            }
        }

    }
}
