using System;

namespace reading_from_command_prompt
{
    class Class1
    {
        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine(args[0]);
            Console.ReadLine();
        }
    }
}
