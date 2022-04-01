using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Book:Product
    {
        public string Author { get; set; }
        public string Genre { get; set; }
        public override string GetInfo()
        {
            return $"{base.GetInfo()}   Author:{Author}     Genre:{Genre}";

        }

    }
}
