using System;
using ClassLibrary1;
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            Console.WriteLine("Ad daxil et :");
            string name = Console.ReadLine();
            Console.WriteLine("Soyad daxil et:");
            string surname = Console.ReadLine();
            bool check1 = true;
            do
            {if (check1)
                {
                    Console.WriteLine("Yas daxil et:");
                    check1 = false;
                }
                else
                {
                    Console.WriteLine("Islemek huququ yoxdur yasi duzgun daxil et:");
                }
                age = Convert.ToInt32(Console.ReadLine());
            } while (age < 18);
      
            double salaryofhour = 0;
            int workinghour = 0;
            double x = 0;
            bool check = true;
            do
            {
                if (check)
                {
                    Console.WriteLine("Saatliq masi daxil et:");
                    salaryofhour = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Nece saat isleyib?");
                    workinghour = Convert.ToInt32(Console.ReadLine());
                    check = false;
                }
                else {
                    Console.WriteLine("Saatliq masi duzgun  daxil et:");
                    salaryofhour = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Nece saat isleyib duzgun daxil et:");
                    workinghour = Convert.ToInt32(Console.ReadLine());
                }
                x = salaryofhour * workinghour;
            }
            while (x <= 250);
                Employee employee = new Employee(name, surname, age, salaryofhour, workinghour);
         

            Console.WriteLine( "Sagird elave et :");

            int age1 = 0;
            Console.WriteLine("Ad daxil et :");
            string name1 = Console.ReadLine();
            Console.WriteLine("Soyad daxil et:");
            string surname1 = Console.ReadLine();
            bool check2 = true;
            do 
            {
                if (check2)
                {
                    Console.WriteLine("Yas daxil et:");
                    check2 = false;
                }
                else
                {
                    Console.WriteLine("Yasi duzgun daxil et!!!");
                }
                age1 = Convert.ToInt32(Console.ReadLine());
            }
             while (age1 < 6 || age1 >20);
            int iqrank = 0;
            bool check3 = true;
            do {
                if (check3) { 
            Console.WriteLine("IQ Rank elave et:");
                    check3 = false;
                }
                else
                {
                    Console.WriteLine("IQ Rank duzgun daxil edin !!! 0 - 100 arasi ola biler");
                }
                iqrank = Convert.ToInt32(Console.ReadLine());
            }
            while(iqrank<0 || iqrank >100);



            int languagerank = 0;
            bool check4 = true;
            do
            {
                if (check4)
                {
                    Console.WriteLine("Languge Rank elave et:");
                    check4 = false;
                }
                else
                {
                    Console.WriteLine("Languge Rank duzgun daxil edin !!! 0 - 100 arasi ola biler");
                }
                languagerank = Convert.ToInt32(Console.ReadLine());
            }
            while (languagerank < 0 || languagerank > 100);

            Student student = new Student(name1, surname1 , age1 , iqrank , languagerank);

            Console.WriteLine("\n======================Isci==========================\n");
            Console.WriteLine(employee.GetInfo());

            Console.WriteLine("\n======================Telebe==========================\n");
            Console.WriteLine(student.GetInfo());
            student.ExamResult();
        }
    }
}
