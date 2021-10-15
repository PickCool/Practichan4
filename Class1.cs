using System.Diagnostics;
using System;
using System.Text;

namespace zd1
{
    public class Class1
    {
        public virtual void PrintAndDebug(params object[] args)
        {
            Debug.WriteLine("Arguments:");
            Debug.Indent();

            foreach (var arg in args)
                Debug.WriteLine(arg);

            Debug.Unindent();
        }
    }
}
