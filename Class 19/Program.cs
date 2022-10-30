using Class_19.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Class_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book> {

                new Book{Id=1, Genre="C Programming", Name="C Learn", CoverPrice=299.00},
                new Book{Id=2, Genre="C++ Programming", Name="C++ Learn", CoverPrice=250.00},
                new Book{Id=3, Genre="C# Programming", Name="C# Learn", CoverPrice=150.00},
                new Book{Id=4, Genre="Java Programming", Name="Java Learn", CoverPrice=225.00},
                new Book{Id=5, Genre="Python Programming", Name="Python Learn", CoverPrice=240.00},
                new Book{Id=6, Genre="Roby Programming", Name="Roby Learn", CoverPrice=560.00},
                new Book{Id=7, Genre="Assembly Programming", Name="Assembly Learn", CoverPrice=1000.00},
                new Book{Id=8, Genre="Assembly Programming", Name="Assembly Extra", CoverPrice=500.00}

            };
            // Find Out the genres 
            // Show Book Name and Cover Price for books > 200

            //var q1 = (from b in books
            //         select b.Genre).Distinct();
            //q1.ToList()
            //    .ForEach(g => Console.WriteLine(g));

            Console.WriteLine("====== Query 1 : Geres ========= ");

            (from b in books
             select b.Genre)
                 .Distinct()
                  .ToList()
                   .ForEach(g => Console.WriteLine(g));


            Console.WriteLine("============= Query 2 : Geres ======= ");

            books.Select(b => b.Genre)
                .Distinct()
                .ToList()
                .ForEach(g => Console.WriteLine(g));


            // Action ()=>
            // Action (string) s =>
            // Action (string, int) (s,i) =>
            // Func <int>
            // Function <string, int> 


            Console.WriteLine("= Query 3 : Book Name and Cover Price > 200");
            Console.WriteLine();

            //(form b in books
            // where b.CoverPrice>200
            // select new {b.Name, b.CoverPrice})       
            //.ToList()
            //    .ForEach(b => Console.WriteLine($"{b.Name} :{b.CoverPrice}"));

            Console.WriteLine("BookName     :    Price      ");
            Console.WriteLine();

            books
                .Where(b => b.CoverPrice > 200)
                  .Select(b => new {b.Name, b.CoverPrice})
                    .ToList()
                      .ForEach((b) => Console.WriteLine($"{b.Name}  :  {b.CoverPrice}"));

         
            Console.WriteLine();


            Console.WriteLine("= Query 4 : Book Name and Cover Price after 9% Discount.");
            Console.WriteLine();

            books
                .Select(b => new { b.Name, b.CoverPrice, DiscountPrice = (b.CoverPrice * .9) })
                .ToList()
                 .ForEach(b => Console.WriteLine($"{b.Name} Original Price: {b.CoverPrice} Discount Price : {b.DiscountPrice}"));


            Console.WriteLine();
            Console.WriteLine("======= Query 5 Grouping ========= ");
            Console.WriteLine();

            var q =( from b in books
                    group b by b.Genre into gr
                    select gr);

            foreach(var b in g)
            {

            }
           



            Console.ReadKey();

        }//Main
    }//Class
}//Namespce
