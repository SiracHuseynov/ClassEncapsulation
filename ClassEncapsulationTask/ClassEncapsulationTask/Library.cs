using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassEncapsulationTask
{
    internal class Library
    {
        #region void ile yazdigim code mene return hecne qaytarmir
        //public void GetFilteredBooks(string genre) // janr deyeri daxil edib hemin janra uygun kitablarin siyahisini geriye qaytarir.
        //{
        //    bool f = false;
        //    if (Books.Length > 0)
        //    {
        //        for (int i = 0; i < Books.Length; i++)
        //        {
        //            if (Books[i].Genre == genre)
        //            {
        //                f = true;
        //                Console.WriteLine($"{Books[i].Name} {Books[i].No} {Books[i].Price} {Books[i].Count} {Books[i].Genre}");
        //            }
        //        }
        //        if (f == false)
        //        {
        //            Console.WriteLine("Bele janr yoxdur!");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Kitab yoxdur!");
        //    }

        //}
        //GetFilteredBooks(int minPrice, int maxPrice) -> minimum qiymet ve maksimum qiymet qebul edib bu qiymet araligindaki kitablarin siyahisini geriye qaytarir.

        //public void GetFilteredBooks(int minPrice, int maxPrice)
        //{
        //    bool f = false;
        //    if (Books.Length > 0)
        //    {
        //        for (int i = 0; i < Books.Length; i++)
        //        {
        //            if (Books[i].Price > minPrice && Books[i].Price < maxPrice)
        //            {
        //                f = true;
        //                Console.WriteLine($"{Books[i].Name} {Books[i].No} {Books[i].Price} {Books[i].Count} {Books[i].Genre}");
        //            }
        //        }
        //        if (f == false)
        //        {
        //            Console.WriteLine($"{minPrice} {maxPrice} araliginda kitab yoxdur!");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Kitab yoxdur!");
        //    }
        //}
        #endregion

        Book[] Books = new Book[] { };

        public void AddBook(Book book)
        {
            Array.Resize(ref Books, Books.Length + 1);
            Books[Books.Length - 1] = book;
        }

        public void ShowAllBooks()
        {
            if(Books.Length > 0)
            {
                for (int i = 0; i < Books.Length; i++)
                {
                    Console.WriteLine($"Name:{Books[i].Name} No: {Books[i].No} Price:{Books[i].Price} Count:{Books[i].Count} Genre:{Books[i].Genre}");
                }
            }
            else
            {
                Console.WriteLine("Kitab yoxdur!");
            }
        }

        public Book[] GetArray()
        {
            return Books;
        }

        public Book[] GetFilteredBooks(string genre) 
        {
            bool f = false;
            Book[] newBooks = new Book[] { };

            if (Books.Length > 0)
            {
                for (int i = 0; i < Books.Length; i++)
                {
                    if (Books[i].Genre == genre)
                    {
                        f = true;
                        Array.Resize(ref newBooks, newBooks.Length + 1);
                        newBooks[newBooks.Length - 1] = Books[i];
                    }
                }
                if (f == false)
                {
                    Console.WriteLine("Bele janr yoxdur!");
                }
            }
            else
            {
                Console.WriteLine("Kitab yoxdur!");
            }
            return newBooks;
        }

        public Book[] GetFilteredBooks(int minPrice, int maxPrice)
        {
            bool f = false;
            Book[] newBooks = new Book[] { };
            if (Books.Length > 0)
            {
                for (int i = 0; i < Books.Length; i++)
                {
                    if (Books[i].Price > minPrice && Books[i].Price < maxPrice)
                    {
                        f = true;
                        Array.Resize(ref newBooks, newBooks.Length + 1);
                        newBooks[newBooks.Length - 1] = Books[i];
                    }
                }
                if (f == false)
                {
                    Console.WriteLine($"{minPrice} {maxPrice} araliginda kitab yoxdur!");
                }
            }
            else
            {
                Console.WriteLine("Kitab yoxdur!");
            }

            return newBooks;
        }
    }
}
