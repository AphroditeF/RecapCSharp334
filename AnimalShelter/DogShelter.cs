﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{

    class DogShelter : IEnumerable<Dog>
    {
        public List<Dog> dogs;

        public DogShelter() 
        {
            dogs = new List<Dog>()
            {
                new Dog("Casper", false),
                new Dog("Sif", true),
                new Dog("Oreo", false),
                new Dog("Pixel", false) 
            };
        }

        IEnumerator<Dog> IEnumerable<Dog>.GetEnumerator()
        {
            return dogs.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()  //non-generic enumerator   //we don't impliment it because we don't use a non-generic example
        {
            throw new NotImplementedException();
        }
    }
}
