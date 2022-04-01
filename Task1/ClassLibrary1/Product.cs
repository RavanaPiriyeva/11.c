using System;

namespace ClassLibrary1
{
    public abstract  class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public virtual string GetInfo()
        {
            return $"Name:{Name}    Price:{Price}";
        }

    }
}
