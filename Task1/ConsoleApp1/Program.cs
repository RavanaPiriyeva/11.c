
using System;
using ClassLibrary1;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
            Library library = new Library();

            Console.WriteLine("Nece kitab elave etmek isdeyirsiz ?");
            int count =Convert.ToInt32(Console.ReadLine());
            Book [] book = new Book[count];

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i+1}.Kitabin adini yaz:");
                string name = Console.ReadLine();
                Console.WriteLine($"{i + 1}.Kitabin qiymetini yaz :");
                 double price = Convert.ToDouble(Console.ReadLine());  
                Console.WriteLine($"{i + 1}.kitabin yazicisini yaz:");
                string aouthor = Console.ReadLine();
                Console.WriteLine($"{i + 1}.Kitabin janirini yaz :");
                string genre = Console.ReadLine();
                Book book1 = new Book();
                book1.Author = aouthor;
                book1.Genre = genre;
                book1.Name = name;
                book1.Price = price;    
                
                library.AddProduct(book1);
            }



            Console.WriteLine("Nece journal elave etmek isdeyirsiz ?");
            int count1 = Convert.ToInt32(Console.ReadLine());
            Journal[] journal = new Journal[count1];

            for (int i = 0; i < count1; i++)
            {
                Console.WriteLine($"{i + 1}.Journalin adini yaz:");
                string name = Console.ReadLine();
                Console.WriteLine($"{i + 1}.Journlin qiymetini yaz:");
                double price = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"{i + 1}.Journalin copnaysin yazin :");
                string company = Console.ReadLine();
             
                Journal journal1 = new Journal();
                journal1.Name = name;
                journal1.Price = price; 
                journal1.Company = company;
               

                library.AddProduct(journal1);
            }

            Console.WriteLine("Hansi qiymet araliginda axtarilsin ? Minimum ve Maksimum deyerleri daxil edin:");
            Console.WriteLine("MINIMUM");
            double min = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("MAKSIMUM");
            double max = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hansi ad axtarilsin? Adi daxil edin :");
            string namee = Console.ReadLine();
            Console.WriteLine("============ AXTARILAN QIYMET ARALIGINDAKI MEHSULLAR =============\n");
            foreach (var item in library.GetProductsByPrice(max,min))
            {
               
                Console.WriteLine(item.GetInfo()); 
            }
            Console.WriteLine("\n===================== AXTARILAN ADDAKI MEHSULLAR ==================\n");
            foreach (var item in library.GetProductByName(namee))
            {
                
                Console.WriteLine(item.GetInfo());
            }



        }
    }
}
