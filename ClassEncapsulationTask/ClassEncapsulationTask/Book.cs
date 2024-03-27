using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEncapsulationTask
{
    internal class Book : Product
    {
        public string Genre;

        public Book(int no, double price, string name, int count, string genre) : base(no, price, name, count)
        {
            this.Genre = genre;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name:{Name} No: {No},Price: {Price} Count: {Count} Genre: {Genre}");
        }
    }
}
