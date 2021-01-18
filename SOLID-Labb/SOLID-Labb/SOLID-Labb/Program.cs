using System;

namespace SOLID_Labb
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("###############");
            Console.WriteLine();
        }

            static void AnimalColor(string[] args)
            {
                Animal[] animals = {new Dog("Black"),
                            new Hedgehog("Pink"),
                            new Bird("Yellow")};
            }
            static void Print(string[] args, Animal[] animals)
            {
                foreach (var animal in animals)
                {
                    if (animal is Dog dog)
                    {
                        dog.TransferOwnership("Niklas");
                    }

                    animal.Eat();
                    animal.Sleep();
                    animal.Speak();
                    animal._color = "Grey";
                    Console.WriteLine(animal.GetType().Name + " is " + animal._color);
                    Console.WriteLine();

                    Console.WriteLine("###############");
                    Console.WriteLine();
                }
            }
        
    }
}

