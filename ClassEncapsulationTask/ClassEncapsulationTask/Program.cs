using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEncapsulationTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book(1, 20, "beyazgeceler", 3, "dram");
            Book book2 = new Book(2, 15, "sevgisehrasi", 2,"romantika");
            Book book3 = new Book(3, 25, "cleancode", 3,"elm");

            Book book4 = new Book(4, 40, "cinayetveceza", 4,"dram");
            Book book5 = new Book(5, 50, "qururveceza", 5,"romantika");
            Book book6 = new Book(6, 60, "yad", 2,"elm");

            Book book7 = new Book(7, 70, "sucveceza",4, "dram");
            Book book8 = new Book(8, 80, "kicikprens",5, "romantika");
            Book book9 = new Book(9, 90, "Korluq",2, "elm");

            Library library1 = new Library();
            library1.AddBook(book1);
            library1.AddBook(book2);
            library1.AddBook(book3);
            library1.AddBook(book4);
            library1.AddBook(book5);
            library1.AddBook(book6);
            library1.AddBook(book7);
            library1.AddBook(book8);
            library1.AddBook(book9);

            library1.ShowAllBooks();

            //foreach (var item in library1.GetFilteredBooks("romantika"))
            //{
            //    item.ShowInfo();
            //}

            //foreach (var item in library1.GetFilteredBooks(40, 80))
            //{
            //    item.ShowInfo();
            //}


        }

    }
}
