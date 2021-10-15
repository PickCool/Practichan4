using System.Diagnostics;
using System;

namespace zd1
{
    public class Class2: Class1
    {
        public override void PrintAndDebug(params object[] args)
        {
            Debug.WriteLine("Arguments:");
            Debug.Indent();         
            foreach (var arg in args)
                Debug.WriteLine($"{arg.GetType()}: {arg}");

            Debug.Unindent();
        }
    }
}



