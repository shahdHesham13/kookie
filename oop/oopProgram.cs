using System;

namespace kookie
{
    class oopProgram
    {
        static void Main(string[] args)
        {
            // static = modifier to declare a static member, which belongs to the class itself
            //          rather than to any specific object

            Car car1 = new Car("Mustang");
            Car car2 = new Car("Corvette");
            Car car3 = new Car("Lambo");

            Console.WriteLine(Car.numberOfCars);
            Car.StartRace();

            Console.ReadKey();
        }
    }
    class Car
    {
        String model;
        public static int numberOfCars;

        public Car(String model)
        {
            this.model = model;
            numberOfCars++;    //every time we initiate an object increment by 1
             
                               // non-static way by saying the object name
        }

        public static void StartRace()
        {
            Console.WriteLine("The race has begun!");
        }
    }
}