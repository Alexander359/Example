using System;


namespace HomeWork4._3
{
    class Cat
    {
  //      public event Action WakeUpEvent;
        public event EventHandler WakeUpEvent;

        public string Name { get; set; }

        public void TakeTime(DateTime now)
        {
            if (now.Hour >= 9)
            {
                var args = new EventArgs();
                WakeUpEvent?.Invoke(this, null);
            }
        }
    }
}
