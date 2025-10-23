using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Store
{
    internal class Product
    {
        public string Name;
        public double Price;

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual void display()
        {
            Console.WriteLine($"Name:{Name} Price:{Price}");
        }
    }
    class EProduct : Product
    {
        public string Brand;
        public int Warranty;

        public EProduct(string name, double price , string brand , int warranty) : base(name,price)
        {
            Brand = brand;
            Warranty = warranty;
        }
        public override void display()
        {
            Console.WriteLine($"Name:{Name} Price:{Price} Brand : {Brand} Warranty:{Warranty}");
        }
    }

    class Smartphone : EProduct
    {
        public string OS;
        public int Storage; 

        public Smartphone(string name ,double price  ,string brand ,int warranty,string os,int storage) : base(name,price,brand,warranty)
        {
            OS = os;
            Storage = storage;
        }

        public override void display()
        {
            Console.WriteLine($"Name:{Name} Price:{Price} Brand : {Brand} Warranty:{Warranty} OS:{OS} Storage Capacity:{Storage}");
        }

    }
}

