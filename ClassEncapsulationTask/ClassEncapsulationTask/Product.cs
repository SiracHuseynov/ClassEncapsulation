using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEncapsulationTask
{
    internal class Product
    {
        private double _price;
        private int _count;
        public int No;
        public string Name;

        public double Price 
        { 
            get
            {
                return _price;
            }
            set
            {
                if(value > 0)
                {
                    _price = value;
                }
            }
        }
        public int Count
        {
            get
            {
                return _count;
            }
            set
            {
                if(value > 0)
                {
                    _count = value;
                }
            }
        }
        public Product(int no, double price, string name, int count)
        {
            this.No = no;
            this.Price = price;
            this.Name = name;
            this.Count = count;
        }


    }
}
