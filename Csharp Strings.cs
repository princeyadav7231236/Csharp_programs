using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\Users\Microsoft Office\Documents\";  // this @ (at the rate) symbol serves as a Verbatim litertal (string literal)-----------
            Console.WriteLine(path);

            string msg = @"Heloooo Doctor,
How're You'
Tabiyat kaise hai aapke";
            Console.WriteLine(msg);

            string msg1 = @"Hello ""Meri Pyari Doctor""";
            Console.WriteLine(msg1);

            // Format method of String
            string name = "Shinchan";
            string name2 = "Pyari Doctor";
            string User = string.Format("Name : {0}, Name : {1}", name2, name);
            Console.WriteLine(User);
            Console.ReadLine();
        }
    }
}
