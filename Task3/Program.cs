using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {

            Sheep sheep1 = new Sheep();
            sheep1.Name = "qoyun";
            sheep1.Gender = "fhdj";
            sheep1.Age = 2;
            sheep1.Type = "ghsdfg";


            Horse horse1 = new Horse();
            horse1.Name = "at";
            horse1.Gender = "jdfgd";
            horse1.Age = 54;
            horse1.Sort = "jdfhsf";

            Farm farm = new Farm();
            farm.AddAnimal(horse1);
            farm.AddAnimal(sheep1);
            foreach (var item in farm.Animals)
            {
                Console.WriteLine(item.Name);
            }


     

            //farm.GetInfo(animal);
        }
    }
}
