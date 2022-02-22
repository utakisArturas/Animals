using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA0222
{
    internal class Cat :IAnimal,IMammal<Cat>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsFed { get; set; }
        public List<Cat> Kittens = new List<Cat>();
        public Cat(string name, int age)
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
        public Cat GiveBirth(string name, int age)
        {

            Kittens.Add(new Cat(name, age));
            return this;

        }
        public void ShowKittens()
        {
            foreach (var cat in Kittens)
            {
                Console.WriteLine(cat);
            }
        }
        public override string ToString()
        {
            return $"Cat name : {Name}, {Age} years old";
        }
    }
}
