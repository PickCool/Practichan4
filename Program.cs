using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr4Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            String string1, string2;

            Console.Write("Write the first word = "); string1 = Console.ReadLine();
            Console.Write("Write the second word = "); string2 = Console.ReadLine();

            string1 = new string(string1.Distinct().ToArray());
            List<String> list2 = new List<string>();
            for (int i = 0; i < string2.Length; i++)
            {
                list2.Add(string2[i].ToString());
            }

            for (int i = 0; i < string1.Length; i++)
            {
                Console.WriteLine(string1[i].ToString() + " = " + list2.Exists(symbol => symbol.ToString() == string1[i].ToString()));
            }

            Console.ReadLine();
        }
    }
}
        

    

