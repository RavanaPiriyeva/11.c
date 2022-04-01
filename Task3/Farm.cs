using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    public class Farm
    {
        public Farm()
        {
            this.Animals = new Animal[0];

        }
       public  Animal[] Animals;
        public void AddAnimal(Animal animals)
        {
            Array.Resize(ref Animals, Animals.Length + 1);
            Animals[Animals.Length - 1] = animals;


        }

        public void GetInfo (Animal[] animal)
        {
           

        }
    }
}
