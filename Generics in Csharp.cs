using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_in_Csharp
{
    public class GenericClass<T>
    {
        public T msg;
        public void GenericMethod(T a, T b)
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
    public class SampleClass
    {
        public void GenericMethod<T>(T a, T b)
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }

    // Declare a Delegate in Csharp 
    public delegate T sampleDelegate<T>(T a, T b);
    class MathOperation
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Sub(int a, int b)
        {
            return a - b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GenericClass<string> gClass = new GenericClass<string>();
            gClass.msg = "I Diwakar Singh is going to be the world's best XR developer.";
            gClass.GenericMethod("Diwakar Singh", "Doctor");
            Console.WriteLine(gClass.msg);

            SampleClass sClass = new SampleClass();
            sClass.GenericMethod<string>("Doremon", "Doctor");

            MathOperation m = new MathOperation();
            sampleDelegate<int> dlgt = new sampleDelegate<int>(m.Add);
            Console.WriteLine(dlgt(55, 45));  // 100
            dlgt += m.Sub;
            Console.WriteLine(dlgt(55, 45));  // 10

            Console.ReadLine();
        }
    }
}
