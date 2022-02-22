using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CA0222
{
    public class Dog : IAnimal,IMammal<Dog>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsFed { get; set; }
        public List<Dog> Puppies = new List<Dog>();
        
        public Dog(string name, int age)
        {
            Name = name;
            Age = age;
           
        }


        public bool Eat(bool feedOrNot)
        {
            if (feedOrNot)
            {
                Console.WriteLine("Your pet is fed");
                return IsFed = true;
            }
            else
            {
                Console.WriteLine("Your pet is hungry, fed him");
                return IsFed = false;
            }
        }

        public Dog GiveBirth(string name, int age)
        {

            Puppies.Add(new Dog(name, age));
            return this;

        }
        public void ShowPuppies()
        {
            foreach (var puppy in Puppies)
            {
                Console.WriteLine(puppy);
            }
        }
        public override string ToString()
        {
            return $"Dog name : {Name}, {Age} years old";
        }


    }
}
