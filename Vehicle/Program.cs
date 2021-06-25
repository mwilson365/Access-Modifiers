using System;

namespace Vehicles
{
    class Program
    {
       internal  class vehicle
        {

            public int numWheels;

            Car myCar = new Car();

        
            protected class Car : vehicle
            {
            
            
            }

            protected class Semi : vehicle
            {

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
