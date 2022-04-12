using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Laptop
    {
        private string laptopName;
        public string LaptopName
        {
            get
            {
                return laptopName;
            }
            set
            {
                laptopName = value;
            }
        }
        public void LaptopDetails()
        {
            Console.WriteLine("Laptop name is : {0}", laptopName);

        }
        public void keyBoard()
        {
            Console.WriteLine("Type using KeyBoard");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Laptop dell = new Laptop();
            dell.LaptopName = "Dell";
            dell.LaptopDetails();   // Laptop name is : Dell

            Console.ReadLine();
        }
    }
}
