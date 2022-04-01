using System;

namespace ClassLibrary1
{
    public abstract class Person
    {
        public Person(string name , string surname , int age)
        {
            this.Name = name;
            this.Surname = surname; 
            this.Age = age;
        }
        
       public string Name { get; set; }
       
        public string Surname { get; set; }

        public int Age { get; set; }
        

        public virtual string GetInfo()
        {
            return $"Name:{Name}     Surname:{Surname}     Age:{Age}";
        }
    }
}
