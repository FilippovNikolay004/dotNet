using System;

namespace CSharp.Classes
{
    class Car(string driverName, int speed)
    {
        public Car() : this("Михаэль Шумахер", 0)
        {

        }
        public Car(string driverName) : this(driverName, 0)
        {
        }
        /*
        public Car(string driverName, int speed) // Главный конструктор
        {
            this.driverName = driverName;
            currSpeed = speed;
        }
        */
        public void SetDriver(string name) =>
            driverName = name;

        public void PrintState()		// Распечатка текущих данных
        {
            Console.WriteLine("{0} едет со скоростью {1} км/ч.",
                driverName, speed);
        }   
        public void SpeedUp(int delta)	// Увеличение скорости
        {
            speed += delta;
        }
    }

}
