using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Student:Person
    {
        public Student(string name , string surname, int age , int iqrank , int laguagerank):base(name ,surname, age)
        {
            this.IQRank = iqrank;
            this.LanguageRank = laguagerank;
        }
        public int IQRank { get; set; }
        public int LanguageRank { get; set; }
public void ExamResult()
        {
            if (IQRank+LanguageRank < 120)
            {
                Console.WriteLine("Telebe sinifde qaldi ");
            }
        }
        public override string GetInfo()
        {
            return $"{base.GetInfo()}   Iq Rank:{IQRank}     Language Rank:{LanguageRank}" ;
        }
    }
}
