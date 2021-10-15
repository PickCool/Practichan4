using System;
using System.Diagnostics;
using System.Text;

namespace zd1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1[] classes = new[]
            {
                new Class1(),
                new Class2()
            };

            foreach (Class1 c in classes)
                c.PrintAndDebug(322, 14.88d, 133.7f, 488.87m, new object(), "String");

            Console.ReadLine();
        }
    }
}
