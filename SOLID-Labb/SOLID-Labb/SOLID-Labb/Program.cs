using System;

namespace SOLID_Labb
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = animalColor();
            Console.WriteLine("###############");
            Console.WriteLine();
            PrintAnimalDo(animals);
            Console.WriteLine("###############");
            Console.WriteLine();

        }

        static Animal[] animalColor()
        {
            Animal[] animals = {new Dog("Black"),
                            new Hedgehog("Pink"),
                            new Bird("Yellow")};

            return animals;
        }

        static void PrintAnimalDo(Animal[] animals)
        {
            foreach (var animal in animals)
            {
                if (animal is Dog dog)
                {
                    dog.TransferOwnership("Niklas");
                }
                AnimalDo(animal);
            }
        }    
        static void AnimalDo(Animal animal)
        {
            animal.Eat();
            animal.Sleep();
            animal.Speak();
            animalColor();
            Console.WriteLine(animal.GetType().Name + " is " + animal._color);
            Console.WriteLine();

        } //animal._color = "Grey";
    }
}

