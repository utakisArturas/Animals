using System;
using System.Collections.Generic;

namespace CA0222
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog("Rex",5);
            var dog1 = dog.GiveBirth("Wolf", 5);
            var dog2 = dog.GiveBirth("Boxer", 0);

            var cat = new Cat("Munis",1);
            var cat1 = cat.GiveBirth("Garfield", 2);
            

            dog.ShowPuppies();
            cat.ShowKittens();
            var animals = new List<IAnimal>() { dog, dog1, dog2, cat };
            animals.ForEach(animal => animal.Eat(true));

            var dogComparer = new DogsComparer();
            dogComparer.Compare(dog1, dog2);

        }
    }
}
