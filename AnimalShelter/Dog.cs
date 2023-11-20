using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    class Dog
    {
        public string Name{get; set;}
        public bool IsNaughtyDog { get; set; }

        public Dog(string name, bool isNaughtyDog)
        {
            this.Name = name;
            this.IsNaughtyDog = isNaughtyDog;
        }

        public void GiveTreat(int numberOfTreats)
        {
            Console.WriteLine("Dog: {0} said wuoff {1} times!", this.Name, numberOfTreats);
        }
    }
}
