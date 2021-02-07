using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork4._3
{
    class Human
    {
        public event EventHandler WakeUpEvent;


        public string Name { get; set; }
        public void TakeTime(DateTime now)
        {
            if (now.Hour >= 11)
            {
                WakeUpEvent?.Invoke(this, null);
            }
        }
    }
}
